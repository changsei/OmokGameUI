using Form_Repository;
using Forms_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = Forms_Model.Message;

namespace Game_Client_Forms
{
    public partial class MainRobbyForm : Form
    {
        private Client _client;
        private LoginForm _loginForm;
        private Label[] _lblRoomNames;
        private Label[] _lblRoomMainUserNames;
        private Label[] _lblRoomSubUserNames;
        private Label[] _lblRoomUseStatus;
        private Button[] _btnEnteranceGameRooms;
        private const int _maxLblSize = 3;

        public MainRobbyForm()
        {
            InitializeComponent();
            _loginForm = LoginForm.Instance;
            _client = Client.Instance;
            _lblRoomNames = new Label[_maxLblSize];
            _lblRoomMainUserNames = new Label[_maxLblSize];
            _lblRoomSubUserNames = new Label[_maxLblSize];
            _lblRoomUseStatus = new Label[_maxLblSize];
            _btnEnteranceGameRooms = new Button[_maxLblSize];

            for (int i = 0; i < _maxLblSize; i++)
            {
                _lblRoomNames[i] = (Label)Controls.Find($"lblRoomNumber{i + 1}", true)[0];
                _lblRoomMainUserNames[i] = (Label)Controls.Find($"lblRoomMainUserName{i + 1}", true)[0];
                _lblRoomSubUserNames[i] = (Label)Controls.Find($"lblRoomSubUserName{i + 1}", true)[0];
                _lblRoomUseStatus[i] = (Label)Controls.Find($"lblRoomUseStatus{i + 1}", true)[0];
                _btnEnteranceGameRooms[i] = (Button)Controls.Find($"btnEnteranceRoom{i + 1}", true)[0];
            }
        }

        private void MainRobbyForm_Load(object sender, EventArgs e)
        {
            tBoxUserChat.PlaceholderText = "여기에 채팅을 입력 해 주세요.";
            RenewMainRobby();
        }

        private void MainRobbyForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _loginForm.Show();
            this.Dispose();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            _client.DisConnectToServer();
        }

        private void btnExitClient_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInputUserChat_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "MAIN_ROBBY",
                RequestType = "CHAT",
                Name = _client.GetClientName(),
                Text = tBoxUserChat.Text
            });
            string myChatLog = $"[나]: {tBoxUserChat.Text}";
            ShowMainRobbyChatLog(myChatLog);
        }

        private void btnEnteranceRoom_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "GAME_ROOM",
                RequestType = "ENTERANCE_GAME_ROOM",
                Name = _client.GetClientName(),
                Text = "ROOM1"
            });
        }

        private void btnEnteranceRoom2_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "GAME_ROOM",
                RequestType = "ENTERANCE_GAME_ROOM",
                Name = _client.GetClientName(),
                Text = "ROOM2"
            });
        }

        private void btnEnteranceRoom3_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "GAME_ROOM",
                RequestType = "ENTERANCE_GAME_ROOM",
                Name = _client.GetClientName(),
                Text = "ROOM3"
            });
        }

        public void RenewMainRobby()
        {
            int i = 0;
            foreach (GameRoom gameRoom in _client.GetGameRoomRepository().GetRooms())
            {
                _lblRoomNames[i].Text = gameRoom.Name;
                _lblRoomMainUserNames[i].Text = gameRoom.MainUser;
                _lblRoomSubUserNames[i].Text = gameRoom.SubUser;
                _lblRoomUseStatus[i].Text = gameRoom.State == true ? "입장가능" : "입장불가";
                _btnEnteranceGameRooms[i].Enabled = gameRoom.State == true ? true : false;
                i++;
            }

            Application.DoEvents();
        }

        public void ShowMainRobbyChatLog(string chatLog)
        {
            richBoxAllUserChatLog.AppendText(chatLog + Environment.NewLine);
            Application.DoEvents();
        }
    }
}
