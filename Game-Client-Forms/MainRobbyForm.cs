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
    public partial class MainRobbyForm : Form
    {
        private Client _client;
        public MainRobbyForm()
        {
            _client = Client.Instance;
            InitializeComponent();
        }

        private void MainRobbyForm_Load(object sender, EventArgs e)
        {
            // 사용자 정보 요청
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            _client.DisConnectToServer();
        }
    }
}
