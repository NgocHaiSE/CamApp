namespace DXApplication1.UI.Modules
{
    partial class ucViewCam
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelNotification = new DevExpress.Utils.Layout.StackPanel();
            this.CameraPanel = new System.Windows.Forms.Panel();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.CameraComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.StackPanel)).BeginInit();
            this.StackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNotification)).BeginInit();
            this.CameraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraComboBox.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StackPanel
            // 
            this.StackPanel.Appearance.BackColor = System.Drawing.Color.Silver;
            this.StackPanel.Appearance.Options.UseBackColor = true;
            this.StackPanel.AutoScroll = true;
            this.StackPanel.Controls.Add(this.panelControl1);
            this.StackPanel.Controls.Add(this.panelNotification);
            this.StackPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.StackPanel.Location = new System.Drawing.Point(642, 0);
            this.StackPanel.Name = "StackPanel";
            this.StackPanel.Size = new System.Drawing.Size(356, 627);
            this.StackPanel.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(20, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(316, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(108, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thông báo";
            // 
            // panelNotification
            // 
            this.panelNotification.AutoScroll = true;
            this.panelNotification.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotification.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.panelNotification.Location = new System.Drawing.Point(3, 53);
            this.panelNotification.Name = "panelNotification";
            this.panelNotification.Size = new System.Drawing.Size(350, 571);
            this.StackPanel.SetStretched(this.panelNotification, true);
            this.panelNotification.TabIndex = 2;
            this.panelNotification.UseSkinIndents = true;
            // 
            // CameraPanel
            // 
            this.CameraPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraPanel.Controls.Add(this.pictureBoxCamera);
            this.CameraPanel.Location = new System.Drawing.Point(1, 50);
            this.CameraPanel.Name = "CameraPanel";
            this.CameraPanel.Size = new System.Drawing.Size(635, 577);
            this.CameraPanel.TabIndex = 5;
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCamera.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(635, 577);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCamera.TabIndex = 0;
            this.pictureBoxCamera.TabStop = false;
            // 
            // CameraComboBox
            // 
            this.CameraComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraComboBox.EditValue = "2x2";
            this.CameraComboBox.Location = new System.Drawing.Point(497, 3);
            this.CameraComboBox.Name = "CameraComboBox";
            this.CameraComboBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.CameraComboBox.Properties.Appearance.Options.UseFont = true;
            this.CameraComboBox.Properties.AutoHeight = false;
            this.CameraComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CameraComboBox.Properties.Items.AddRange(new object[] {
            "1x1",
            "2x2",
            "3x3",
            "4x4"});
            this.CameraComboBox.Size = new System.Drawing.Size(102, 41);
            this.CameraComboBox.TabIndex = 6;
            this.CameraComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanel1.Controls.Add(this.simpleButton2);
            this.sidePanel1.Controls.Add(this.simpleButton1);
            this.sidePanel1.Controls.Add(this.CameraComboBox);
            this.sidePanel1.Location = new System.Drawing.Point(3, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(633, 47);
            this.sidePanel1.TabIndex = 7;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(287, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(110, 43);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Thêm";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(0, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 43);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Thêm";
            // 
            // ucViewCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.CameraPanel);
            this.Controls.Add(this.StackPanel);
            this.Name = "ucViewCam";
            this.Size = new System.Drawing.Size(998, 627);
            this.Load += new System.EventHandler(this.ucViewCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StackPanel)).EndInit();
            this.StackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNotification)).EndInit();
            this.CameraPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraComboBox.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel StackPanel;
        private System.Windows.Forms.Panel CameraPanel;
        private DevExpress.XtraEditors.ComboBoxEdit CameraComboBox;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.Layout.StackPanel panelNotification;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
    }
}
