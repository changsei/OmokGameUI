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
    public partial class GameForm : Form
    {
        private Client _client;
        private GameRoom _currentRoom;
        public GameForm()
        {
            InitializeComponent();
            _client = Client.Instance;
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Name = _client.GetClientName(),
                Destination = "GAME_ROOM",
                RequestType = "EXIT_GAME_ROOM",
                Text = _client.GetGameRoomRepository().ConvertGameRoomToJson(_currentRoom)
            });
        }

        private void btnInputUserChat_Click(object sender, EventArgs e)
        {

        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {

        }

        private void btnReady_Click(object sender, EventArgs e)
        {

        }

        public GameRoom GetCurrentGameRoom()
        {
            return this._currentRoom;
        }

        public void SetCurrentGameRoom(GameRoom room)
        {
            this._currentRoom = room;
        }
    }
}
