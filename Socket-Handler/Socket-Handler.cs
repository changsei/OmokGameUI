using System.Net.Sockets;
using System.Text;
using Model;
using Newtonsoft.Json;
using Message = Model.Message;

namespace Socket_Handler
{
    public interface Observer
    {
        public void update();
    }

    public abstract class SocketHandler
    {
        private int _connectionTimeOut = 2000;
        private object? _lockObject;
        private Thread? _thread;
        private Queue<Message>? _messageQueue;
        protected Logger? _logger;
        private Observer? observer;

        public void SetObserver(Observer observer)
        {
            this.observer = observer;
        }
        public Socket? Socket
        {
            get; set;
        }
        public NetworkStream? Stream
        {
            get; set;
        }
        public string? Name
        {
            get; set;
        }
        public int Port
        {
            get; set;
        }

        public void SetLockObject(object lockObject)
        {
            this._lockObject = lockObject;
        }
        public void SetMessageQueue(Queue<Message> messageQueue)
        {
            this._messageQueue = messageQueue;
        }
        public void SetLogger(Logger logger)
        {
            this._logger = logger;
        }

        // 하위 클래스에서 구현 
        public abstract void Parse(string jsonString);

        public void NotifyObserver()
        {
            observer.update();
        }

        public void CloseSocket()
        {
            Socket.Close();
        }

        public void OpenStream()
        {
            Stream = new NetworkStream(Socket);
        }

        public void CloseStream()
        {
            Stream.Close();
        }

        public void SetKeepAlive()
        {
            Socket.ReceiveTimeout = _connectionTimeOut;
            Socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
        }

        public void Disconnect()
        {
            try
            {
                CloseStream();
                CloseSocket();
                _logger.Log(Logger.LogLevel.Info, "[소켓 종료]");
            }
            catch (Exception e)
            {
                _logger.Log(Logger.LogLevel.Error, e.ToString());
            }
        }

        public string CreateTheData(Message message)
        {
            string data = "STARTJSON" + ConvertToJsonString(message) + "ENDJSON";
            return data;
        }

        public void Send(string data)
        {
            try
            {
                byte[] bytesSend = Encoding.UTF8.GetBytes(data);
                // 비동기 방식 테스트
                /*                Stream.Write(bytesSend, 0, bytesSend.Length);*/
                Stream.BeginWrite(bytesSend, 0, bytesSend.Length, new AsyncCallback(SendCallback), Stream);
            }
            catch (IOException e)
            {
                _logger.Log(Logger.LogLevel.Error, "[데이터 전송 실패]");
                Disconnect();
            }
        }

        private void SendCallback(IAsyncResult asyncResult)
        {
            try
            {
                Stream.EndWrite(asyncResult);
            }
            catch (Exception e)
            {
                _logger.Log(Logger.LogLevel.Error, "[콜백 함수 처리 불가]");
            }
        }

        private void Receive()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                StringBuilder receivedData = new StringBuilder();
                string jsonString = string.Empty;

                while ((bytesRead = Stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    receivedData.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                    string[] data = receivedData.ToString().Split(new string[] { "STARTJSON" }, StringSplitOptions.None);

                    for (int i = 0; i < data.Length; i++)
                    {
                        jsonString = data[i];
                        if (jsonString.EndsWith("ENDJSON"))
                        {
                            Parse(jsonString.Substring(0, data[i].Length - "ENDJSON".Length));
                        }
                    }

                    receivedData.Clear();
                    // 마지막 세그먼트가 완전하지 않을 경우 처리
                    if (!jsonString.EndsWith("ENDJSON"))
                    {
                        receivedData.Append(jsonString);
                    }
                }
            }
            catch (Exception e)
            {
                _logger.Log(Logger.LogLevel.Error, "[데이터 수신 실패]");
                Disconnect();

                EnqueueMessage(new Message()
                {
                    RequestType = "DISCONNECT_RESPONSE",
                    Name = this.Name
                });
            }
        }

        public void StartToReceive()
        {
            _thread = new Thread(new ThreadStart(Receive));
            _thread.Start();
        }

        public void EnqueueMessage(Message message)
        {
            lock (_lockObject)
            {
                _messageQueue.Enqueue(message);
                NotifyObserver();
            }
        }

        public Message DequeueFromMessages()
        {
            lock (_lockObject)
            {
                // 예정: 세마포어를 사용해서 예외를 미연에 방지, 로직 수정 필요
                if (_messageQueue.Count > 0)
                {
                    return _messageQueue.Dequeue();
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
        }

        public string ConvertToJsonString(Message message)
        {
            return JsonConvert.SerializeObject(message);
        }
        public Message ConvertToMessage(string jsonString)
        {
            return JsonConvert.DeserializeObject<Message>(jsonString);
        }
    }
}
