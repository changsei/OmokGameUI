using Socket_Handler_Form;
using System.Diagnostics;

namespace Game_Client_Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnRegister = new Button();
            btnFindCredentials = new Button();
            lblVersion = new Label();
            lblGuide = new Label();
            tBoxUserId = new TextBox();
            tBoxUserPassword = new TextBox();
            pnlLogo = new Panel();
            chkBoxRememberUserId = new CheckBox();
            btn_unregister = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(318, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 71);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(34, 490);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(390, 38);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "회원 가입";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFindCredentials
            // 
            btnFindCredentials.Location = new Point(34, 534);
            btnFindCredentials.Name = "btnFindCredentials";
            btnFindCredentials.Size = new Size(390, 38);
            btnFindCredentials.TabIndex = 11;
            btnFindCredentials.Text = "회원 계정/비밀번호 조회";
            btnFindCredentials.UseVisualStyleBackColor = true;
            btnFindCredentials.Click += btnFindUserInfomation_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblVersion.Location = new Point(175, 624);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(103, 21);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "Omok ver.1.0";
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblGuide.Location = new Point(34, 452);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(255, 25);
            lblGuide.TabIndex = 37;
            lblGuide.Text = "Please click the desired button.";
            // 
            // tBoxUserId
            // 
            tBoxUserId.Location = new Point(34, 371);
            tBoxUserId.Name = "tBoxUserId";
            tBoxUserId.Size = new Size(278, 31);
            tBoxUserId.TabIndex = 3;
            // 
            // tBoxUserPassword
            // 
            tBoxUserPassword.Location = new Point(34, 408);
            tBoxUserPassword.Name = "tBoxUserPassword";
            tBoxUserPassword.Size = new Size(278, 31);
            tBoxUserPassword.TabIndex = 10;
            // 
            // pnlLogo
            // 
            pnlLogo.BorderStyle = BorderStyle.FixedSingle;
            pnlLogo.Location = new Point(34, 58);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(390, 290);
            pnlLogo.TabIndex = 12;
            // 
            // chkBoxRememberUserId
            // 
            chkBoxRememberUserId.AutoSize = true;
            chkBoxRememberUserId.Location = new Point(321, 451);
            chkBoxRememberUserId.Name = "chkBoxRememberUserId";
            chkBoxRememberUserId.Size = new Size(110, 29);
            chkBoxRememberUserId.TabIndex = 38;
            chkBoxRememberUserId.Text = "계정기억";
            chkBoxRememberUserId.UseVisualStyleBackColor = true;
            // 
            // btn_unregister
            // 
            btn_unregister.Location = new Point(34, 578);
            btn_unregister.Name = "btn_unregister";
            btn_unregister.Size = new Size(390, 38);
            btn_unregister.TabIndex = 39;
            btn_unregister.Text = "회원 탈퇴";
            btn_unregister.UseVisualStyleBackColor = true;
            btn_unregister.Click += btn_unregister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(458, 664);
            Controls.Add(btn_unregister);
            Controls.Add(chkBoxRememberUserId);
            Controls.Add(lblGuide);
            Controls.Add(pnlLogo);
            Controls.Add(btnFindCredentials);
            Controls.Add(tBoxUserPassword);
            Controls.Add(lblVersion);
            Controls.Add(btnRegister);
            Controls.Add(tBoxUserId);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            RightToLeft = RightToLeft.No;
            Text = "Login Form";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private Button btnFindCredentials;
        private Label lblVersion;
        private Label lblGuide;
        private TextBox tBoxUserId;
        private TextBox tBoxUserPassword;
        private Panel pnlLogo;
        private CheckBox chkBoxRememberUserId;
        private Button btn_unregister;
    }
}