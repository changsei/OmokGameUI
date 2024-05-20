

using Socket_Handler_Form;
using System.Net.Sockets;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Microsoft.VisualBasic.ApplicationServices;
using  Forms_Model;
using Message = Forms_Model.Message;
using System.Windows.Forms;
using System.Net.WebSockets;
using Form_Repository;
using User = Forms_Model.User;

namespace Game_Client_Forms
{
    public partial class LoginForm : Form
    {
        private static LoginForm? _instance;
        private GameForm? _gameform;
        private MainRobbyForm? _mainRobbyform;
        private UserInfoRegisterForm? _userInfoRegisterform;
        private UserInfoUnregisterForm? _userInfounregisterform;
        private UserIdInfoForm? _userIdInfoForm;
        private UserInfoForm? _userInfoForm;
        private UserPasswordSettingForm? _userPasswordSettingForm;
        private Client _client;
        private Logger _logger;

        private LoginForm()
        {
            _logger = Logger.Instance;
            _client = Client.Instance;
            _client.MessageReceived += OnMessageReceived;
            InitializeComponent();
        }

        public static LoginForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginForm();
                }
                return _instance;
            }
        }

        private void OnMessageReceived(Message message)
        {
            _logger.Log(Logger.LogLevel.Info, $"[메시지 타입]: {message.RequestType} - [메시지 내용]: {message.Text}");

            switch (message.RequestType)
            {
                case "DISCONNECT_RESPONSE":
                    Invoke((MethodInvoker)(() => ProcessDisConnectResponse()));
                    break;
                case "CHAT_RESPONSE":
                    if (message.Destination.Equals("MAIN_ROBBY"))
                    {
                        Invoke((MethodInvoker)(() => ProcessAllChatResponse(message.Text)));
                    }
                    else if (message.Destination.Equals("GAME_ROOM"))
                    {
                        Invoke((MethodInvoker)(() => ProcessChatResponse(message.Text)));
                    }
                    break;
                case "ENTERANCE_RESPONSE":
                    Invoke((MethodInvoker)(() => ProcessEnteranceResponse(message.Text)));
                    break;
                case "EXIT_RESPONSE":
                    Invoke((MethodInvoker)(() => ProcesssGameRoomExitResponse(message.Text)));
                    break;
                case "GAMEROOM_RENEW_RESPONSE":
                    Invoke((MethodInvoker)(() => ProcessGameRoomRenewResponse(message.Text)));
                    break;
                case "LOGIN_RESPONSE":
                    if (message.Text.Equals("ACCEPT_NORMAL_USER"))
                    {
                        _logger.Log(Logger.LogLevel.Info, "로그인 되었습니다.");
                        Invoke((MethodInvoker)(() => ProcessLoginResponse()));
                    }
                    else
                    {
                        if (message.Destination.Equals("MAIN_ROBBY"))
                        {
                            _client.SetGameRoomRepository(message.Text);
                            Invoke((MethodInvoker)(() => _mainRobbyform.RenewMainRobby()));
                            break;
                        }
                        else
                        {
                            _logger.Log(Logger.LogLevel.Info, "해당하는 회원이 없습니다.");
                            _client.DisConnectToServer();
                        }
                    }
                    break;
                case "REGIST_RESPONSE":
                    if (message.Text.Equals("CONNECTED"))
                    {
                        Invoke((MethodInvoker)(() => ProcessRegistResponse()));
                    }
                    else if (message.Text.Equals("COMPLETED"))
                    {
                        _logger.Log(Logger.LogLevel.Info, "등록이 완료 되었습니다.");
                    }
                    else
                    {
                        _logger.Log(Logger.LogLevel.Info, "계정 중복 입니다.");
                    }
                    break;
                case "SEARCH_RESPONSE":
                    if (message.Text.Equals("CONNECTED"))
                    {
                        Invoke((MethodInvoker)((() => ProcessSearchResponse())));
                    }
                    else if (message.Text.Equals("REFUSED"))
                    {
                        _logger.Log(Logger.LogLevel.Info, "해당하는 정보가 없습니다.");
                    }
                    else
                    {
                        if (message.Destination.Equals("ID_FORM"))
                        {
                            Invoke((MethodInvoker)((() => ProcessSearchIdResponse(message.Text))));
                            break;
                        }

                        if (message.Destination.Equals("PASSWORD_FORM"))
                        {
                            Invoke((MethodInvoker)((() => ProcessSearchPasswordRespnose())));
                            break;
                        }
                    }
                    break;
                case "UNREGIST_RESPONSE":
                    if (message.Text.Equals("CONNECTED"))
                    {
                        Invoke((MethodInvoker)((() => ProcessUnRegisterResponse())));
                    }
                    else if (message.Text.Equals("COMPLETED"))
                    {
                        _logger.Log(Logger.LogLevel.Info, "삭제가 완료 되었습니다.");
                    }
                    else
                    {
                        _logger.Log(Logger.LogLevel.Info, "계정 정보가 잘못 되었습니다.");
                    }
                    break;
                case "RENEW_RESPONSE":
                    if (message.Text.Equals("COMPLETED"))
                    {
                        _logger.Log(Logger.LogLevel.Info, "비밀 번호 변경이 완료 되었습니다.");
                    }
                    else
                    {
                        _logger.Log(Logger.LogLevel.Info, "비밀 번호 변경에 실패 했습니다.");
                    }
                    break;
                default:
                    break;
            }
        }

        private void ProcessDisConnectResponse()
        {
            if (_userIdInfoForm != null)
            {
                _userIdInfoForm.Dispose();
                _userIdInfoForm = null;
                ProcessDisConnectResponse();
            }

            if (_userPasswordSettingForm != null)
            {
                _userPasswordSettingForm.Dispose();
                _userPasswordSettingForm = null;
                ProcessDisConnectResponse();
            }

            if (_mainRobbyform != null)
            {
                _mainRobbyform.Dispose();
                _mainRobbyform = null;
            }
            else if (_userInfoRegisterform != null)
            {
                _userInfoRegisterform.Dispose();
                _userInfoRegisterform = null;
            }
            else if (_userInfoForm != null)
            {
                _userInfoForm.Dispose();
                _userInfoForm = null;
            }
            else if (_userInfounregisterform != null)
            {
                _userInfounregisterform.Dispose();
                _userInfounregisterform = null;
            }
            else if (_gameform != null)
            {
                _gameform.Dispose();
                _gameform = null;
            }

            this.Show();
        }

        private void ProcessLoginResponse()
        {
            this.Hide();
            if (_mainRobbyform == null)
            {
                _mainRobbyform = new MainRobbyForm();
            }
            _mainRobbyform.Show();
        }

        private void ProcessRegistResponse()
        {
            this.Hide();
            if (_userInfoRegisterform == null)
            {
                _userInfoRegisterform = new UserInfoRegisterForm();
            }
            _userInfoRegisterform.Show();
        }

        private void ProcessSearchResponse()
        {
            this.Hide();
            if (_userInfoForm == null)
            {
                _userInfoForm = new UserInfoForm();
            }
            _userInfoForm.Show();
        }

        private void ProcessSearchIdResponse(string text)
        {
            _userInfoForm.Hide();

            if (_userIdInfoForm == null)
            {
                _userIdInfoForm = new UserIdInfoForm();
            }

            _userIdInfoForm.ShowUserId(text);
            _userIdInfoForm.Show();
        }

        private void ProcessEnteranceResponse(string text)
        {
            _mainRobbyform.Dispose();
            _mainRobbyform = null;
            GameRoom gameRoom = _client.GetGameRoomRepository().ConvertJsonToGameRoom(text);
            _client.GetGameRoomRepository().RenewGameRoom(gameRoom);

            if (_gameform == null)
            {
                _gameform = new GameForm();
                _gameform.FormClosed += GameForm_FormClosed;
            }

            _gameform.SetCurrentGameRoom(gameRoom);
            _gameform.Show();
        }

        private void ProcessGameRoomRenewResponse(string text)
        {
            GameRoom gameRoom = _client.GetGameRoomRepository().ConvertJsonToGameRoom(text);
            _client.GetGameRoomRepository().RenewGameRoom(gameRoom);
            // GameForm 이 활성화 된 상태일 때 예외 처리 

            if (_mainRobbyform != null)
            {
                _mainRobbyform.RenewMainRobby();
            }

            if (_gameform != null)
            {
                _gameform.SetCurrentGameRoom(gameRoom);
            }
        }

        private void ProcesssGameRoomExitResponse(string text)
        {
            _gameform.Dispose();
            _gameform = null;
            GameRoom gameRoom = _client.GetGameRoomRepository().ConvertJsonToGameRoom(text);
            _client.GetGameRoomRepository().RenewGameRoom(gameRoom);
            if (_mainRobbyform == null)
            {
                _mainRobbyform = new MainRobbyForm();
            }
            _mainRobbyform.Show();
        }

        private void ProcessAllChatResponse(string text)
        {
            _mainRobbyform.ShowMainRobbyChatLog(text);
        }

        private void ProcessChatResponse(string text)
        {
            _gameform.ShowGameRoomChatLog(text);
        }

        private void ProcessSearchPasswordRespnose()
        {
            _userInfoForm.Hide();
            if (_userPasswordSettingForm == null)
            {
                _userPasswordSettingForm = new UserPasswordSettingForm();
            }

            _userPasswordSettingForm.Show();
        }

        private void ProcessUnRegisterResponse()
        {
            this.Hide();
            if (_userInfounregisterform == null)
            {
                _userInfounregisterform = new UserInfoUnregisterForm();
            }
            _userInfounregisterform.Show();
        }

        private void GameForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "GAME_ROOM",
                RequestType = "EXIT_GAME_ROOM",
                Name = _client.GetClientName(),
                Text = "ALL"
            });

            _gameform.Dispose();
            _mainRobbyform = new MainRobbyForm();
            _mainRobbyform.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tBoxUserId.PlaceholderText = "계정을 입력 해주세요.";
            tBoxUserPassword.PlaceholderText = "비밀번호를 입력 해주세요.";
            lblGuide.Text = "ID를 입력해주세요";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFindUserInfomation_Click(object sender, EventArgs e)
        {
            _client.ConnectToServer();
            _client.SendToServer(() => new Message
            {
                Name = "DEFAULT",
                Destination = "DATABASE",
                RequestType = "SEARCH"
            });

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _client.ConnectToServer();
            _client.SendToServer(() => new Message
            {
                Name = "DEFAULT",
                Destination = "DATABASE",
                RequestType = "REGIST"
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _client.ConnectToServer();
            _client.SendToServer(() => new Message
            {
                Name = tBoxUserId.Text,
                RequestType = "LOGIN",
                Destination = "DATABASE",
                Text = _client.GetUserRepository().ConvertUserToJson(new Forms_Model.User
                {
                    ID = tBoxUserId.Text,
                    Password = tBoxUserPassword.Text
                })
            });
        }
        private void btn_unregister_Click(object sender, EventArgs e)
        {
            _client.ConnectToServer();
            _client.SendToServer(() => new Message
            {
                Name = "DEFAULT",
                Destination = "DATABASE",
                RequestType = "UNREGIST"
            });
        }
        private void tBoxUserId_TextChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)((() => CheckTextBoxForLogin())));
        }

        private void tBoxUserPassword_TextChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)((() => CheckTextBoxForLogin())));
        }

        private void CheckTextBoxForLogin()
        {
            if (string.IsNullOrWhiteSpace(tBoxUserId.Text))
            {
                lblGuide.Text = "ID를 입력해주세요.";
                btnLogin.Enabled = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(tBoxUserPassword.Text))
            {
                lblGuide.Text = "Password를 입력해주세요.";
                btnLogin.Enabled = false;
                return;
            }

            lblGuide.Text = "로그인 시도가 가능합니다.";
            btnLogin.Enabled = true;
        }
    }

    public class ClientSocketHandler : SocketHandler
    {
        public override void Parse(string jsonString)
        {
            Message message = ConvertToMessage(jsonString);

            if (message.RequestType.Equals("CONNECT"))
            {
                Send(CreateTheData(message));
                return;
            }

            if (message.RequestType.Equals("LOGIN_RESPONSE"))
            {
                this.Name = message.Name;
                EnqueueMessage(message);
                return;
            }

            if (message.RequestType.Equals("SEARCH_RESPONSE"))
            {
                this.Name = message.Name;
                EnqueueMessage(message);
                return;
            }

            if (message.RequestType.Equals("REGIST_RESPONSE"))
            {
                this.Name = message.Name;
                EnqueueMessage(message);
                return;
            }

            if (message.RequestType.Equals("UNREGIST_RESPONSE"))
            {
                this.Name = message.Name;
                EnqueueMessage(message);
                return;
            }

            EnqueueMessage(message);
        }
    }

    public class Client : Observer
    {
        private static Client? _instance;
        public event Action<Message> MessageReceived;
        private GameRoomRepository _gameRoomRepository;
        private UserRepository _userRepository;
        private ClientSocketHandler _clientSocketHandler;
        private Queue<Message> _messages;
        private Socket _socket;
        private IPEndPoint _endPoint;
        private int _port;
        private Logger _logger;
        private object _messagesLock;

        public static Client Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Client();
                }
                return _instance;
            }
        }

        private Client()
        {
            _logger = Logger.Instance;
            _clientSocketHandler = new ClientSocketHandler();
            _gameRoomRepository = new GameRoomRepository();
            _userRepository = new UserRepository(); 
            _messages = new Queue<Message>();
            _port = 8080;
            _messagesLock = new object();
        }

        public void update()
        {
            Message message = _clientSocketHandler.DequeueFromMessages();
       
            if (message != null)
            {
                MessageReceived?.Invoke(message);
            }
        }

        public void ConnectToServer()
        {
            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), _port);

                _clientSocketHandler = new ClientSocketHandler();
                _clientSocketHandler.SetLogger(_logger);
                _clientSocketHandler.Socket = _socket;
                _logger.Log(Logger.LogLevel.Info, "서버에 연결 요청 시작합니다.");
                _clientSocketHandler.Socket.Connect(_endPoint);
                _logger.Log(Logger.LogLevel.Info, "서버와 연결이 완료 되었습니다.");
                _clientSocketHandler.OpenStream();
                _clientSocketHandler.SetMessageQueue(_messages);
                _clientSocketHandler.SetLockObject(_messagesLock);
                _clientSocketHandler.SetKeepAlive();
                _clientSocketHandler.StartToReceive();
                _clientSocketHandler.SetObserver(Instance);
            }
            catch (IOException e)
            {
                _logger.Log(Logger.LogLevel.Error, e.ToString());
            }
        }

        

        public void SetGameRoomRepository(string jsonString)
        {
            _gameRoomRepository.ConvertToRoomList(jsonString);
        }

        public GameRoomRepository GetGameRoomRepository() 
        { 
            return _gameRoomRepository; 
        }

        public void DisConnectToServer()
        {
            _clientSocketHandler.Disconnect();
        }

        public void SendToServer(Func<Message> delegateMessage)
        {
            Message message = delegateMessage();
            string data = _clientSocketHandler.CreateTheData(message);
            _clientSocketHandler.Send(data);
        }

        public string GetClientName()
        {
            return _clientSocketHandler.Name;
        }

        public UserRepository GetUserRepository()
        {
            return this._userRepository;
        }
    }
}
