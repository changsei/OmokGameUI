using Model;
using Newtonsoft.Json;
using User = Model.User;

namespace Repository
{
    public class UserRepository
    {
        private List<User> _users;
        private string _userBuffer;
        private readonly object _userBufferLock;
        private readonly object _lock;

        public UserRepository()
        {
            try
            {
                _users = new List<User>();
                _lock = new object();
                _userBufferLock = new object();
            }
            catch (Exception e) { }
        }

        public void RemoveUser(string userID)
        {
            lock (_lock)
            {
                User userToRemove = GetUser(userID);

                if (userToRemove != null)
                {
                    _users.Remove(userToRemove);
                    Logger.Instance.Log(Logger.LogLevel.Error, $"[접속 목록 제거]: {userID}");
                }
                else
                {
                    Logger.Instance.Log(Logger.LogLevel.Error, "[접속 목록 제거]: 게스트");
                }
            }
        }

        public void AddUserBuffer(string userID)
        {
            lock (_userBufferLock)
            {
                _userBuffer = userID;
            }
        }

        public void RemoveUserBuffer(string userID)
        {
            lock (_userBufferLock)
            {
                _userBuffer = "NULL";
            }
        }

        public string GetUserBuffer()
        {
            lock (_userBufferLock)
            {
                return _userBuffer;
            }
        }

        public void AddUser(User user)
        {
            lock (_lock)
            {
                _users.Add(user);
            }
        }

        public User GetUser(string userID)
        {
            foreach (User user in _users)
            {
                if (!user.ID.Equals(user.Name)) continue;
                return user;
            }

            return null;
        }

        public string ConvertUserListToJsonString()
        {
            return JsonConvert.SerializeObject(_users);
        }

        public List<User> ConvertToUserList(string jsonString)
        {
            return JsonConvert.DeserializeObject<List<User>>(jsonString);
        }
        public string ConvertUserToJson(User user)
        {
            return JsonConvert.SerializeObject(user);
        }

        public User ConvertJsonToUser(string jsonString)
        {
            return JsonConvert.DeserializeObject<User>(jsonString);
        }
    }

    public class GameRoomRepository
    {
        private List<GameRoom> _rooms;
        private object _lock = new object();
        private readonly int _defaultRoomSize = 3;
        private int _roomCount = 0;

        public GameRoomRepository()
        {
            _rooms = new List<GameRoom>();

            for (int i = 0; i < _defaultRoomSize; i++)
            {
                AddRoom(new GameRoom
                {
                    Name = "ROOM" + ++_roomCount,
                    MainUser = "NULL",
                    SubUser = "NULL",
                    State = true
                });
            }
        }

        public void AddRoom(GameRoom room)
        {
            lock (_lock)
            {
                _rooms.Add(room);
            }
        }

        public List<GameRoom> GetRooms()
        {
            return _rooms;
        }

        public GameRoom GetRoom(string roomName)
        {
            foreach (GameRoom room in _rooms)
            {
                if (room.Name.Equals(roomName)) return room;
            }
            return null;
        }

        public void RenewGameRoom(GameRoom gameRoom)
        {
            lock (_lock)
            {
                GameRoom roomToRenew = GetRoom(gameRoom.Name);
                roomToRenew.MainUser = gameRoom.MainUser;
                roomToRenew.SubUser = gameRoom.SubUser;

                // 레디 상태 갱신 
                roomToRenew.MainUserReady = gameRoom.MainUserReady && roomToRenew.MainUser != "NULL";
                roomToRenew.SubUserReady = gameRoom.SubUserReady && roomToRenew.SubUser != "NULL";

                // 방 입장 상태 갱신
                roomToRenew.State = roomToRenew.SubUser == "NULL";

                // 유저가 떠날 경우 레디 상태 초기화 
                if (gameRoom.MainUser.Equals("NULL") || gameRoom.SubUser.Equals("NULL"))
                {
                    roomToRenew.MainUserReady = false;
                    roomToRenew.SubUserReady = false;
                }
            }
        }
        public string ConvertGameRoomListToJsonString()
        {
            return JsonConvert.SerializeObject(_rooms);
        }

        public void ConvertToRoomList(string jsonString)
        {
            _rooms = JsonConvert.DeserializeObject<List<GameRoom>>(jsonString);
        }
        public string ConvertGameRoomToJson(GameRoom gameRoom)
        {
            return JsonConvert.SerializeObject(gameRoom);
        }

        public GameRoom ConvertJsonToGameRoom(string jsonString)
        {
            return JsonConvert.DeserializeObject<GameRoom>(jsonString);
        }

        public string ConvertGameMoveToJson(GameMove gameMove)
        {
            return JsonConvert.SerializeObject(gameMove);
        }

        public GameMove ConvertJsonToGameMove(string jsonString)
        {
            return JsonConvert.DeserializeObject<GameMove>(jsonString);
        }
    }
}
