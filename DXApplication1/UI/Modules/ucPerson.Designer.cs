namespace DXApplication1.UI.Modules
{
    partial class ucPerson
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPerson));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsRecog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageLink = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barbtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.BackgroundImage = global::DXApplication1.Properties.Resources.iconmonstr_checkbox_9_240;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 58);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1038, 563);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCode,
            this.colName,
            this.colInfo,
            this.colDate,
            this.colIsRecog,
            this.colImageLink});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Width = 94;
            // 
            // colCode
            // 
            this.colCode.Caption = "Mã nhân viên";
            this.colCode.FieldName = "Mã nhân viên";
            this.colCode.MinWidth = 25;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 94;
            // 
            // colName
            // 
            this.colName.Caption = "Họ tên";
            this.colName.FieldName = "Họ tên";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // colInfo
            // 
            this.colInfo.Caption = "Thông tin  nhân viên";
            this.colInfo.FieldName = "Thông tin";
            this.colInfo.MinWidth = 25;
            this.colInfo.Name = "colInfo";
            this.colInfo.Visible = true;
            this.colInfo.VisibleIndex = 2;
            this.colInfo.Width = 94;
            // 
            // colDate
            // 
            this.colDate.Caption = "Ngày tạo";
            this.colDate.FieldName = "Ngày tạo";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.UnboundDataType = typeof(System.DateTime);
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            this.colDate.Width = 94;
            // 
            // colIsRecog
            // 
            this.colIsRecog.Caption = "Nhận diện";
            this.colIsRecog.FieldName = "Nhận diện";
            this.colIsRecog.MinWidth = 25;
            this.colIsRecog.Name = "colIsRecog";
            this.colIsRecog.Visible = true;
            this.colIsRecog.VisibleIndex = 4;
            this.colIsRecog.Width = 94;
            // 
            // colImageLink
            // 
            this.colImageLink.Caption = "Link ảnh";
            this.colImageLink.FieldName = "Link ảnh";
            this.colImageLink.MinWidth = 25;
            this.colImageLink.Name = "colImageLink";
            this.colImageLink.Width = 94;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnAdd,
            this.barbtnEdit,
            this.barButtonItem3,
            this.skinBarSubItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barbtnDelete});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnDelete)});
            this.bar1.Text = "Tools";
            // 
            // barbtnAdd
            // 
            this.barbtnAdd.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barbtnAdd.Caption = "Thêm";
            this.barbtnAdd.Id = 0;
            this.barbtnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnAdd.ImageOptions.SvgImage")));
            this.barbtnAdd.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.barbtnAdd.Name = "barbtnAdd";
            this.barbtnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnAdd_ItemClick);
            // 
            // barbtnEdit
            // 
            this.barbtnEdit.ActAsDropDown = true;
            this.barbtnEdit.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barbtnEdit.Caption = "Sửa";
            this.barbtnEdit.Hint = "Chỉnh sửa";
            this.barbtnEdit.Id = 1;
            this.barbtnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnEdit.ImageOptions.SvgImage")));
            this.barbtnEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.barbtnEdit.Name = "barbtnEdit";
            this.barbtnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnEdit_ItemClick);
            // 
            // barbtnDelete
            // 
            this.barbtnDelete.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barbtnDelete.Caption = "Xóa";
            this.barbtnDelete.Id = 6;
            this.barbtnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnDelete.ImageOptions.SvgImage")));
            this.barbtnDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.barbtnDelete.Name = "barbtnDelete";
            this.barbtnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1038, 58);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 621);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1038, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 58);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 563);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1038, 58);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 563);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 3;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Lưu";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hủy";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barButtonItem4.Caption = "Sửa";
            this.barButtonItem4.Hint = "Chỉnh sửa";
            this.barButtonItem4.Id = 1;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.Size = new System.Drawing.Size(60, 40);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.ActAsDropDown = true;
            this.barButtonItem5.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.barButtonItem5.Caption = "Sửa";
            this.barButtonItem5.Hint = "Chỉnh sửa";
            this.barButtonItem5.Id = 1;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.Size = new System.Drawing.Size(60, 40);
            // 
            // ucPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucPerson";
            this.Size = new System.Drawing.Size(1038, 641);
            this.Load += new System.EventHandler(this.ucPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barbtnAdd;
        private DevExpress.XtraBars.BarButtonItem barbtnEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barbtnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsRecog;
        private DevExpress.XtraGrid.Columns.GridColumn colImageLink;
    }
}
