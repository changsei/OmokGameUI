namespace Game_Client_Forms
{
    partial class UserIdInfoForm
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
            pnlLogo = new Panel();
            lblUserInfoHeader = new Label();
            lblVersion = new Label();
            lblUserIdInfo = new Label();
            lblUserInfoTail = new Label();
            SuspendLayout();
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(94, 448);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(290, 38);
            btnBackHome.TabIndex = 61;
            btnBackHome.Text = "로그인 화면으로";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BorderStyle = BorderStyle.FixedSingle;
            pnlLogo.Location = new Point(94, 28);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(290, 250);
            pnlLogo.TabIndex = 56;
            // 
            // lblUserInfoHeader
            // 
            lblUserInfoHeader.AutoSize = true;
            lblUserInfoHeader.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblUserInfoHeader.Location = new Point(175, 295);
            lblUserInfoHeader.Name = "lblUserInfoHeader";
            lblUserInfoHeader.Size = new Size(126, 25);
            lblUserInfoHeader.TabIndex = 55;
            lblUserInfoHeader.Text = "당신의 계정은";
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
            // lblUserIdInfo
            // 
            lblUserIdInfo.AutoSize = true;
            lblUserIdInfo.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblUserIdInfo.Location = new Point(175, 331);
            lblUserIdInfo.Name = "lblUserIdInfo";
            lblUserIdInfo.Size = new Size(120, 54);
            lblUserIdInfo.TabIndex = 62;
            lblUserIdInfo.Text = "NULL";
            // 
            // lblUserInfoTail
            // 
            lblUserInfoTail.AutoSize = true;
            lblUserInfoTail.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblUserInfoTail.Location = new Point(175, 401);
            lblUserInfoTail.Name = "lblUserInfoTail";
            lblUserInfoTail.Size = new Size(70, 25);
            lblUserInfoTail.TabIndex = 63;
            lblUserInfoTail.Text = "입니다.";
            // 
            // UserIdInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(458, 664);
            Controls.Add(lblUserInfoTail);
            Controls.Add(lblUserIdInfo);
            Controls.Add(btnBackHome);
            Controls.Add(pnlLogo);
            Controls.Add(lblUserInfoHeader);
            Controls.Add(lblVersion);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserIdInfoForm";
            Text = "UserIDInfoForm";
            FormClosed += UserIdInfoForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackHome;
        private Panel pnlLogo;
        private Label lblUserInfoHeader;
        private Label lblVersion;
        private Label lblUserIdInfo;
        private Label lblUserInfoTail;
    }
}