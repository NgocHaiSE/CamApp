using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace DXApplication1.DesignUI
{
    public class CameraControl : PanelControl
    {
        public VlcControl vlcControl;
        private PanelControl toolbar;
        private SimpleButton btnMinimize, btnMaximize, btnTurnOff;
        public CameraControl()
        {
            InitializeComponents();
        }
        public CameraControl(string link)
        {
            InitializeComponents();
            this.vlcControl.Play(new Uri(link));
        }
        private void InitializeComponents()
        {
            vlcControl = new VlcControl();
            vlcControl.Dock = DockStyle.Fill;
            var libDirectory = new System.IO.DirectoryInfo(@"C:\Program Files\VideoLAN\VLC");
            vlcControl.VlcLibDirectory = libDirectory;
            this.Controls.Add(vlcControl);

            toolbar = new PanelControl
            {
                Dock = System.Windows.Forms.DockStyle.Bottom,
                BackColor = Color.Transparent,
                Visible = true
            };

            btnMinimize = new SimpleButton
            {
                Dock = DockStyle.Left,
                Width = 32,
                Height = 32,
                ImageOptions = { Image = Image.FromFile(@"D:\C#\AppCamera\DXApplication1\DXApplication1\DXApplication1\Resources\Icon\Minimize.png") }
            };

            btnMaximize = new SimpleButton
            {
                Dock = DockStyle.Left,
                Width = 32,
                Height = 32,
                ImageOptions = { Image = Image.FromFile(@"D:\C#\AppCamera\DXApplication1\DXApplication1\DXApplication1\Resources\Icon\Maximize.png") }
            };

            btnTurnOff = new SimpleButton
            {
                Dock = DockStyle.Left,
                Width = 32,
                Height = 32,
                ImageOptions = { Image = Image.FromFile(@"D:\C#\AppCamera\DXApplication1\DXApplication1\DXApplication1\Resources\Icon\Power-On-Off.png") }
            };

            toolbar.Controls.Add(btnMinimize);
            toolbar.Controls.Add(btnMaximize);
            toolbar.Controls.Add(btnTurnOff);
            this.Controls.Add(toolbar);

            vlcControl.MouseEnter += (sender, e) => toolbar.Visible = true;
            vlcControl.MouseLeave += (sender, e) => toolbar.Visible = false;
        }

        public void StartCamera(string rtspLink)
        {
            if (this.vlcControl != null)
            {
                this.vlcControl.Play(new Uri(rtspLink));
            }
            else
            {
                MessageBox.Show("VLC control chưa được khởi tạo.");
            };
        }

        public void StopCamera()
        {
            vlcControl.Stop();
        }

    }

}
