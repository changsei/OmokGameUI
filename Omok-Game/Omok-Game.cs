namespace Omok_Game
{
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
            }
            catch (Exception e)
            {

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
