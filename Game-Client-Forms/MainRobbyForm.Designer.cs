namespace Game_Client_Forms
{
    partial class MainRobbyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            richBoxUserInfo = new RichTextBox();
            chkUserView = new CheckedListBox();
            btnExitClient = new Button();
            btnBackHome = new Button();
            btnSearchUserInfo = new Button();
            panel2 = new Panel();
            btnInputUserChat = new Button();
            tBoxUserChat = new TextBox();
            richBoxAllUserChatLog = new RichTextBox();
            panel3 = new Panel();
            panel6 = new Panel();
            lblRoomUseStatus3 = new Label();
            label9 = new Label();
            lblRoomSubUserName3 = new Label();
            lblRoomMainUserName3 = new Label();
            label12 = new Label();
            label13 = new Label();
            lblRoomNumber3 = new Label();
            btnEnteranceRoom3 = new Button();
            panel5 = new Panel();
            lblRoomUseStatus2 = new Label();
            label2 = new Label();
            lblRoomSubUserName2 = new Label();
            lblRoomMainUserName2 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblRoomNumber2 = new Label();
            btnEnteranceRoom2 = new Button();
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnBackPage = new Button();
            panel4 = new Panel();
            lblRoomUseStatus1 = new Label();
            lblRoomStatus = new Label();
            lblRoomSubUserName1 = new Label();
            lblRoomMainUserName1 = new Label();
            lblSubUser = new Label();
            lblMainUser = new Label();
            lblRoomNumber1 = new Label();
            btnEnteranceRoom1 = new Button();
            lblVersion = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(richBoxUserInfo);
            panel1.Controls.Add(chkUserView);
            panel1.Controls.Add(btnExitClient);
            panel1.Controls.Add(btnBackHome);
            panel1.Controls.Add(btnSearchUserInfo);
            panel1.Location = new Point(762, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 269);
            panel1.TabIndex = 0;
            // 
            // richBoxUserInfo
            // 
            richBoxUserInfo.BackColor = SystemColors.ButtonHighlight;
            richBoxUserInfo.Location = new Point(257, 149);
            richBoxUserInfo.Name = "richBoxUserInfo";
            richBoxUserInfo.ReadOnly = true;
            richBoxUserInfo.Size = new Size(180, 96);
            richBoxUserInfo.TabIndex = 22;
            richBoxUserInfo.Text = "";
            // 
            // chkUserView
            // 
            chkUserView.FormattingEnabled = true;
            chkUserView.Location = new Point(23, 17);
            chkUserView.Name = "chkUserView";
            chkUserView.Size = new Size(219, 228);
            chkUserView.TabIndex = 21;
            // 
            // btnExitClient
            // 
            btnExitClient.Location = new Point(257, 105);
            btnExitClient.Name = "btnExitClient";
            btnExitClient.Size = new Size(180, 38);
            btnExitClient.TabIndex = 20;
            btnExitClient.Text = "클라이언트 종료";
            btnExitClient.UseVisualStyleBackColor = true;
            btnExitClient.Click += btnExitClient_Click;
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(257, 61);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(180, 38);
            btnBackHome.TabIndex = 19;
            btnBackHome.Text = "로그인 화면으로";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // btnSearchUserInfo
            // 
            btnSearchUserInfo.Location = new Point(257, 17);
            btnSearchUserInfo.Name = "btnSearchUserInfo";
            btnSearchUserInfo.Size = new Size(180, 38);
            btnSearchUserInfo.TabIndex = 18;
            btnSearchUserInfo.Text = "유저 정보 조회";
            btnSearchUserInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnInputUserChat);
            panel2.Controls.Add(tBoxUserChat);
            panel2.Controls.Add(richBoxAllUserChatLog);
            panel2.Location = new Point(762, 293);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 331);
            panel2.TabIndex = 1;
            // 
            // btnInputUserChat
            // 
            btnInputUserChat.Location = new Point(369, 254);
            btnInputUserChat.Name = "btnInputUserChat";
            btnInputUserChat.Size = new Size(68, 38);
            btnInputUserChat.TabIndex = 22;
            btnInputUserChat.Text = "입력";
            btnInputUserChat.UseVisualStyleBackColor = true;
            btnInputUserChat.Click += btnInputUserChat_Click;
            // 
            // tBoxUserChat
            // 
            tBoxUserChat.Location = new Point(22, 261);
            tBoxUserChat.Name = "tBoxUserChat";
            tBoxUserChat.Size = new Size(341, 31);
            tBoxUserChat.TabIndex = 1;
            // 
            // richBoxAllUserChatLog
            // 
            richBoxAllUserChatLog.BackColor = SystemColors.ButtonHighlight;
            richBoxAllUserChatLog.Location = new Point(22, 17);
            richBoxAllUserChatLog.Name = "richBoxAllUserChatLog";
            richBoxAllUserChatLog.ReadOnly = true;
            richBoxAllUserChatLog.Size = new Size(415, 231);
            richBoxAllUserChatLog.TabIndex = 0;
            richBoxAllUserChatLog.Text = "";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(lblPageNumber);
            panel3.Controls.Add(btnNextPage);
            panel3.Controls.Add(btnBackPage);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(30, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(722, 612);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblRoomUseStatus3);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(lblRoomSubUserName3);
            panel6.Controls.Add(lblRoomMainUserName3);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(lblRoomNumber3);
            panel6.Controls.Add(btnEnteranceRoom3);
            panel6.Location = new Point(19, 364);
            panel6.Name = "panel6";
            panel6.Size = new Size(675, 135);
            panel6.TabIndex = 9;
            // 
            // lblRoomUseStatus3
            // 
            lblRoomUseStatus3.AutoSize = true;
            lblRoomUseStatus3.Location = new Point(115, 91);
            lblRoomUseStatus3.Name = "lblRoomUseStatus3";
            lblRoomUseStatus3.Size = new Size(72, 25);
            lblRoomUseStatus3.TabIndex = 8;
            lblRoomUseStatus3.Text = "방 상태";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 90);
            label9.Name = "label9";
            label9.Size = new Size(61, 25);
            label9.TabIndex = 7;
            label9.Text = "Status";
            // 
            // lblRoomSubUserName3
            // 
            lblRoomSubUserName3.AutoSize = true;
            lblRoomSubUserName3.Location = new Point(115, 65);
            lblRoomSubUserName3.Name = "lblRoomSubUserName3";
            lblRoomSubUserName3.Size = new Size(102, 25);
            lblRoomSubUserName3.TabIndex = 5;
            lblRoomSubUserName3.Text = "도전자이름";
            // 
            // lblRoomMainUserName3
            // 
            lblRoomMainUserName3.AutoSize = true;
            lblRoomMainUserName3.Location = new Point(115, 39);
            lblRoomMainUserName3.Name = "lblRoomMainUserName3";
            lblRoomMainUserName3.Size = new Size(84, 25);
            lblRoomMainUserName3.TabIndex = 4;
            lblRoomMainUserName3.Text = "방장이름";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 65);
            label12.Name = "label12";
            label12.Size = new Size(86, 25);
            label12.TabIndex = 3;
            label12.Text = "Sub User";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 39);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 2;
            label13.Text = "Main User";
            // 
            // lblRoomNumber3
            // 
            lblRoomNumber3.AutoSize = true;
            lblRoomNumber3.Location = new Point(14, 14);
            lblRoomNumber3.Name = "lblRoomNumber3";
            lblRoomNumber3.Size = new Size(40, 25);
            lblRoomNumber3.TabIndex = 1;
            lblRoomNumber3.Text = "3번";
            // 
            // btnEnteranceRoom3
            // 
            btnEnteranceRoom3.Location = new Point(335, 14);
            btnEnteranceRoom3.Name = "btnEnteranceRoom3";
            btnEnteranceRoom3.Size = new Size(321, 105);
            btnEnteranceRoom3.TabIndex = 0;
            btnEnteranceRoom3.Text = "입장";
            btnEnteranceRoom3.UseVisualStyleBackColor = true;
            btnEnteranceRoom3.Click += btnEnteranceRoom3_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblRoomUseStatus2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(lblRoomSubUserName2);
            panel5.Controls.Add(lblRoomMainUserName2);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(lblRoomNumber2);
            panel5.Controls.Add(btnEnteranceRoom2);
            panel5.Location = new Point(19, 211);
            panel5.Name = "panel5";
            panel5.Size = new Size(675, 135);
            panel5.TabIndex = 9;
            // 
            // lblRoomUseStatus2
            // 
            lblRoomUseStatus2.AutoSize = true;
            lblRoomUseStatus2.Location = new Point(115, 91);
            lblRoomUseStatus2.Name = "lblRoomUseStatus2";
            lblRoomUseStatus2.Size = new Size(72, 25);
            lblRoomUseStatus2.TabIndex = 8;
            lblRoomUseStatus2.Text = "방 상태";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 90);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 7;
            label2.Text = "Status";
            // 
            // lblRoomSubUserName2
            // 
            lblRoomSubUserName2.AutoSize = true;
            lblRoomSubUserName2.Location = new Point(115, 65);
            lblRoomSubUserName2.Name = "lblRoomSubUserName2";
            lblRoomSubUserName2.Size = new Size(102, 25);
            lblRoomSubUserName2.TabIndex = 5;
            lblRoomSubUserName2.Text = "도전자이름";
            // 
            // lblRoomMainUserName2
            // 
            lblRoomMainUserName2.AutoSize = true;
            lblRoomMainUserName2.Location = new Point(115, 39);
            lblRoomMainUserName2.Name = "lblRoomMainUserName2";
            lblRoomMainUserName2.Size = new Size(84, 25);
            lblRoomMainUserName2.TabIndex = 4;
            lblRoomMainUserName2.Text = "방장이름";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 65);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 3;
            label5.Text = "Sub User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 39);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 2;
            label6.Text = "Main User";
            // 
            // lblRoomNumber2
            // 
            lblRoomNumber2.AutoSize = true;
            lblRoomNumber2.Location = new Point(14, 14);
            lblRoomNumber2.Name = "lblRoomNumber2";
            lblRoomNumber2.Size = new Size(40, 25);
            lblRoomNumber2.TabIndex = 1;
            lblRoomNumber2.Text = "2번";
            // 
            // btnEnteranceRoom2
            // 
            btnEnteranceRoom2.Location = new Point(335, 14);
            btnEnteranceRoom2.Name = "btnEnteranceRoom2";
            btnEnteranceRoom2.Size = new Size(321, 105);
            btnEnteranceRoom2.TabIndex = 0;
            btnEnteranceRoom2.Text = "입장";
            btnEnteranceRoom2.UseVisualStyleBackColor = true;
            btnEnteranceRoom2.Click += btnEnteranceRoom2_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("맑은 고딕", 8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblPageNumber.Location = new Point(324, 579);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(67, 21);
            lblPageNumber.TabIndex = 22;
            lblPageNumber.Text = "1페이지";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(358, 538);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(180, 38);
            btnNextPage.TabIndex = 20;
            btnNextPage.Text = "다음";
            btnNextPage.UseVisualStyleBackColor = true;
            // 
            // btnBackPage
            // 
            btnBackPage.Location = new Point(171, 538);
            btnBackPage.Name = "btnBackPage";
            btnBackPage.Size = new Size(180, 38);
            btnBackPage.TabIndex = 19;
            btnBackPage.Text = "이전";
            btnBackPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblRoomUseStatus1);
            panel4.Controls.Add(lblRoomStatus);
            panel4.Controls.Add(lblRoomSubUserName1);
            panel4.Controls.Add(lblRoomMainUserName1);
            panel4.Controls.Add(lblSubUser);
            panel4.Controls.Add(lblMainUser);
            panel4.Controls.Add(lblRoomNumber1);
            panel4.Controls.Add(btnEnteranceRoom1);
            panel4.Location = new Point(19, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(675, 135);
            panel4.TabIndex = 0;
            // 
            // lblRoomUseStatus1
            // 
            lblRoomUseStatus1.AutoSize = true;
            lblRoomUseStatus1.Location = new Point(115, 91);
            lblRoomUseStatus1.Name = "lblRoomUseStatus1";
            lblRoomUseStatus1.Size = new Size(72, 25);
            lblRoomUseStatus1.TabIndex = 8;
            lblRoomUseStatus1.Text = "방 상태";
            // 
            // lblRoomStatus
            // 
            lblRoomStatus.AutoSize = true;
            lblRoomStatus.Location = new Point(14, 90);
            lblRoomStatus.Name = "lblRoomStatus";
            lblRoomStatus.Size = new Size(61, 25);
            lblRoomStatus.TabIndex = 7;
            lblRoomStatus.Text = "Status";
            // 
            // lblRoomSubUserName1
            // 
            lblRoomSubUserName1.AutoSize = true;
            lblRoomSubUserName1.Location = new Point(115, 65);
            lblRoomSubUserName1.Name = "lblRoomSubUserName1";
            lblRoomSubUserName1.Size = new Size(102, 25);
            lblRoomSubUserName1.TabIndex = 5;
            lblRoomSubUserName1.Text = "도전자이름";
            // 
            // lblRoomMainUserName1
            // 
            lblRoomMainUserName1.AutoSize = true;
            lblRoomMainUserName1.Location = new Point(115, 39);
            lblRoomMainUserName1.Name = "lblRoomMainUserName1";
            lblRoomMainUserName1.Size = new Size(84, 25);
            lblRoomMainUserName1.TabIndex = 4;
            lblRoomMainUserName1.Text = "방장이름";
            // 
            // lblSubUser
            // 
            lblSubUser.AutoSize = true;
            lblSubUser.Location = new Point(14, 65);
            lblSubUser.Name = "lblSubUser";
            lblSubUser.Size = new Size(86, 25);
            lblSubUser.TabIndex = 3;
            lblSubUser.Text = "Sub User";
            // 
            // lblMainUser
            // 
            lblMainUser.AutoSize = true;
            lblMainUser.Location = new Point(14, 39);
            lblMainUser.Name = "lblMainUser";
            lblMainUser.Size = new Size(95, 25);
            lblMainUser.TabIndex = 2;
            lblMainUser.Text = "Main User";
            // 
            // lblRoomNumber1
            // 
            lblRoomNumber1.AutoSize = true;
            lblRoomNumber1.Location = new Point(14, 14);
            lblRoomNumber1.Name = "lblRoomNumber1";
            lblRoomNumber1.Size = new Size(40, 25);
            lblRoomNumber1.TabIndex = 1;
            lblRoomNumber1.Text = "1번";
            // 
            // btnEnteranceRoom1
            // 
            btnEnteranceRoom1.Location = new Point(335, 14);
            btnEnteranceRoom1.Name = "btnEnteranceRoom1";
            btnEnteranceRoom1.Size = new Size(321, 105);
            btnEnteranceRoom1.TabIndex = 0;
            btnEnteranceRoom1.Text = "입장";
            btnEnteranceRoom1.UseVisualStyleBackColor = true;
            btnEnteranceRoom1.Click += btnEnteranceRoom_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("맑은 고딕", 8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblVersion.Location = new Point(579, 633);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(109, 21);
            lblVersion.TabIndex = 21;
            lblVersion.Text = "Omok ver.1.0";
            // 
            // MainRobbyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1258, 664);
            Controls.Add(lblVersion);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainRobbyForm";
            Text = "MainRobbyForm";
            FormClosed += MainRobbyForm_FormClosed;
            Load += MainRobbyForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;

        private Label lblVersion;
        private Label lblRoomStatus;

        private Label lblRoomNumber1;
        private Label lblRoomMainUserName1;
        private Label lblRoomSubUserName1;
        private Label lblRoomUseStatus1;

        private Label lblRoomNumber2;
        private Label lblRoomMainUserName2;
        private Label lblRoomSubUserName2;
        private Label lblRoomUseStatus2;

        private Label lblRoomNumber3;
        private Label lblRoomMainUserName3;
        private Label lblRoomSubUserName3;
        private Label lblRoomUseStatus3;

        private Label lblMainUser;
        private Label lblSubUser;
        private Label lblPageNumber;

        private Label label2;
        private Label label5;
        private Label label6;
        private Label label9;
        private Label label12;
        private Label label13;

        private Button btnExitClient;
        private Button btnBackHome;
        private Button btnSearchUserInfo;
        private Button btnInputUserChat;
        private Button btnEnteranceRoom1;
        private Button btnEnteranceRoom2;
        private Button btnEnteranceRoom3;
        private Button btnNextPage;
        private Button btnBackPage;

        private CheckedListBox chkUserView;
        private TextBox tBoxUserChat;
        private RichTextBox richBoxAllUserChatLog;
        private RichTextBox richBoxUserInfo;
    }
}