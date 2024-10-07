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
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonStop = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonStart = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.StackPanel)).BeginInit();
            this.StackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNotification)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
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
            this.StackPanel.Location = new System.Drawing.Point(814, 0);
            this.StackPanel.Name = "StackPanel";
            this.StackPanel.Size = new System.Drawing.Size(356, 674);
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
            this.panelNotification.Size = new System.Drawing.Size(350, 618);
            this.StackPanel.SetStretched(this.panelNotification, true);
            this.panelNotification.TabIndex = 2;
            this.panelNotification.UseSkinIndents = true;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.comboBoxEdit1);
            this.sidePanel1.Controls.Add(this.comboBox1);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.simpleButtonStop);
            this.sidePanel1.Controls.Add(this.simpleButtonStart);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(814, 47);
            this.sidePanel1.TabIndex = 7;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEdit1.Location = new System.Drawing.Point(708, 11);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.AutoHeight = false;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "1x1",
            "2x2",
            "3x3",
            "4x4"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(88, 30);
            this.comboBoxEdit1.TabIndex = 14;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.CameraComboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 20);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Camera";
            // 
            // simpleButtonStop
            // 
            this.simpleButtonStop.Location = new System.Drawing.Point(440, 12);
            this.simpleButtonStop.Name = "simpleButtonStop";
            this.simpleButtonStop.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonStop.TabIndex = 9;
            this.simpleButtonStop.Text = "Stop";
            // 
            // simpleButtonStart
            // 
            this.simpleButtonStart.Location = new System.Drawing.Point(340, 12);
            this.simpleButtonStart.Name = "simpleButtonStart";
            this.simpleButtonStart.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonStart.TabIndex = 8;
            this.simpleButtonStart.Text = "Start";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tableLayoutPanel2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 47);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(814, 627);
            this.panelControl2.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 623);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ucViewCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.StackPanel);
            this.Name = "ucViewCam";
            this.Size = new System.Drawing.Size(1170, 674);
            this.Load += new System.EventHandler(this.ucViewCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StackPanel)).EndInit();
            this.StackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNotification)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel StackPanel;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.Layout.StackPanel panelNotification;
        private DevExpress.XtraEditors.SimpleButton simpleButtonStop;
        private DevExpress.XtraEditors.SimpleButton simpleButtonStart;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
