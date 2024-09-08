namespace DXApplication1.UI.ChildForms
{
    partial class AddUser
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
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.textEditInfo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.checkManager = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkManager.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Location = new System.Drawing.Point(489, 284);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonSave.TabIndex = 16;
            this.simpleButtonSave.Text = "Lưu";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // textEditInfo
            // 
            this.textEditInfo.Location = new System.Drawing.Point(220, 149);
            this.textEditInfo.Name = "textEditInfo";
            this.textEditInfo.Properties.AutoHeight = false;
            this.textEditInfo.Properties.NullText = "Nhập thông tin tài khoản...";
            this.textEditInfo.Size = new System.Drawing.Size(305, 52);
            this.textEditInfo.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(109, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Thông tin";
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(220, 100);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.UseSystemPasswordChar = true;
            this.textEditPassword.Size = new System.Drawing.Size(305, 22);
            this.textEditPassword.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(109, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // textEditUsername
            // 
            this.textEditUsername.EditValue = "";
            this.textEditUsername.Location = new System.Drawing.Point(220, 51);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Size = new System.Drawing.Size(305, 22);
            this.textEditUsername.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(109, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // checkAdmin
            // 
            this.checkAdmin.Location = new System.Drawing.Point(220, 229);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Properties.Caption = "Admin";
            this.checkAdmin.Size = new System.Drawing.Size(94, 24);
            this.checkAdmin.TabIndex = 17;
            // 
            // checkManager
            // 
            this.checkManager.Location = new System.Drawing.Point(347, 229);
            this.checkManager.Name = "checkManager";
            this.checkManager.Properties.Caption = "Quản lý";
            this.checkManager.Size = new System.Drawing.Size(94, 24);
            this.checkManager.TabIndex = 18;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 377);
            this.Controls.Add(this.checkManager);
            this.Controls.Add(this.checkAdmin);
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.textEditInfo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditUsername);
            this.Controls.Add(this.labelControl1);
            this.Name = "AddUser";
            this.Text = "Thêm tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.textEditInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkManager.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.TextEdit textEditInfo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkAdmin;
        private DevExpress.XtraEditors.CheckEdit checkManager;
    }
}