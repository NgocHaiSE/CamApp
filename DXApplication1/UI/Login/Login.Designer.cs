namespace DXApplication1.UI.Login
{
    partial class Login
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
            this.labelControlUsername = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlUsername
            // 
            this.labelControlUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlUsername.Appearance.Options.UseFont = true;
            this.labelControlUsername.Location = new System.Drawing.Point(149, 195);
            this.labelControlUsername.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.labelControlUsername.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControlUsername.Name = "labelControlUsername";
            this.labelControlUsername.Size = new System.Drawing.Size(72, 18);
            this.labelControlUsername.TabIndex = 1;
            this.labelControlUsername.Text = "Tài khoản";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(149, 237);
            this.labelControl1.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.labelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mật khẩu";
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.simpleButtonLogin.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonLogin.Appearance.Options.UseBackColor = true;
            this.simpleButtonLogin.Appearance.Options.UseFont = true;
            this.simpleButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButtonLogin.Location = new System.Drawing.Point(286, 312);
            this.simpleButtonLogin.LookAndFeel.SkinMaskColor = System.Drawing.Color.RoyalBlue;
            this.simpleButtonLogin.LookAndFeel.SkinName = "Office 2010 Blue";
            this.simpleButtonLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonLogin.TabIndex = 7;
            this.simpleButtonLogin.Text = "Đăng nhập";
            this.simpleButtonLogin.Click += new System.EventHandler(this.simpleButtonLogin_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(402, 275);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Hiện mật khẩu";
            this.checkEdit1.Size = new System.Drawing.Size(115, 24);
            this.checkEdit1.TabIndex = 6;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(258, 234);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.UseSystemPasswordChar = true;
            this.textEditPassword.Size = new System.Drawing.Size(194, 22);
            this.textEditPassword.TabIndex = 4;
            // 
            // textEditUsername
            // 
            this.textEditUsername.Location = new System.Drawing.Point(258, 189);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Size = new System.Drawing.Size(194, 22);
            this.textEditUsername.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::DXApplication1.Properties.Resources.iconmonstr_user_circle_thin_240;
            this.pictureEdit1.Location = new System.Drawing.Point(274, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(124, 131);
            this.pictureEdit1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 404);
            this.Controls.Add(this.simpleButtonLogin);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditUsername);
            this.Controls.Add(this.labelControlUsername);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControlUsername;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
    }
}