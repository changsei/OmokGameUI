using Form_Repository;
using Forms_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Game_Client_Forms.OmokGameHandler;
using Message = Forms_Model.Message;

namespace Game_Client_Forms
{
    public partial class GameForm : Form
    {
        // 네트워크 관련 
        private Client _client;
        private GameRoom _currentRoom;
        private OmokGameHandler _gameHandler;

        // 오목 그래픽 구현
        private Graphics _graphics;
        private Pen _pen;
        private Brush _whiteBrush, _blackBrush;
        private int _margin = 40;
        private int _gridSize = 30;
        private int _stoneSize = 25;
        private int _flowerSize = 10;

        public GameForm()
        {
            _client = Client.Instance;
            _gameHandler = new OmokGameHandler();
            InitializeComponent();
        }

        private void pnlGameBoard_MouseDown(object sender, MouseEventArgs e)
        {
            string userType = CheckMainOrSubUerByClientName();
            if (!_currentRoom.CheckReadyToStart()) return;
            if (!(_gameHandler.GetUserTurnByUserType(userType) == _gameHandler.CurrentTurn)) return;
            
            int x = (e.X - _margin + _gridSize / 2) / _gridSize;
            int y = (e.Y - _margin + _gridSize / 2) / _gridSize;
            if (!_gameHandler.CheckStone(x, y)) return;

            pnlGameBoard.MouseDown -= pnlGameBoard_MouseDown;

            _client.SendToServer(() => new Message
            {
                Name = _client.GetClientName(),
                Destination = "GAME_ROOM",
                RequestType = "MOVE_STONE",
                Text = _client.GetGameRoomRepository().ConvertGameMoveToJson(new GameMove
                {
                    Text = _currentRoom.Name,
                    X = x,
                    Y = y
                })
            });
        }

        private void OnTurnReceived()
        {
            // 마우스 다운 이벤트를 다시 활성화
            pnlGameBoard.MouseDown += pnlGameBoard_MouseDown;
        }

        // 오목 로직 관련
        // 그래픽

        public void DrawStonOnBoard(int x, int y)
        {
            Rectangle rectangleForDraw = new Rectangle(
            _margin + _gridSize * x - _stoneSize / 2,
            _margin + _gridSize * y - _stoneSize / 2,
            _stoneSize, _stoneSize);

            if (_gameHandler.CurrentTurn == OmokGameHandler.Player.Main)
            {
                _graphics.FillEllipse(_blackBrush, rectangleForDraw);
            }
            else
            {
                _graphics.FillEllipse(_whiteBrush, rectangleForDraw);
            }

            if ((_gameHandler.GetUserTurnByUserType(CheckMainOrSubUerByClientName()) == _gameHandler.CurrentTurn))
            {
                this.OnTurnReceived();
            }
            _gameHandler.InsertGameBoard(x, y);
        }

        private void RedrawStones()
        {
            for (int x = 0; x < 19; x++)
            {
                for (int y = 0; y < 19; y++)
                {
                    if (_gameHandler._board[x, y] != OmokGameHandler.STONE.none)
                    {
                        DrawStoneOnBoard(x, y, _gameHandler._board[x, y]);
                    }
                }
            }
        }

        private void DrawStoneOnBoard(int x, int y, OmokGameHandler.STONE stone)
        {
            var brush = stone == OmokGameHandler.STONE.black ? _blackBrush : _whiteBrush;
            Rectangle rectangleForDraw = new Rectangle(
                _margin + _gridSize * x - _stoneSize / 2,
                _margin + _gridSize * y - _stoneSize / 2,
                _stoneSize, _stoneSize);
            _graphics.FillEllipse(brush, rectangleForDraw);
        }

        private void pnlGameBoard_Paint(object sender, PaintEventArgs e)
        {
            Invoke((MethodInvoker)((() => DrawBoard())));
            Invoke((MethodInvoker)((() => RedrawStones())));
        }

        private void DrawBoard()
        {
            this.InitializeGrapicTools();
            _graphics = pnlGameBoard.CreateGraphics();

            for (int i = 0; i < 19; i++)
            {
                _graphics.DrawLine(_pen, new Point(_margin + i * _gridSize, _margin),
                  new Point(_margin + i * _gridSize, _margin + 18 * _gridSize));
            }

            for (int i = 0; i < 19; i++)
            {
                _graphics.DrawLine(_pen, new Point(_margin, _margin + i * _gridSize),
                  new Point(_margin + 18 * _gridSize, _margin + i * _gridSize));
            }

            for (int x = 3; x <= 15; x += 6)
            {
                for (int y = 3; y <= 15; y += 6)
                {
                    _graphics.FillEllipse(_blackBrush,
                      _margin + _gridSize * x - _flowerSize / 2,
                      _margin + _gridSize * y - _flowerSize / 2,
                      _flowerSize, _flowerSize);
                }
            }
        }

        private void InitializeGrapicTools()
        {
            pnlGameBoard.BackColor = Color.SandyBrown;
            _pen = new Pen(Color.Black);
            _blackBrush = new SolidBrush(Color.Black);
            _whiteBrush = new SolidBrush(Color.White);
        }
        
        // 그래픽 

