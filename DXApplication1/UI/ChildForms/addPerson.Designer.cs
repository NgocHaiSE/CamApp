namespace DXApplication1.UI.ChildForms
{
    partial class addPerson
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
        ///
        private void InitializeComponent()
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.checkIsRecog = new System.Windows.Forms.CheckBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddImage = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.ptrMain = new System.Windows.Forms.PictureBox();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.layoutControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(52, 38);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(863, 652);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Location = new System.Drawing.Point(12, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(839, 628);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ptrMain);
            this.panelControl1.Controls.Add(this.btnReset);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.checkIsRecog);
            this.panelControl1.Controls.Add(this.txtCode);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btnAddImage);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.txtInfo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(815, 604);
            this.panelControl1.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(352, 546);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Khôi phục";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(231, 546);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkIsRecog
            // 
            this.checkIsRecog.AutoSize = true;
            this.checkIsRecog.Location = new System.Drawing.Point(460, 194);
            this.checkIsRecog.Name = "checkIsRecog";
            this.checkIsRecog.Size = new System.Drawing.Size(86, 20);
            this.checkIsRecog.TabIndex = 34;
            this.checkIsRecog.Text = "Nhận diện";
            this.checkIsRecog.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(349, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 16);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Mã nhân viên";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(695, 237);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(94, 29);
            this.btnAddImage.TabIndex = 31;
            this.btnAddImage.Text = "Thêm ảnh";
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.AllowTouchScroll = true;
            this.panelControl2.Controls.Add(this.flowLayoutPanel1);
            this.panelControl2.InvertTouchScroll = true;
            this.panelControl2.Location = new System.Drawing.Point(0, 272);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(806, 249);
            this.panelControl2.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 245);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(460, 103);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(305, 72);
            this.txtInfo.TabIndex = 29;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(349, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = " Thông tin";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(349, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Họ và tên";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(839, 628);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(819, 608);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(863, 652);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(843, 632);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            windowsUIButtonImageOptions2.ImageUri.Uri = "Backward;Size32x32;GrayScaled";
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanelCloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(52, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(52, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(6, 6, 0, 0);
            this.windowsUIButtonPanelCloseButton.Size = new System.Drawing.Size(52, 690);
            this.windowsUIButtonPanelCloseButton.TabIndex = 2;
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanelCloseButton.UseButtonBackgroundImages = false;
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.Options.UseFont = true;
            this.labelControl.Appearance.Options.UseForeColor = true;
            this.labelControl.Appearance.Options.UseTextOptions = true;
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Location = new System.Drawing.Point(52, 0);
            this.labelControl.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(12, 6, 0, 0);
            this.labelControl.Size = new System.Drawing.Size(863, 38);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Quản lý nhân viên";
            // 
            // ptrMain
            // 
            this.ptrMain.Location = new System.Drawing.Point(61, 21);
            this.ptrMain.Name = "ptrMain";
            this.ptrMain.Size = new System.Drawing.Size(207, 223);
            this.ptrMain.TabIndex = 37;
            this.ptrMain.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.EditValue = "";
            this.txtCode.Location = new System.Drawing.Point(460, 18);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(305, 22);
            this.txtCode.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.EditValue = "";
            this.txtName.Location = new System.Drawing.Point(460, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 22);
            this.txtName.TabIndex = 20;
            // 
            // addPerson
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(915, 690);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addPerson";
            this.Load += new System.EventHandler(this.addPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TextBox txtInfo;
        private DevExpress.XtraEditors.SimpleButton btnAddImage;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.CheckBox checkIsRecog;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.PictureBox ptrMain;
    }

}