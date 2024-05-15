

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
            _logger.Log(Logger.LogLevel.Info, message.RequestType);
            switch (message.RequestType)
            {
                case "DISCONNECT_RESPONSE":
                    Invoke((MethodInvoker)(() => ProcessDisConnectResponse()));
                    break;
                case "LOGIN_RESPONSE":
                    if (message.Text.Equals("ACCEPT_NORMAL_USER"))
                    {
                        _logger.Log(Logger.LogLevel.Info, "로그인 되었습니다.");
                        Invoke((MethodInvoker)(() => ProcessLoginResponse()));
                    }
                    else
                    {
                        _logger.Log(Logger.LogLevel.Info, "해당하는 회원이 없습니다.");
                        _client.DisConnectToServer();
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
                _logger.Log(Logger.LogLevel.Info, "UserIdInfoForm 비활성화");
                _userIdInfoForm.Dispose();
                _userIdInfoForm = null;
                ProcessDisConnectResponse();
            }

            if (_userPasswordSettingForm != null)
            {
                _logger.Log(Logger.LogLevel.Info, "UserPasswordSettingForm 비활성화");
                _userPasswordSettingForm.Dispose();
                _userPasswordSettingForm = null;
                ProcessDisConnectResponse();
            }

            if (_mainRobbyform != null)
            {
                _logger.Log(Logger.LogLevel.Info, "MainRobbyForm 비활성화");
                _mainRobbyform.Dispose();
                _mainRobbyform = null;
            }
            else if (_userInfoRegisterform != null)
            {
                _logger.Log(Logger.LogLevel.Info, "RegisterForm 비활성화");
                _userInfoRegisterform.Dispose();
                _userInfoRegisterform = null;
            }
            else if (_userInfoForm != null)
            {
                _logger.Log(Logger.LogLevel.Info, "UserInfoForm 비활성화");
                _userInfoForm.Dispose();
                _userInfoForm = null;
            }
            else if (_userInfounregisterform != null)
            {
                _logger.Log(Logger.LogLevel.Info, "UserInfoUnregisterForm 비활성화");
                _userInfounregisterform.Dispose();
                _userInfounregisterform = null;
            }

            this.Show();
        }

        private void ProcessLoginResponse()
        {
            this.Hide();
            if (_mainRobbyform == null)
            {
                _mainRobbyform = new MainRobbyForm();
                _mainRobbyform.FormClosed += MainRobbyForm_FormClosed;
            }
            _mainRobbyform.Show();
        }

        private void ProcessRegistResponse()
        {
            this.Hide();
            if (_userInfoRegisterform == null)
            {
                _userInfoRegisterform = new UserInfoRegisterForm();
                _userInfoRegisterform.FormClosed += UserInfoRegisterForm_FormClosed;
            }
            _userInfoRegisterform.Show();
        }

        private void ProcessSearchResponse()
        {
            this.Hide();
            if (_userInfoForm == null)
            {
                _userInfoForm = new UserInfoForm();
                _userInfoForm.FormClosed += UserInfoForm_FormClosed;
            }
            _userInfoForm.Show();
        }

        private void ProcessSearchIdResponse(string userId)
        {
            _userInfoForm.Hide();

            if (_userIdInfoForm == null)
            {
                _userIdInfoForm = new UserIdInfoForm();
                _userIdInfoForm.FormClosed += UserIdInfoForm_FormClosed;
            }

            _userIdInfoForm.ShowUserId(userId);
            _userIdInfoForm.Show();
        }

        private void ProcessSearchPasswordRespnose()
        {
            _userInfoForm.Hide();

            if (_userPasswordSettingForm == null)
            {
                _userPasswordSettingForm = new UserPasswordSettingForm();
                _userPasswordSettingForm.FormClosed += UserPasswordSettingForm_FormClosed;
            }

            _userPasswordSettingForm.Show();
        }

        private void ProcessUnRegisterResponse()
        {
            this.Hide();
            if (_userInfounregisterform == null)
            {
                _userInfounregisterform = new UserInfoUnregisterForm();
                _userInfounregisterform.FormClosed += UserInfoUnregisterForm_FormClosed;
            }
            _userInfounregisterform.Show();
        }

        private void MainRobbyForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _mainRobbyform.Dispose();
            _mainRobbyform = null;
            this.Show();
        }

        private void UserInfoRegisterForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _userInfoRegisterform.Dispose();
            _userInfoRegisterform = null;
            this.Show();
        }

        private void UserInfoForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _userInfoForm.Dispose();
            _userInfoForm = null;
            this.Show();
        }

        private void UserInfoUnregisterForm_FormClosed(Object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _userInfounregisterform.Dispose();
            _userInfounregisterform = null;
            this.Show();
        }

        private void UserIdInfoForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _userIdInfoForm.Dispose();
            _userIdInfoForm = null;
            this.Show();
        }

        private void UserPasswordSettingForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _userPasswordSettingForm.Dispose();
            _userPasswordSettingForm = null;
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tBoxUserId.PlaceholderText = "계정을 입력 해주세요.";
            tBoxUserPassword.PlaceholderText = "비밀번호를 입력 해주세요.";
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
                RequestType = "SEARCH"
            });

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            _client.ConnectToServer();
            _client.SendToServer(() => new Message
            {
                Name = "DEFAULT",
                RequestType = "REGIST"
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _client.ConnectToServer();
            _client.SendToServer(() => new Message
            {
                RequestType = "LOGIN",
                Name = tBoxUserId.Text,
                Text = tBoxUserPassword.Text
            });
        }

        private void btn_unregister_Click(object sender, EventArgs e)
        {
            _client.ConnectToServer();
            _client.SendToServer(() => new Message
            {
                Name = "DEFAULT",
                RequestType = "UNREGIST"
            });
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

            if (message.RequestType.Equals("ROGIN_RESPONSE"))
            {
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
    }
}
