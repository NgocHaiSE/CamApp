namespace DXApplication1.UI.Modules
{
    partial class acUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acUser));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageUser = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageRole = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonAdd,
            this.barButtonItemDelete,
            this.barButtonItemEdit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageUser,
            this.ribbonPageRole});
            this.ribbon.Size = new System.Drawing.Size(953, 183);
            // 
            // barButtonAdd
            // 
            this.barButtonAdd.Caption = "Thêm tài khoản";
            this.barButtonAdd.Id = 1;
            this.barButtonAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonAdd.ImageOptions.SvgImage")));
            this.barButtonAdd.Name = "barButtonAdd";
            this.barButtonAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAdd_ItemClick);
            // 
            // barButtonItemDelete
            // 
            this.barButtonItemDelete.Caption = "Xóa tài khoản";
            this.barButtonItemDelete.Id = 2;
            this.barButtonItemDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemDelete.ImageOptions.SvgImage")));
            this.barButtonItemDelete.Name = "barButtonItemDelete";
            // 
            // barButtonItemEdit
            // 
            this.barButtonItemEdit.Caption = "Chỉnh sửa";
            this.barButtonItemEdit.Id = 3;
            this.barButtonItemEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemEdit.ImageOptions.SvgImage")));
            this.barButtonItemEdit.Name = "barButtonItemEdit";
            // 
            // ribbonPageUser
            // 
            this.ribbonPageUser.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageUser.Name = "ribbonPageUser";
            this.ribbonPageUser.Text = "Tài khoản";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonAdd);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Thao tác";
            // 
            // ribbonPageRole
            // 
            this.ribbonPageRole.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPageRole.Name = "ribbonPageRole";
            this.ribbonPageRole.Text = "Phân quyền";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 183);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(953, 459);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnUsername,
            this.gridColumnAdmin,
            this.gridColumnManager,
            this.gridColumnStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "Id";
            this.gridColumnID.MinWidth = 25;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Visible = true;
            this.gridColumnID.VisibleIndex = 0;
            this.gridColumnID.Width = 54;
            // 
            // gridColumnUsername
            // 
            this.gridColumnUsername.Caption = "Tài khoản";
            this.gridColumnUsername.FieldName = "Username";
            this.gridColumnUsername.MinWidth = 25;
            this.gridColumnUsername.Name = "gridColumnUsername";
            this.gridColumnUsername.Visible = true;
            this.gridColumnUsername.VisibleIndex = 1;
            this.gridColumnUsername.Width = 177;
            // 
            // gridColumnAdmin
            // 
            this.gridColumnAdmin.Caption = "Admin";
            this.gridColumnAdmin.FieldName = "IsAdmin";
            this.gridColumnAdmin.MinWidth = 25;
            this.gridColumnAdmin.Name = "gridColumnAdmin";
            this.gridColumnAdmin.Visible = true;
            this.gridColumnAdmin.VisibleIndex = 2;
            this.gridColumnAdmin.Width = 151;
            // 
            // gridColumnManager
            // 
            this.gridColumnManager.Caption = "Quản lý";
            this.gridColumnManager.FieldName = "IsManager";
            this.gridColumnManager.MinWidth = 25;
            this.gridColumnManager.Name = "gridColumnManager";
            this.gridColumnManager.Visible = true;
            this.gridColumnManager.VisibleIndex = 3;
            this.gridColumnManager.Width = 151;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Kích hoạt";
            this.gridColumnStatus.FieldName = "IsActive";
            this.gridColumnStatus.MinWidth = 25;
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.VisibleIndex = 4;
            this.gridColumnStatus.Width = 158;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // acUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "acUser";
            this.Size = new System.Drawing.Size(953, 642);
            this.Load += new System.EventHandler(this.acUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageUser;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageRole;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUsername;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnManager;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
