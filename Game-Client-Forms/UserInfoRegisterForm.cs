using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Socket_Handler;
using Message = Model.Message;

namespace Game_Client_Forms
{
    public partial class UserInfoRegisterForm : Form
    {
        private Client _client;
        private LoginForm _loginForm;
        public UserInfoRegisterForm()
        {
            _loginForm = LoginForm.Instance;
            _client = Client.Instance;
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            tBoxUserName.Focus();
            tBoxUserName.PlaceholderText = "이름을 입력 해주세요.";
            tBoxUserPhoneNumber.PlaceholderText = "전화번호가 필요합니다.";
            tBoxUserId.PlaceholderText = "계정을 입력 해주세요.";
            tBoxUserPassword.PlaceholderText = "비밀번호를 입력 해주세요.";
            tBoxConfirmUserPassword.PlaceholderText = "비밀번호 확인이 필요합니다.";
        }

        private void UserInfoRegisterForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _loginForm.Show();
            this.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "DATABASE",
                RequestType = "REGIST_USER_ID/PW",
                Name = _client.GetClientName(),
                Text = _client.GetUserRepository().ConvertUserToJson(new User
                {
                    ID = tBoxUserId.Text,
                    Name = tBoxUserName.Text,
                    Password = tBoxConfirmUserPassword.Text,
                    PhoneNumber = tBoxUserPhoneNumber.Text
                })
            });
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            _client.DisConnectToServer();
        }

        private void chkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPassword.Checked == true)
            {
                tBoxUserPassword.PasswordChar = default(char);
                tBoxConfirmUserPassword.PasswordChar= default(char);
            }
            else
            {
                tBoxUserPassword.PasswordChar = '*';
                tBoxConfirmUserPassword.PasswordChar = '*';
            }
        }

        private void RegisterForm_TextChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)((() => UpdateRegisterButtonStateAndGuide())));
        }

        private void UpdateRegisterButtonStateAndGuide()
        {
            bool isUserIdFilled = !string.IsNullOrWhiteSpace(tBoxUserId.Text);
            bool isUserNameFilled = !string.IsNullOrWhiteSpace(tBoxUserName.Text);
            bool isPhoneNumberFilled = !string.IsNullOrWhiteSpace(tBoxUserPhoneNumber.Text);
            bool isPasswordFilled = !string.IsNullOrWhiteSpace(tBoxUserPassword.Text);
            bool isPasswordConfirmFilled = !string.IsNullOrWhiteSpace(tBoxConfirmUserPassword.Text);
            bool isPasswordMatch = tBoxUserPassword.Text == tBoxConfirmUserPassword.Text;

            if (isUserIdFilled && isUserNameFilled && isPhoneNumberFilled && isPasswordFilled && isPasswordConfirmFilled && isPasswordMatch)
            {
                btnRegister.Enabled = true;
                lblGuide.Text = "등록 시도가 가능합니다.";
            }
            else
            {
                btnRegister.Enabled = false;
                if (!isUserNameFilled)
                {
                    lblGuide.Text = "이름을 입력해주세요.";
                    return;
                }

                if (!isPhoneNumberFilled)
                {
                    lblGuide.Text = "전화번호를 입력해주세요.";
                    return;
                }

                if (!isUserIdFilled) { 
                    lblGuide.Text = "아이디를 입력해주세요.";
                    return;
                }

                if (!isPasswordFilled)
                {
                    lblGuide.Text = "비밀번호를 입력해주세요.";
                    return;
                }

                if (!isPasswordConfirmFilled)
                {
                    lblGuide.Text = "비밀번호 확인란을 입력해주세요.";
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
