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
        LoginForm _loginForm;
        public UserInfoUnregisterForm()
        {
            _loginForm = LoginForm.Instance;
            _client = Client.Instance;
            InitializeComponent();
        }

        private void UserInfoUnregisterForm_Load(object sender, EventArgs e)
        {
            tBoxUserId.PlaceholderText = "삭제 하려는 계정을 입력 해주세요.";
            tBoxUserPassword.PlaceholderText = "비밀 번호 입력이 필요 합니다.";
        }

        private void UserInfoUnregisterForm_FormClosed(Object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _loginForm.Show();
            this.Dispose();
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
                Text = _client.GetUserRepository().ConvertUserToJson(new User
                {
                    ID = tBoxUserId.Text,
                    Password = tBoxUserPassword.Text
                })
            });
        }

        private void chkBoxShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPassword.Checked == true)
            {
                tBoxUserPassword.PasswordChar = default(char);
            }
            else
            {
                tBoxUserPassword.PasswordChar = '*';
            }
        }

        private void UserInfoUnRegistForm_TextChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)((() => UpdateUnregistUserPasswordButtonStateAndGuide())));
        }

        private void UpdateUnregistUserPasswordButtonStateAndGuide()
        {
            bool isUserIdFilled = !string.IsNullOrWhiteSpace(tBoxUserId.Text);
            bool isUserPasswordFilled = !string.IsNullOrWhiteSpace(tBoxUserPassword.Text);

            if (isUserPasswordFilled && isUserPasswordFilled)
            {
                btnUnregister.Enabled = true;
                lblGuide.Text = "계정 탈퇴 시도가 가능합니다.";
            }
            else
            {
                btnUnregister.Enabled = false;
                if (!isUserIdFilled)
                {
                    lblGuide.Text = "계정 입력이 필요합니다.";
                    return;
                }

                if (!isUserPasswordFilled)
                {
                    lblGuide.Text = "비밀번호 입력이 필요합니다.";
                    return;
                }
            }
        }
    }
}
