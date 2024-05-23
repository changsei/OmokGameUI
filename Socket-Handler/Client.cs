using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Message = Model.Message;

namespace Socket_Handler
{
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
        private string _ip;
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
            _port = 50000;
            _ip = "223.130.152.245";
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
                _endPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);

                _clientSocketHandler = new ClientSocketHandler();
                _clientSocketHandler.SetLogger(_logger);
                _clientSocketHandler.Socket = _socket;
                _logger.Log(Logger.LogLevel.Info, "[연결 요청]");
                _clientSocketHandler.Socket.Connect(_endPoint);
                _logger.Log(Logger.LogLevel.Info, "[연결 완료]");
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
