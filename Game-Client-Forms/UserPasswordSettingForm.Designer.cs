namespace Game_Client_Forms
{
    partial class UserPasswordSettingForm
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
            pnlLogo = new Panel();
            lblGuide = new Label();
            lblVersion = new Label();
            tboxConfirmUserPassword = new TextBox();
            tBoxUserPassword = new TextBox();
            btnRegisterPassword = new Button();
            btnBackHome = new Button();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BorderStyle = BorderStyle.FixedSingle;
            pnlLogo.Location = new Point(94, 28);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(290, 250);
            pnlLogo.TabIndex = 46;
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblGuide.Location = new Point(94, 530);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(262, 25);
            lblGuide.TabIndex = 45;
            lblGuide.Text = "원하시는 버튼을 클릭해주세요.";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("맑은 고딕", 8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblVersion.Location = new Point(175, 624);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(109, 21);
            lblVersion.TabIndex = 43;
            lblVersion.Text = "Omok ver.1.0";
            // 
            // tboxConfirmUserPassword
            // 
            tboxConfirmUserPassword.Location = new Point(94, 346);
            tboxConfirmUserPassword.Name = "tboxConfirmUserPassword";
            tboxConfirmUserPassword.Size = new Size(290, 31);
            tboxConfirmUserPassword.TabIndex = 48;
            tboxConfirmUserPassword.Text = "비밀번호 확인이 필요합니다.";
            // 
            // tBoxUserPassword
            // 
            tBoxUserPassword.Location = new Point(94, 309);
            tBoxUserPassword.Name = "tBoxUserPassword";
            tBoxUserPassword.Size = new Size(290, 31);
            tBoxUserPassword.TabIndex = 47;
            tBoxUserPassword.Text = "비밀번호가 필요 합니다.";
            // 
            // btnRegisterPassword
            // 
            btnRegisterPassword.Location = new Point(94, 445);
            btnRegisterPassword.Name = "btnRegisterPassword";
            btnRegisterPassword.Size = new Size(290, 38);
            btnRegisterPassword.TabIndex = 49;
            btnRegisterPassword.Text = "PW 설정";
            btnRegisterPassword.UseVisualStyleBackColor = true;
            btnRegisterPassword.Click += btnRegisterPassword_Click;
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(94, 489);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(290, 38);
            btnBackHome.TabIndex = 51;
            btnBackHome.Text = "로그인 화면으로";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // UserPasswordSettingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(458, 664);
            Controls.Add(btnBackHome);
            Controls.Add(btnRegisterPassword);
            Controls.Add(tboxConfirmUserPassword);
            Controls.Add(tBoxUserPassword);
            Controls.Add(pnlLogo);
            Controls.Add(lblGuide);
            Controls.Add(lblVersion);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserPasswordSettingForm";
            Text = "UserPasswordSettingForm";
            FormClosed += UserPasswordSettingForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlLogo;
        private Label lblGuide;
        private Label lblVersion;
        private TextBox tboxConfirmUserPassword;
        private TextBox tBoxUserPassword;
        private Button btnRegisterPassword;
        private Button btnBackHome;
    }
}