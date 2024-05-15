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
    public partial class UserInfoUnregisterForm : Form
    {
        Client _client;
        public UserInfoUnregisterForm()
        {
            _client = Client.Instance;
            InitializeComponent();
        }

        private void UserInfoUnregisterForm_Load(object sender, EventArgs e)
        {
            tBoxUserId.PlaceholderText = "삭제 하려는 계정을 입력 해주세요.";
            tBoxUserPassword.PlaceholderText = "비밀 번호 입력이 필요 합니다.";
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            _client.DisConnectToServer();
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "DATABASE",
                RequestType = "UNREGIST_USER_ID/PW",
                Name = _client.GetClientName(),
                Text = tBoxUserId.Text + "," + tBoxUserPassword.Text
            });
        }
    }
}
