namespace Game_Client_Forms
{
    partial class UserInfoForm
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
            tBoxUserPhoneNumber = new TextBox();
            lblVersion = new Label();
            btnSeachUserPassword = new Button();
            tBoxUserPassword = new TextBox();
            lblGuide = new Label();
            btnSearchUserId = new Button();
            btnBackward = new Button();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BorderStyle = BorderStyle.FixedSingle;
            pnlLogo.Location = new Point(94, 28);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(290, 250);
            pnlLogo.TabIndex = 37;
            // 
            // tBoxUserPhoneNumber
            // 
            tBoxUserPhoneNumber.Location = new Point(94, 428);
            tBoxUserPhoneNumber.Name = "tBoxUserPhoneNumber";
            tBoxUserPhoneNumber.Size = new Size(290, 31);
            tBoxUserPhoneNumber.TabIndex = 34;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("맑은 고딕", 8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblVersion.Location = new Point(175, 624);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(109, 21);
            lblVersion.TabIndex = 33;
            lblVersion.Text = "Omok ver.1.0";
            // 
            // btnSeachUserPassword
            // 
            btnSeachUserPassword.Location = new Point(94, 336);
            btnSeachUserPassword.Name = "btnSeachUserPassword";
            btnSeachUserPassword.Size = new Size(290, 38);
            btnSeachUserPassword.TabIndex = 32;
            btnSeachUserPassword.Text = "PW 찾기";
            btnSeachUserPassword.UseVisualStyleBackColor = true;
            // 
            // tBoxUserPassword
            // 
            tBoxUserPassword.Location = new Point(94, 299);
            tBoxUserPassword.Name = "tBoxUserPassword";
            tBoxUserPassword.Size = new Size(290, 31);
            tBoxUserPassword.TabIndex = 31;
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblGuide.Location = new Point(94, 389);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(262, 25);
            lblGuide.TabIndex = 36;
            lblGuide.Text = "원하시는 버튼을 클릭해주세요.";
            // 
            // btnSearchUserId
            // 
            btnSearchUserId.Location = new Point(94, 465);
            btnSearchUserId.Name = "btnSearchUserId";
            btnSearchUserId.Size = new Size(290, 38);
            btnSearchUserId.TabIndex = 38;
            btnSearchUserId.Text = "ID 찾기";
            btnSearchUserId.UseVisualStyleBackColor = true;
            // 
            // btnBackward
            // 
            btnBackward.Location = new Point(94, 509);
            btnBackward.Name = "btnBackward";
            btnBackward.Size = new Size(290, 38);
            btnBackward.TabIndex = 51;
            btnBackward.Text = "뒤로 가기";
            btnBackward.UseVisualStyleBackColor = true;
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(458, 664);
            Controls.Add(btnBackward);
            Controls.Add(btnSearchUserId);
            Controls.Add(pnlLogo);
            Controls.Add(lblGuide);
            Controls.Add(tBoxUserPhoneNumber);
            Controls.Add(lblVersion);
            Controls.Add(btnSeachUserPassword);
            Controls.Add(tBoxUserPassword);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserInfoForm";
            Text = "UserInfoForm";
            Load += UserInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogo;
        private TextBox tBoxUserPhoneNumber;
        private Label lblVersion;
        private Button btnSeachUserPassword;
        private TextBox tBoxUserPassword;
        private Label lblGuide;
        private Button btnSearchUserId;
        private Button btnBackward;
    }
}