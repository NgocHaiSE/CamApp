namespace DXApplication1
{
    partial class Test
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
            this.customControl11 = new DXApplication1.Custom_Component.CustomCameraControl();
            this.SuspendLayout();
            // 
            // customControl11
            // 
            this.customControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customControl11.Location = new System.Drawing.Point(0, 0);
            this.customControl11.Name = "customControl11";
            this.customControl11.Size = new System.Drawing.Size(985, 708);
            this.customControl11.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 708);
            this.Controls.Add(this.customControl11);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Component.CustomCameraControl customControl11;
    }
}