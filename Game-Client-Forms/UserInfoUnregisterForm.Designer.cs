namespace Game_Client_Forms
{
    partial class UserInfoUnregisterForm
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
            btnBackHome = new Button();
            btnUnregister = new Button();
            tBoxUserPassword = new TextBox();
            tBoxUserId = new TextBox();
            pnlLogo = new Panel();
            lblGuide = new Label();
            lblVersion = new Label();
            SuspendLayout();
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(86, 445);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(290, 38);
            btnBackHome.TabIndex = 61;
            btnBackHome.Text = "로그인 화면으로";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // btnUnregister
            // 
            btnUnregister.Location = new Point(86, 401);
            btnUnregister.Name = "btnUnregister";
            btnUnregister.Size = new Size(290, 38);
            btnUnregister.TabIndex = 59;
            btnUnregister.Text = "회원 탈퇴";
            btnUnregister.UseVisualStyleBackColor = true;
            btnUnregister.Click += btnUnregister_Click;
            // 
            // tBoxUserPassword
            // 
            tBoxUserPassword.Location = new Point(86, 342);
            tBoxUserPassword.Name = "tBoxUserPassword";
            tBoxUserPassword.Size = new Size(290, 31);
            tBoxUserPassword.TabIndex = 58;
            // 
            // tBoxUserId
            // 
            tBoxUserId.Location = new Point(86, 305);
            tBoxUserId.Name = "tBoxUserId";
            tBoxUserId.Size = new Size(290, 31);
            tBoxUserId.TabIndex = 57;
            // 
            // pnlLogo
            // 
            pnlLogo.BorderStyle = BorderStyle.FixedSingle;
            pnlLogo.Location = new Point(86, 24);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(290, 250);
            pnlLogo.TabIndex = 56;
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblGuide.Location = new Point(86, 495);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(262, 25);
            lblGuide.TabIndex = 55;
            lblGuide.Text = "원하시는 버튼을 클릭해주세요.";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("맑은 고딕", 8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblVersion.Location = new Point(175, 624);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(109, 21);
            lblVersion.TabIndex = 54;
            lblVersion.Text = "Omok ver.1.0";
            // 
            // UserInfoUnregisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(458, 664);
            Controls.Add(btnBackHome);
            Controls.Add(btnUnregister);
            Controls.Add(tBoxUserPassword);
            Controls.Add(tBoxUserId);
            Controls.Add(pnlLogo);
            Controls.Add(lblGuide);
            Controls.Add(lblVersion);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserInfoUnregisterForm";
            Text = "UserInfoUnregisterForm";
            Load += UserInfoUnregisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackHome;
        private Button btnBackward;
        private Button btnUnregister;
        private TextBox tBoxUserPassword;
        private TextBox tBoxUserId;
        private Panel pnlLogo;
        private Label lblGuide;
        private Label lblVersion;
    }
}