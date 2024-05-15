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
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            button2 = new Button();
            panel5 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnBackPage = new Button();
            panel4 = new Panel();
            lblRoomUseStatus = new Label();
            lblRoomStatus = new Label();
            lblSubUserName = new Label();
            lblMainUserName = new Label();
            lblSubUser = new Label();
            lblMainUser = new Label();
            lblRoomNumber = new Label();
            btnEnteranceRoom = new Button();
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
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(257, 61);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(180, 38);
            btnBackHome.TabIndex = 19;
            btnBackHome.Text = "로그인 화면으로";
            btnBackHome.UseVisualStyleBackColor = true;
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
            // 
            // tBoxUserChat
            // 
            tBoxUserChat.Location = new Point(22, 261);
            tBoxUserChat.Name = "tBoxUserChat";
            tBoxUserChat.Size = new Size(341, 31);
            tBoxUserChat.TabIndex = 1;
            tBoxUserChat.Text = "여기에 채팅 내용을 입력해주세요.";
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
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(button2);
            panel6.Location = new Point(19, 364);
            panel6.Name = "panel6";
            panel6.Size = new Size(675, 135);
            panel6.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(115, 91);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 8;
            label8.Text = "방 상태";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(115, 65);
            label10.Name = "label10";
            label10.Size = new Size(102, 25);
            label10.TabIndex = 5;
            label10.Text = "도전자이름";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(115, 39);
            label11.Name = "label11";
            label11.Size = new Size(84, 25);
            label11.TabIndex = 4;
            label11.Text = "방장이름";
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
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 14);
            label14.Name = "label14";
            label14.Size = new Size(40, 25);
            label14.TabIndex = 1;
            label14.Text = "3번";
            // 
            // button2
            // 
            button2.Location = new Point(335, 14);
            button2.Name = "button2";
            button2.Size = new Size(321, 105);
            button2.TabIndex = 0;
            button2.Text = "입장";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(button1);
            panel5.Location = new Point(19, 211);
            panel5.Name = "panel5";
            panel5.Size = new Size(675, 135);
            panel5.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 91);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 8;
            label1.Text = "방 상태";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 65);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 5;
            label3.Text = "도전자이름";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 39);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 4;
            label4.Text = "방장이름";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 14);
            label7.Name = "label7";
            label7.Size = new Size(40, 25);
            label7.TabIndex = 1;
            label7.Text = "2번";
            // 
            // button1
            // 
            button1.Location = new Point(335, 14);
            button1.Name = "button1";
            button1.Size = new Size(321, 105);
            button1.TabIndex = 0;
            button1.Text = "입장";
            button1.UseVisualStyleBackColor = true;
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
            panel4.Controls.Add(lblRoomUseStatus);
            panel4.Controls.Add(lblRoomStatus);
            panel4.Controls.Add(lblSubUserName);
            panel4.Controls.Add(lblMainUserName);
            panel4.Controls.Add(lblSubUser);
            panel4.Controls.Add(lblMainUser);
            panel4.Controls.Add(lblRoomNumber);
            panel4.Controls.Add(btnEnteranceRoom);
            panel4.Location = new Point(19, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(675, 135);
            panel4.TabIndex = 0;
            // 
            // lblRoomUseStatus
            // 
            lblRoomUseStatus.AutoSize = true;
            lblRoomUseStatus.Location = new Point(115, 91);
            lblRoomUseStatus.Name = "lblRoomUseStatus";
            lblRoomUseStatus.Size = new Size(72, 25);
            lblRoomUseStatus.TabIndex = 8;
            lblRoomUseStatus.Text = "방 상태";
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
            // lblSubUserName
            // 
            lblSubUserName.AutoSize = true;
            lblSubUserName.Location = new Point(115, 65);
            lblSubUserName.Name = "lblSubUserName";
            lblSubUserName.Size = new Size(102, 25);
            lblSubUserName.TabIndex = 5;
            lblSubUserName.Text = "도전자이름";
            // 
            // lblMainUserName
            // 
            lblMainUserName.AutoSize = true;
            lblMainUserName.Location = new Point(115, 39);
            lblMainUserName.Name = "lblMainUserName";
            lblMainUserName.Size = new Size(84, 25);
            lblMainUserName.TabIndex = 4;
            lblMainUserName.Text = "방장이름";
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
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(14, 14);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(40, 25);
            lblRoomNumber.TabIndex = 1;
            lblRoomNumber.Text = "1번";
            // 
            // btnEnteranceRoom
            // 
            btnEnteranceRoom.Location = new Point(335, 14);
            btnEnteranceRoom.Name = "btnEnteranceRoom";
            btnEnteranceRoom.Size = new Size(321, 105);
            btnEnteranceRoom.TabIndex = 0;
            btnEnteranceRoom.Text = "입장";
            btnEnteranceRoom.UseVisualStyleBackColor = true;
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
        private Label lblVersion;
        private Panel panel4;
        private Button btnExitClient;
        private Button btnBackHome;
        private Button btnSearchUserInfo;
        private Button btnInputUserChat;
        private CheckedListBox chkUserView;
        private TextBox tBoxUserChat;
        private RichTextBox richBoxAllUserChatLog;
        private RichTextBox richBoxUserInfo;
        private Label lblRoomNumber;
        private Button btnEnteranceRoom;
        private Label lblRoomUseStatus;
        private Label lblRoomStatus;
        private Label lblSubUserName;
        private Label lblMainUserName;
        private Label lblSubUser;
        private Label lblMainUser;
        private Button btnNextPage;
        private Button btnBackPage;
        private Label lblPageNumber;
        private Panel panel6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button button2;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}