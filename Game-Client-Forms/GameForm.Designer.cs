namespace Game_Client_Forms
{
    partial class GameForm
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
            lblLogo = new Label();
            pnlGameBoard = new Panel();
            pnlLog = new Panel();
            richBoxGameLog = new RichTextBox();
            btnInputUserChat = new Button();
            tBoxUserChat = new TextBox();
            richBoxUserChatLog = new RichTextBox();
            pnlUserStatus = new Panel();
            lblSubUserReady = new Label();
            lblMainUserReady = new Label();
            lblSubUserName = new Label();
            lblMainUserName = new Label();
            lblSubUser = new Label();
            lblMainUser = new Label();
            btnBackward = new Button();
            btnSurrender = new Button();
            btnReady = new Button();
            pnlLog.SuspendLayout();
            pnlUserStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("맑은 고딕", 8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblLogo.Location = new Point(580, 619);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(109, 21);
            lblLogo.TabIndex = 27;
            lblLogo.Text = "Omok ver.1.0";
            // 
            // pnlGameBoard
            // 
            pnlGameBoard.BorderStyle = BorderStyle.FixedSingle;
            pnlGameBoard.Location = new Point(34, 16);
            pnlGameBoard.Name = "pnlGameBoard";
            pnlGameBoard.Size = new Size(600, 600);
            pnlGameBoard.TabIndex = 24;
            pnlGameBoard.Paint += pnlGameBoard_Paint;
            pnlGameBoard.MouseDown += pnlGameBoard_MouseDown;
            // 
            // pnlLog
            // 
            pnlLog.BorderStyle = BorderStyle.FixedSingle;
            pnlLog.Controls.Add(richBoxGameLog);
            pnlLog.Controls.Add(btnInputUserChat);
            pnlLog.Controls.Add(tBoxUserChat);
            pnlLog.Controls.Add(richBoxUserChatLog);
            pnlLog.Location = new Point(668, 188);
            pnlLog.Name = "pnlLog";
            pnlLog.Size = new Size(563, 428);
            pnlLog.TabIndex = 23;
            // 
            // richBoxGameLog
            // 
            richBoxGameLog.BackColor = SystemColors.ButtonHighlight;
            richBoxGameLog.Location = new Point(18, 21);
            richBoxGameLog.Name = "richBoxGameLog";
            richBoxGameLog.ReadOnly = true;
            richBoxGameLog.Size = new Size(181, 328);
            richBoxGameLog.TabIndex = 23;
            richBoxGameLog.Text = "";
            // 
            // btnInputUserChat
            // 
            btnInputUserChat.Location = new Point(452, 361);
            btnInputUserChat.Name = "btnInputUserChat";
            btnInputUserChat.Size = new Size(68, 38);
            btnInputUserChat.TabIndex = 22;
            btnInputUserChat.Text = "입력";
            btnInputUserChat.UseVisualStyleBackColor = true;
            btnInputUserChat.Click += btnInputUserChat_Click;
            // 
            // tBoxUserChat
            // 
            tBoxUserChat.Location = new Point(18, 368);
            tBoxUserChat.Name = "tBoxUserChat";
            tBoxUserChat.Size = new Size(430, 31);
            tBoxUserChat.TabIndex = 1;
            // 
            // richBoxUserChatLog
            // 
            richBoxUserChatLog.BackColor = SystemColors.ButtonHighlight;
            richBoxUserChatLog.Location = new Point(214, 21);
            richBoxUserChatLog.Name = "richBoxUserChatLog";
            richBoxUserChatLog.ReadOnly = true;
            richBoxUserChatLog.Size = new Size(306, 328);
            richBoxUserChatLog.TabIndex = 0;
            richBoxUserChatLog.Text = "";
            // 
            // pnlUserStatus
            // 
            pnlUserStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlUserStatus.BorderStyle = BorderStyle.FixedSingle;
            pnlUserStatus.Controls.Add(lblSubUserReady);
            pnlUserStatus.Controls.Add(lblMainUserReady);
            pnlUserStatus.Controls.Add(lblSubUserName);
            pnlUserStatus.Controls.Add(lblMainUserName);
            pnlUserStatus.Controls.Add(lblSubUser);
            pnlUserStatus.Controls.Add(lblMainUser);
            pnlUserStatus.Controls.Add(btnBackward);
            pnlUserStatus.Controls.Add(btnSurrender);
            pnlUserStatus.Controls.Add(btnReady);
            pnlUserStatus.Location = new Point(668, 16);
            pnlUserStatus.Name = "pnlUserStatus";
            pnlUserStatus.Size = new Size(563, 163);
            pnlUserStatus.TabIndex = 22;
            // 
            // lblSubUserReady
            // 
            lblSubUserReady.AutoSize = true;
            lblSubUserReady.Location = new Point(165, 112);
            lblSubUserReady.Name = "lblSubUserReady";
            lblSubUserReady.Size = new Size(62, 25);
            lblSubUserReady.TabIndex = 26;
            lblSubUserReady.Text = "Ready";
            // 
            // lblMainUserReady
            // 
            lblMainUserReady.AutoSize = true;
            lblMainUserReady.Location = new Point(16, 112);
            lblMainUserReady.Name = "lblMainUserReady";
            lblMainUserReady.Size = new Size(62, 25);
            lblMainUserReady.TabIndex = 25;
            lblMainUserReady.Text = "Ready";
            // 
            // lblSubUserName
            // 
            lblSubUserName.AutoSize = true;
            lblSubUserName.Location = new Point(165, 68);
            lblSubUserName.Name = "lblSubUserName";
            lblSubUserName.Size = new Size(98, 25);
            lblSubUserName.TabIndex = 24;
            lblSubUserName.Text = "Sub Name";
            // 
            // lblMainUserName
            // 
            lblMainUserName.AutoSize = true;
            lblMainUserName.Location = new Point(16, 68);
            lblMainUserName.Name = "lblMainUserName";
            lblMainUserName.Size = new Size(107, 25);
            lblMainUserName.TabIndex = 23;
            lblMainUserName.Text = "Main Name";
            // 
            // lblSubUser
            // 
            lblSubUser.AutoSize = true;
            lblSubUser.Location = new Point(165, 24);
            lblSubUser.Name = "lblSubUser";
            lblSubUser.Size = new Size(86, 25);
            lblSubUser.TabIndex = 22;
            lblSubUser.Text = "Sub User";
            // 
            // lblMainUser
            // 
            lblMainUser.AutoSize = true;
            lblMainUser.Location = new Point(16, 22);
            lblMainUser.Name = "lblMainUser";
            lblMainUser.Size = new Size(95, 25);
            lblMainUser.TabIndex = 21;
            lblMainUser.Text = "Main User";
            // 
            // btnBackward
            // 
            btnBackward.Location = new Point(340, 105);
            btnBackward.Name = "btnBackward";
            btnBackward.Size = new Size(180, 38);
            btnBackward.TabIndex = 20;
            btnBackward.Text = "나가기";
            btnBackward.UseVisualStyleBackColor = true;
            btnBackward.Click += btnBackward_Click;
            // 
            // btnSurrender
            // 
            btnSurrender.Location = new Point(340, 61);
            btnSurrender.Name = "btnSurrender";
            btnSurrender.Size = new Size(180, 38);
            btnSurrender.TabIndex = 19;
            btnSurrender.Text = "기권";
            btnSurrender.UseVisualStyleBackColor = true;
            btnSurrender.Click += btnSurrender_Click;
            // 
            // btnReady
            // 
            btnReady.Location = new Point(340, 17);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(180, 38);
            btnReady.TabIndex = 18;
            btnReady.Text = "준비/시작";
            btnReady.UseVisualStyleBackColor = true;
            btnReady.Click += btnReady_Click;
            // 
            // GameForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1258, 664);
            Controls.Add(lblLogo);
            Controls.Add(pnlGameBoard);
            Controls.Add(pnlLog);
            Controls.Add(pnlUserStatus);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            pnlLog.ResumeLayout(false);
            pnlLog.PerformLayout();
            pnlUserStatus.ResumeLayout(false);
            pnlUserStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogo;
        private Panel pnlGameBoard;
        private Panel pnlLog;
        private Button btnInputUserChat;
        private TextBox tBoxUserChat;
        private RichTextBox richBoxUserChatLog;
        private Panel pnlUserStatus;
        private Button btnBackward;
        private Button btnSurrender;
        private Button btnReady;
        private RichTextBox richBoxGameLog;
        private Label lblMainUser;
        private Label lblSubUserReady;
        private Label lblMainUserReady;
        private Label lblSubUserName;
        private Label lblMainUserName;
        private Label lblSubUser;
    }
}