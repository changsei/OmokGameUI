using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms_Model;
using Message = Forms_Model.Message;

namespace Game_Client_Forms
{
    public partial class UserInfoRegisterForm : Form
    {
        private Form _loginForm;
        private Client _client;
        public UserInfoRegisterForm()
        {
            _loginForm = LoginForm.Instance;
            _client = Client.Instance;
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            tBoxUserId.PlaceholderText = "계정을 입력 해주세요.";
            tBoxUserName.PlaceholderText = "이름을 입력 해주세요.";
            tBoxUserPassword.PlaceholderText = "비밀번호를 입력 해주세요.";
            tBoxConfirmUserPassword.PlaceholderText = "비밀번호 확인이 필요합니다.";
            tBoxUserPhoneNumber.PlaceholderText = "전화번호가 필요합니다.";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "DATABASE",
                RequestType = "REGIST_USER_ID/PW",
                Name = _client.GetClientName(),
                Text = tBoxUserId.Text + "," + tBoxUserName.Text + "," + tBoxConfirmUserPassword.Text + "," + tBoxUserPhoneNumber.Text
            });
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            _client.DisConnectToServer();
        }
    }
}
