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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPerson));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddImage = new DevExpress.XtraEditors.SimpleButton();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.memoInfo = new DevExpress.XtraEditors.MemoEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnReset = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lbAddress = new DevExpress.XtraEditors.LabelControl();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.cbIsRecog = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lbPhone = new DevExpress.XtraEditors.LabelControl();
            this.lbGender = new DevExpress.XtraEditors.LabelControl();
            this.cbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbBirth = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lbCode = new DevExpress.XtraEditors.LabelControl();
            this.ptrMain = new DevExpress.XtraEditors.PictureEdit();
            this.dateEditBirth = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsRecog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirth.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dateEditBirth);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnAddImage);
            this.panelControl1.Controls.Add(this.stackPanel1);
            this.panelControl1.Controls.Add(this.memoInfo);
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.lbAddress);
            this.panelControl1.Controls.Add(this.lbStatus);
            this.panelControl1.Controls.Add(this.cbIsRecog);
            this.panelControl1.Controls.Add(this.txtPhone);
            this.panelControl1.Controls.Add(this.lbPhone);
            this.panelControl1.Controls.Add(this.lbGender);
            this.panelControl1.Controls.Add(this.cbGender);
            this.panelControl1.Controls.Add(this.lbBirth);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.lbName);
            this.panelControl1.Controls.Add(this.txtCode);
            this.panelControl1.Controls.Add(this.lbCode);
            this.panelControl1.Controls.Add(this.ptrMain);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 183);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1171, 566);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(687, 245);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Thông tin";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(532, 257);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(94, 29);
            this.btnAddImage.TabIndex = 19;
            this.btnAddImage.Text = "Thêm ảnh";
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // stackPanel1
            // 
            this.stackPanel1.AutoScroll = true;
            this.stackPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.stackPanel1.Location = new System.Drawing.Point(26, 292);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(600, 240);
            this.stackPanel1.TabIndex = 18;
            this.stackPanel1.UseSkinIndents = true;
            // 
            // memoInfo
            // 
            this.memoInfo.AllowDrop = true;
            this.memoInfo.Location = new System.Drawing.Point(687, 277);
            this.memoInfo.MenuManager = this.ribbonControl1;
            this.memoInfo.Name = "memoInfo";
            this.memoInfo.Size = new System.Drawing.Size(417, 255);
            this.memoInfo.TabIndex = 17;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barbtnSave,
            this.barButtonItem1,
            this.barbtnReset});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1171, 183);
            // 
            // barbtnSave
            // 
            this.barbtnSave.Caption = "Lưu";
            this.barbtnSave.Id = 3;
            this.barbtnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnSave.ImageOptions.LargeImage")));
            this.barbtnSave.Name = "barbtnSave";
            this.barbtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnSave_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barbtnReset
            // 
            this.barbtnReset.Caption = "Khôi phục";
            this.barbtnReset.Id = 5;
            this.barbtnReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtnReset.ImageOptions.LargeImage")));
            this.barbtnReset.Name = "barbtnReset";
            this.barbtnReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnReset_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thao tác";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnReset);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Chỉnh sửa";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(801, 90);
            this.txtAddress.MenuManager = this.ribbonControl1;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(303, 22);
            this.txtAddress.TabIndex = 16;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(687, 93);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(39, 16);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(687, 157);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(57, 16);
            this.lbStatus.TabIndex = 14;
            this.lbStatus.Text = "Nhận diện";
            // 
            // cbIsRecog
            // 
            this.cbIsRecog.Location = new System.Drawing.Point(801, 154);
            this.cbIsRecog.MenuManager = this.ribbonControl1;
            this.cbIsRecog.Name = "cbIsRecog";
            this.cbIsRecog.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIsRecog.Properties.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbIsRecog.Size = new System.Drawing.Size(153, 22);
            this.cbIsRecog.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(801, 32);
            this.txtPhone.MenuManager = this.ribbonControl1;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(303, 22);
            this.txtPhone.TabIndex = 12;
            // 
            // lbPhone
            // 
            this.lbPhone.Location = new System.Drawing.Point(687, 35);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(75, 16);
            this.lbPhone.TabIndex = 11;
            this.lbPhone.Text = "Số điện thoại";
            // 
            // lbGender
            // 
            this.lbGender.Location = new System.Drawing.Point(26, 221);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(46, 16);
            this.lbGender.TabIndex = 10;
            this.lbGender.Text = "Giới tính";
            // 
            // cbGender
            // 
            this.cbGender.Location = new System.Drawing.Point(140, 218);
            this.cbGender.MenuManager = this.ribbonControl1;
            this.cbGender.Name = "cbGender";
            this.cbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGender.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Size = new System.Drawing.Size(153, 22);
            this.cbGender.TabIndex = 9;
            // 
            // lbBirth
            // 
            this.lbBirth.Location = new System.Drawing.Point(26, 160);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(55, 16);
            this.lbBirth.TabIndex = 8;
            this.lbBirth.Text = "Ngày sinh";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 96);
            this.txtName.MenuManager = this.ribbonControl1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(283, 22);
            this.txtName.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(26, 99);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(37, 16);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Họ tên";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(140, 35);
            this.txtCode.MenuManager = this.ribbonControl1;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(283, 22);
            this.txtCode.TabIndex = 2;
            // 
            // lbCode
            // 
            this.lbCode.Location = new System.Drawing.Point(26, 38);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(76, 16);
            this.lbCode.TabIndex = 1;
            this.lbCode.Text = "Mã nhân viên";
            // 
            // ptrMain
            // 
            this.ptrMain.Location = new System.Drawing.Point(454, 26);
            this.ptrMain.MenuManager = this.ribbonControl1;
            this.ptrMain.Name = "ptrMain";
            this.ptrMain.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptrMain.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ptrMain.Size = new System.Drawing.Size(169, 214);
            this.ptrMain.TabIndex = 0;
            // 
            // dateEditBirth
            // 
            this.dateEditBirth.EditValue = null;
            this.dateEditBirth.Location = new System.Drawing.Point(140, 157);
            this.dateEditBirth.MenuManager = this.ribbonControl1;
            this.dateEditBirth.Name = "dateEditBirth";
            this.dateEditBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirth.Size = new System.Drawing.Size(153, 22);
            this.dateEditBirth.TabIndex = 21;
            // 
            // addPerson
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1171, 749);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addPerson";
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.addPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIsRecog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirth.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl lbName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl lbCode;
        private DevExpress.XtraEditors.PictureEdit ptrMain;
        private DevExpress.XtraEditors.LabelControl lbBirth;
        private DevExpress.XtraEditors.LabelControl lbGender;
        private DevExpress.XtraEditors.ComboBoxEdit cbGender;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lbAddress;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cbIsRecog;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lbPhone;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.MemoEdit memoInfo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddImage;
        private DevExpress.XtraBars.BarButtonItem barbtnSave;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barbtnReset;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.DateEdit dateEditBirth;
    }

}