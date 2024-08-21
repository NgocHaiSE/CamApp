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
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.CameraPanel = new System.Windows.Forms.Panel();
            this.CameraComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraComboBox.Properties)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.stackPanel1.Appearance.Options.UseBackColor = true;
            this.stackPanel1.Controls.Add(this.labelControl1);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.stackPanel1.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel1.Location = new System.Drawing.Point(749, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(249, 627);
            this.stackPanel1.TabIndex = 0;
            // 
            // CameraPanel
            // 
            this.CameraPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraPanel.Location = new System.Drawing.Point(1, 33);
            this.CameraPanel.Name = "CameraPanel";
            this.CameraPanel.Size = new System.Drawing.Size(746, 594);
            this.CameraPanel.TabIndex = 5;
            // 
            // CameraComboBox
            // 
            this.CameraComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraComboBox.EditValue = "2x2";
            this.CameraComboBox.Location = new System.Drawing.Point(651, 6);
            this.CameraComboBox.Name = "CameraComboBox";
            this.CameraComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CameraComboBox.Properties.Items.AddRange(new object[] {
            "1x1",
            "2x2",
            "3x3",
            "4x4"});
            this.CameraComboBox.Size = new System.Drawing.Size(75, 22);
            this.CameraComboBox.TabIndex = 6;
            this.CameraComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanel1.Controls.Add(this.simpleButton1);
            this.sidePanel1.Controls.Add(this.CameraComboBox);
            this.sidePanel1.Location = new System.Drawing.Point(3, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(740, 36);
            this.sidePanel1.TabIndex = 7;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(4, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 33);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Thêm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(94, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thông báo";
            // 
            // ucViewCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.CameraPanel);
            this.Controls.Add(this.stackPanel1);
            this.Name = "ucViewCam";
            this.Size = new System.Drawing.Size(998, 627);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraComboBox.Properties)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private System.Windows.Forms.Panel CameraPanel;
        private DevExpress.XtraEditors.ComboBoxEdit CameraComboBox;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
