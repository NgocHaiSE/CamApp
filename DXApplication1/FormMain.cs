using DevExpress.XtraBars;
using DevExpress.DXperience.Demos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DXApplication1.UI.Modules;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using DXApplication1.Utils;
using DXApplication1.UI.Login;

namespace DXApplication1
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public FormMain(string user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            barHeaderItem1.Caption = "Xin chào: " + user; 
        }
        private void accordionControlPerson_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer.Controls.Contains(ucPerson2.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucPerson2.Instance);
                ucPerson2.Instance.Dock = DockStyle.Fill;
                ucPerson2.Instance.BringToFront();
            }
            else
            {
                ucPerson2.Instance.BringToFront();
            }
        }

        private void accordionControlElementView_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer.Controls.Contains(ucViewCam.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucViewCam.Instance);
                ucViewCam.Instance.Dock = DockStyle.Fill;
                ucViewCam.Instance.BringToFront();
            }
            else
            {
                ucViewCam.Instance.BringToFront();
            }
        }

        private void accordionControlElementNoti_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer.Controls.Contains(ucNotification.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucNotification.Instance);
                ucNotification.Instance.Dock = DockStyle.Fill;
                ucNotification.Instance.BringToFront();
            }
            else
            {
                ucNotification.Instance.BringToFront();
            }
        }

        private void accordionControlElementCam_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer.Controls.Contains(ucCamControl.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucCamControl.Instance);
                ucCamControl.Instance.Dock = DockStyle.Fill;
                ucCamControl.Instance.BringToFront();
            }
            else
            {
                ucCamControl.Instance.BringToFront();
            }
        }

        private void accordionControlElementUser_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer.Controls.Contains(ucUserControl.Instance))
            {
                fluentDesignFormContainer.Controls.Add(acUser.Instance);
                acUser.Instance.Dock = DockStyle.Fill;
                acUser.Instance.BringToFront();
            }
            else
            {
                acUser.Instance.BringToFront();
            }
        }

        private void accordionControlElementSetting_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer.Controls.Contains(ucSetting.Instance))
            {
                fluentDesignFormContainer.Controls.Add(ucSetting.Instance);
                ucSetting.Instance.Dock = DockStyle.Fill;
                ucSetting.Instance.BringToFront();
            }
            else
            {
                ucSetting.Instance.BringToFront();
            }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Login loginForm = new Login();
                loginForm.Show();

                this.Close();
            }
        }
    }
}
