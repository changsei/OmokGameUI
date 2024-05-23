using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Socket_Handler;
using Message = Model.Message;

namespace Game_Client_Forms
{
    public partial class UserPasswordSettingForm : Form
    {
        Client _client;
        LoginForm _loginForm;

        public UserPasswordSettingForm()
        {
            _loginForm = LoginForm.Instance;
            _client = Client.Instance;
            InitializeComponent();
        }

        private void UserPasswordSettingForm_Load(object sender, EventArgs e)
        {
            tBoxUserPassword.PlaceholderText = "비밀번호가 필요 합니다.";
            tboxConfirmUserPassword.PlaceholderText = "비밀번호 확인이 필요합니다.";
        }

        private void UserPasswordSettingForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _loginForm.Show();
            this.Dispose();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            _client.DisConnectToServer();
        }

        private void btnRegisterPassword_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "DATABASE",
                RequestType = "RENEW_USER_PASSWORD",
                Name = _client.GetClientName(),
                Text = _client.GetUserRepository().ConvertUserToJson(new Model.User
                {
                    ID = _client.GetUserRepository().GetUserBuffer(),
                    Password = tboxConfirmUserPassword.Text
                })
            });
        }

        private void chkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPassword.Checked == true)
            {
                tBoxUserPassword.PasswordChar = default(char);
                tboxConfirmUserPassword.PasswordChar = default(char);
            }
            else
            {
                tBoxUserPassword.PasswordChar = '*';
                tboxConfirmUserPassword.PasswordChar = '*';
            }
        }
        private void UserPasswordSettingsForm_TextChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)((() => UpdateRenewUserPasswordButtonStateAndGuide())));
        }

        private void UpdateRenewUserPasswordButtonStateAndGuide()
        {
            bool isUserPasswordFilled = !string.IsNullOrWhiteSpace(tBoxUserPassword.Text);
            bool isUserConfirmUserPasswordFilled = !string.IsNullOrWhiteSpace(tboxConfirmUserPassword.Text);
            bool isPasswordMatch = tBoxUserPassword.Text == tboxConfirmUserPassword.Text;

            if (isUserPasswordFilled && isUserConfirmUserPasswordFilled && isPasswordMatch)
            {
                btnRegisterPassword.Enabled = true;
                lblGuide.Text = "비밀번호 갱신 시도가 가능합니다.";
            }
            else
            {
                btnRegisterPassword.Enabled = false;
                if (!isUserPasswordFilled)
                {
                    lblGuide.Text = "비밀번호 입력이 필요합니다.";
                    return;
                }

                if (!isUserConfirmUserPasswordFilled)
                {
                    lblGuide.Text = "비밀번호 재확인이 필요합니다.";
                    return;
                }

                if (!isPasswordMatch)
                {
                    lblGuide.Text = "비밀번호가 일치하지 않습니다.";
                }
            }
        }
    }
}
