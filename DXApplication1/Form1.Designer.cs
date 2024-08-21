namespace DXApplication1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.fluentDesignFormContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElementView = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementNoti = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementPer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSetting = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementCam = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementUser = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer
            // 
            this.fluentDesignFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer.Location = new System.Drawing.Point(60, 39);
            this.fluentDesignFormContainer.Name = "fluentDesignFormContainer";
            this.fluentDesignFormContainer.Size = new System.Drawing.Size(1242, 632);
            this.fluentDesignFormContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowSmoothScrolling = false;
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElementView,
            this.accordionControlElementNoti,
            this.accordionControlElementPer,
            this.accordionControlElementCam,
            this.accordionControlElementUser,
            this.accordionControlElementSetting});
            this.accordionControl1.Location = new System.Drawing.Point(0, 39);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(60, 632);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElementView
            // 
            this.accordionControlElementView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementView.ImageOptions.Image")));
            this.accordionControlElementView.Name = "accordionControlElementView";
            this.accordionControlElementView.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementView.Text = "Phát trực tiếp";
            this.accordionControlElementView.Click += new System.EventHandler(this.accordionControlElementView_Click);
            // 
            // accordionControlElementNoti
            // 
            this.accordionControlElementNoti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementNoti.ImageOptions.Image")));
            this.accordionControlElementNoti.Name = "accordionControlElementNoti";
            this.accordionControlElementNoti.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementNoti.Text = "Thông báo";
            this.accordionControlElementNoti.Click += new System.EventHandler(this.accordionControlElementNoti_Click);
            // 
            // accordionControlElementPer
            // 
            this.accordionControlElementPer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementPer.ImageOptions.Image")));
            this.accordionControlElementPer.Name = "accordionControlElementPer";
            this.accordionControlElementPer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementPer.Text = "Nhân viên";
            this.accordionControlElementPer.Click += new System.EventHandler(this.accordionControlElementUser_Click);
            // 
            // accordionControlElementSetting
            // 
            this.accordionControlElementSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElementSetting.ImageOptions.Image")));
            this.accordionControlElementSetting.Name = "accordionControlElementSetting";
            this.accordionControlElementSetting.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementSetting.Text = "Cài đặt";
            this.accordionControlElementSetting.Click += new System.EventHandler(this.accordionControlElementSetting_Click);
            // 
            // accordionControlElementCam
            // 
            this.accordionControlElementCam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementCam.ImageOptions.SvgImage")));
            this.accordionControlElementCam.Name = "accordionControlElementCam";
            this.accordionControlElementCam.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementCam.Text = "Camera";
            this.accordionControlElementCam.Click += new System.EventHandler(this.accordionControlElementCam_Click);
            // 
            // accordionControlElementUser
            // 
            this.accordionControlElementUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElementUser.ImageOptions.SvgImage")));
            this.accordionControlElementUser.Name = "accordionControlElementUser";
            this.accordionControlElementUser.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElementUser.Text = "Tài khoản";
            this.accordionControlElementUser.Click += new System.EventHandler(this.accordionControlElementUser_Click_1);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1302, 39);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 671);
            this.ControlContainer = this.fluentDesignFormContainer;
            this.Controls.Add(this.fluentDesignFormContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormMain.IconOptions.SvgImage")));
            this.Name = "FormMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "FCam";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementView;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementNoti;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementPer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSetting;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementCam;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementUser;
    }
}

