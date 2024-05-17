﻿using System;
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
                RequestType = "RENEW_USER_PASSOWRD",
                Name = _client.GetClientName(),
                Text = tboxConfirmUserPassword.Text
            });
        }
    }
}
