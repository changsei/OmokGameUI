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
    public partial class UserInfoForm : Form
    {
        Client _client;
        public UserInfoForm()
        {
            _client = Client.Instance;
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            tBoxUserPhoneNumber.PlaceholderText = "전화번호를 입력 해주세요.";
            tBoxUserPassword.PlaceholderText = "전화번호를 입력 해주세요.";
        }
    }
}
