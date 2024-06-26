﻿using System;
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
    public partial class UserInfoForm : Form
    {
        Client _client;
        LoginForm _loginForm;
        public UserInfoForm()
        {
            _loginForm = LoginForm.Instance;
            _client = Client.Instance;
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            tBoxUserPhoneNumber.PlaceholderText = "전화번호를 입력 해주세요.";
            tBoxUserId.PlaceholderText = "계정을 입력 해주세요.";
        }
        private void UserInfoForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _loginForm.Show();
            this.Dispose();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            _client.DisConnectToServer();
        }

        private void btnSeachUserPassword_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "DATABASE",
                RequestType = "SEARCH_USER_PW",
                Name = _client.GetClientName(),
                Text = tBoxUserId.Text
            });

            _client.GetUserRepository().AddUserBuffer(tBoxUserId.Text);
        }

        private void btnSearchUserId_Click(object sender, EventArgs e)
        {
            _client.SendToServer(() => new Message
            {
                Destination = "DATABASE",
                RequestType = "SEARCH_USER_ID",
                Name = _client.GetClientName(),
                Text = tBoxUserPhoneNumber.Text
            });
        }

        private void tBoxUserId_TextChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)((() => UpdateButtonStatesAndGuide())));
        }

        private void tBoxUserPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)((() => UpdateButtonStatesAndGuide())));
        }

        private void UpdateButtonStatesAndGuide()
        {
            bool isUserIdFilled = !string.IsNullOrWhiteSpace(tBoxUserId.Text);
            bool isUserPhoneFilled = !string.IsNullOrWhiteSpace(tBoxUserPhoneNumber.Text);

            btnSeachUserPassword.Enabled = isUserIdFilled;  
            btnSearchUserId.Enabled = isUserPhoneFilled;   

            if (isUserIdFilled && isUserPhoneFilled)
            {
                lblGuide.Text = "원하시는 버튼을 클릭해주세요.";
                return;
            }

            if (isUserIdFilled)
            {
                lblGuide.Text = "비밀번호 갱신 시도가 가능합니다.";
                return;
            }
            
            if (isUserPhoneFilled)
            {
                lblGuide.Text = "계정정보 조회 시도가 가능합니다.";
                return;
            }
            else
            {
                lblGuide.Text = "계정 또는 전화번호 정보가 필요합니다.";
            }
        }
    }
}