        private void GameForm_Load(object sender, EventArgs e)
        {
            tBoxUserChat.PlaceholderText = "여기에 채팅 내용을 입력해주세요.";
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Name = _client.GetClientName(),
                Destination = "GAME_ROOM",
                RequestType = "EXIT_GAME_ROOM",
                Text = _currentRoom.Name
            });
        }

        private void btnInputUserChat_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "GAME_ROOM",
                RequestType = "CHAT",
                Name = _client.GetClientName(),
                Text = tBoxUserChat.Text
            });
            string myChatLog = $"[나]: {tBoxUserChat.Text}";
            ShowGameRoomChatLog(myChatLog);
        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "GAME_ROOM",
                RequestType = "SURRENDER",
                Name = _client.GetClientName(),
                Text = _currentRoom.Name
            });
            
            btnSurrender.Enabled = false;
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "GAME_ROOM",
                RequestType = "READY_TO_START",
                Name = _client.GetClientName(),
                Text = _currentRoom.Name
            });

            btnReady.Enabled = false;
        }

        private void ShowGameRoomUserInfo()
        {
            lblMainUserName.Text = 
                _currentRoom.MainUser == null ? "NULL" : CheckMainOrSubUerByClientName().Equals("MAIN_USER") ? $"[나]: {_currentRoom.MainUser}" : $"[상대]: {_currentRoom.MainUser}";
            lblSubUserName.Text = 
                _currentRoom.MainUser == null ? "NULL" : CheckMainOrSubUerByClientName().Equals("SUB_USER") ? $"[나]: {_currentRoom.SubUser}" : $"[상대]: {_currentRoom.SubUser}";
            lblMainUserReady.Text = _currentRoom.MainUserReady == true ? "준비 됨" : "준비 안됨";
            lblSubUserReady.Text = _currentRoom.SubUserReady == true ? "준비 됨" : "준비 안됨";
            btnSurrender.Enabled = _currentRoom.CheckReadyToStart();
            btnReady.Enabled = CheckBtnReady();
        }

        private bool CheckBtnReady()
        {
            if (_client.GetClientName().Equals(_currentRoom.MainUser))
            {
                if (_currentRoom.MainUserReady)
                {
                    return false;
                }

                if (_currentRoom.SubUserReady)
                {
                    return true;
                }
                // 메인 유저 이며, 서브 유저가 준비 안된 경우, 비활성화
                return false;
            }

            if (_currentRoom.SubUserReady)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private string CheckMainOrSubUerByClientName()
        {
            string clientName = _client.GetClientName();    
            if (clientName.Equals(_currentRoom.MainUser)) return "MAIN_USER";
            else { return "SUB_USER"; }
        }

        public void ShowGameRoomChatLog(string chatLog)
        {
            richBoxUserChatLog.AppendText(chatLog + Environment.NewLine);
            Application.DoEvents();
        }

        public void ShowGameRoomSystemLog(string systemLog)
        {
            richBoxGameLog.AppendText(systemLog + Environment.NewLine);
            Application.DoEvents();
        }

        public GameRoom GetCurrentGameRoom()
        {
            return this._currentRoom;
        }

        public void SetCurrentGameRoom(GameRoom room)
        {
            this._currentRoom = room;
            this.ShowGameRoomUserInfo();
            _gameHandler.RegistUserTurn(CheckMainOrSubUerByClientName());

            if (_currentRoom.CheckReadyToStart())
            {
                _gameHandler.Initialize();
                pnlGameBoard.Invalidate();
                Invoke((MethodInvoker)((() => InitializeGrapicTools())));
                Invoke((MethodInvoker)((() => DrawBoard())));
                ShowGameRoomSystemLog($"[게임]: 시작");
            }
        }
    }

    public class OmokGameHandler
    {
        private static readonly int MAX_BOARD_LENGTH = 19;
        public enum STONE { none, black, white };
        public enum Player { Main = 1, Sub = 2 };

        public STONE[,] _board = new STONE[MAX_BOARD_LENGTH, MAX_BOARD_LENGTH];
        public Player CurrentTurn { get; set; } = Player.Main;

        public Dictionary<string, Player> UserTurn { get; set; } = new Dictionary<string, Player>();


        public void Initialize()
        {
            CurrentTurn = Player.Main;

            for (int i = 0; i < MAX_BOARD_LENGTH; i++)
            {
                for (int j = 0; j < MAX_BOARD_LENGTH; j++)
                {
                    _board[i, j] = STONE.none;
                }
            }
        }

        public Player GetUserTurnByUserType(string userType)
        {
            try
            {
                return UserTurn[userType];
            } catch (Exception e) {

            }
            return 0;
        }

        public void RegistUserTurn(string userType)
        {
            UserTurn.Clear();
            if (userType.Equals("MAIN_USER")) 
            {
                UserTurn[userType] = Player.Main;
            } 
            else
            {
                UserTurn[userType] = Player.Sub;
            }
        }

        public bool CheckStone(int x, int y)
        {
            if (x >= MAX_BOARD_LENGTH || y >= MAX_BOARD_LENGTH) return false;
            if (_board[x, y] != STONE.none) return false;
            return true;
        }

        public void ChangeTurn()
        {
            CurrentTurn = CurrentTurn == Player.Main ? Player.Sub : Player.Main;
        }

        public void InsertGameBoard(int x, int y)
        {
            if (CheckStone(x, y))
            {
                _board[x, y] = CurrentTurn == Player.Main ? STONE.black : STONE.white;
                ChangeTurn(); 
            }
        }
    }
}
