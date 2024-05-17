using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Client_Forms
{
    public partial class UserIdInfoForm : Form
    {
        private Client _client;
        private LoginForm _loginForm;
        public UserIdInfoForm()
        {
            _loginForm = LoginForm.Instance;
            _client = Client.Instance;
            InitializeComponent();
        }
        private void UserIdInfoForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _client.DisConnectToServer();
            _loginForm.Show();
            this.Dispose();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            _client.DisConnectToServer();
        }

        public void ShowUserId(string userId)
        {
            lblUserIdInfo.Text = userId;
            Application.DoEvents();
        }
    }
}
