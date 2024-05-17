

namespace Game_Client_Forms
{
    partial class UserInfoRegisterForm
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
            tBoxUserPassword = new TextBox();
            lblVersion = new Label();
            btnRegister = new Button();
            tBoxUserId = new TextBox();
            tBoxConfirmUserPassword = new TextBox();
            lblGuide = new Label();
            pnlLogo = new Panel();
            btnBackward = new Button();
            tBoxUserName = new TextBox();
            tBoxUserPhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // tBoxUserPassword
            // 
            tBoxUserPassword.Location = new Point(94, 336);
            tBoxUserPassword.Name = "tBoxUserPassword";
            tBoxUserPassword.Size = new Size(290, 31);
            tBoxUserPassword.TabIndex = 19;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("맑은 고딕", 8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblVersion.Location = new Point(175, 624);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(109, 21);
            lblVersion.TabIndex = 18;
            lblVersion.Text = "Omok ver.1.0";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(94, 515);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(290, 38);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "계정생성";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // tBoxUserId
            // 
            tBoxUserId.Location = new Point(94, 299);
            tBoxUserId.Name = "tBoxUserId";
            tBoxUserId.Size = new Size(290, 31);
            tBoxUserId.TabIndex = 16;
            // 
            // tBoxConfirmUserPassword
            // 
            tBoxConfirmUserPassword.Location = new Point(94, 373);
            tBoxConfirmUserPassword.Name = "tBoxConfirmUserPassword";
            tBoxConfirmUserPassword.Size = new Size(290, 31);
            tBoxConfirmUserPassword.TabIndex = 21;
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblGuide.Location = new Point(94, 481);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(190, 25);
            lblGuide.TabIndex = 27;
            lblGuide.Text = "계정을 입력해 주세요.";
            // 
            // pnlLogo
            // 
            pnlLogo.BorderStyle = BorderStyle.FixedSingle;
            pnlLogo.Location = new Point(94, 28);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(290, 250);
            pnlLogo.TabIndex = 28;
            // 
            // btnBackward
            // 
            btnBackward.Location = new Point(94, 559);
            btnBackward.Name = "btnBackward";
            btnBackward.Size = new Size(290, 38);
            btnBackward.TabIndex = 51;
            btnBackward.Text = "뒤로 가기";
            btnBackward.UseVisualStyleBackColor = true;
            btnBackward.Click += btnBackward_Click;
            // 
            // tBoxUserName
            // 
            tBoxUserName.Location = new Point(94, 410);
            tBoxUserName.Name = "tBoxUserName";
            tBoxUserName.Size = new Size(290, 31);
            tBoxUserName.TabIndex = 52;
            // 
            // tBoxUserPhoneNumber
            // 
            tBoxUserPhoneNumber.Location = new Point(94, 447);
            tBoxUserPhoneNumber.Name = "tBoxUserPhoneNumber";
            tBoxUserPhoneNumber.Size = new Size(290, 31);
            tBoxUserPhoneNumber.TabIndex = 53;
            // 
            // UserInfoRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(458, 664);
            Controls.Add(tBoxUserPhoneNumber);
            Controls.Add(tBoxUserName);
            Controls.Add(btnBackward);
            Controls.Add(pnlLogo);
            Controls.Add(lblGuide);
            Controls.Add(tBoxConfirmUserPassword);
            Controls.Add(tBoxUserPassword);
            Controls.Add(lblVersion);
            Controls.Add(btnRegister);
            Controls.Add(tBoxUserId);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserInfoRegisterForm";
            Text = "RegisterForm";
            FormClosed += UserInfoRegisterForm_FormClosed;
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private TextBox tBoxUserPassword;
        private Label lblVersion;
        private Button btnRegister;
        private TextBox tBoxUserId;
        private TextBox tBoxConfirmUserPassword;
        private Label lblGuide;
        private Panel pnlLogo;
        private Button btnBackward;
        private TextBox tBoxUserName;
        private TextBox tBoxUserPhoneNumber;
    }
}