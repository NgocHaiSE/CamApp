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

namespace DXApplication1
{
    public partial class FormMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Dictionary<string, XtraUserControl> userControls = new Dictionary<string, XtraUserControl>();
        public FormMain()
        {
            InitializeComponent();
        }
        private void ShowControl(string controlName)
        {
            XtraUserControl control;
            //if(userControls == null)
            //{
            //    // Create the control if it doesn't exist and add it to the dictionary
            //    switch (controlName)
            //    {
            //        case "accordionControlElementView":
            //            control = new ucViewCam();
            //            break;
            //        case "accordionControlElementCam":
            //            control = new ucCamControl();
            //            break;
            //        case "accordionControlElementNoti":
            //            control = new ucNotification();
            //            break;
            //        case "accordionControlElementUser":
            //            control = new ucUserControl();
            //            break;
            //        case "accordionControlElementSetting":
            //            control = new ucSetting();
            //            break;
            //        default:
            //            return;
            //    }
            //    userControls[controlName] = control;
            //}
            //else
           if ( !userControls.TryGetValue(controlName, out control))
            {
                // Create the control if it doesn't exist and add it to the dictionary
                switch (controlName)
                {
                    case "accordionControlElementView":
                        control = new ucViewCam();
                        break;
                    case "accordionControlElementCam":
                        control = new ucCamControl();
                        break;
                    case "accordionControlElementNoti":
                        control = new ucNotification();
                        break;
                    case "accordionControlElementUser":
                        control = new ucUserControl();
                        break;
                    case "accordionControlElementSetting":
                        control = new ucSetting();
                        break;
                    case "accordionControlElementPer":
                        control = new ucPerson();
                        break;
                    default:
                        return;
                }
                userControls[controlName] = control;
            }

            // Clear current content
            fluentDesignFormContainer.Controls.Clear();

            // Set the control as a child of the container
            control.Dock = DockStyle.Fill;
            fluentDesignFormContainer.Controls.Add(control);
            control.Show();
        }

        private void accordionControlElementView_Click(object sender, EventArgs e)
        {
            AccordionControlElement element = sender as AccordionControlElement;
            if (element != null)
            {
                ShowControl(element.Name);
            }
        }

        private void accordionControlElementCam_Click(object sender, EventArgs e)
        {
            AccordionControlElement element = sender as AccordionControlElement;
            if (element != null)
            {
                ShowControl(element.Name);
            }
        }

        private void accordionControlElementNoti_Click(object sender, EventArgs e)
        {
            AccordionControlElement element = sender as AccordionControlElement;
            if (element != null)
            {
                ShowControl(element.Name);
            }
        }

        private void accordionControlElementUser_Click(object sender, EventArgs e)
        {
            AccordionControlElement element = sender as AccordionControlElement;
            if (element != null)
            {
                ShowControl(element.Name);
            }
        }

        private void accordionControlElementSetting_Click(object sender, EventArgs e)
        {
            AccordionControlElement element = sender as AccordionControlElement;
            if (element != null)
            {
                ShowControl(element.Name);
            }
        }

        private void accordionControlElementUser_Click_1(object sender, EventArgs e)
        {
            AccordionControlElement element = sender as AccordionControlElement;
            if (element != null)
            {
                ShowControl(element.Name);
            }
        }
    }
}
