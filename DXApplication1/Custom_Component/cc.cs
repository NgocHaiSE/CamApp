using DXApplication1.DAO;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using DXApplication1;

namespace CustomControls
{
    public partial class cc : Control
    {
        private VlcControl vlcControl;
        private ToolStrip toolStrip;
        private ToolStripComboBox cmbCameraSelection;
        private ToolStripButton btnMaximize;
        private ToolStripButton btnMinimize;
        private ToolStripButton btnToggleCamera;
        private bool isCameraOn = true;

        public cc()
        {
            InitializeComponent();
            InitializeVlc();
            InitializeToolbar();
            InitializeComboBox();

        }

        private void InitializeComboBox()
        {
            DataTable data = CameraDAO.Instance.GetAllCameras();
            foreach (DataRow row in data.Rows)
            {
                string cameraLink = row["Đường dẫn"].ToString(); 
                cmbCameraSelection.Items.Add(cameraLink); 
            }
        }

        private void InitializeVlc()
        {
            vlcControl = new VlcControl
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Black
            };

            var libDirectory = new DirectoryInfo(@"C:\Program Files\VideoLAN\VLC");
            vlcControl.VlcLibDirectory = libDirectory;
            vlcControl.EndInit();

            this.Controls.Add(vlcControl);
            vlcControl.Play(new Uri(@"C:\Users\ProDHai\Downloads\Download.mp4"));
        }

        private void InitializeToolbar()
        {
            toolStrip = new ToolStrip
            {
                Height = 50, 
                BackColor = Color.Black,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                //Visible = false
            };

            cmbCameraSelection = new ToolStripComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 200,
                Font = new Font("Arial", 12)
            };

            btnMaximize = new ToolStripButton
            {
                Image = DXApplication1.Properties.Resources.Maximize,
                BackColor = Color.LightGreen,
                Size = new Size(50, 50)
            };
            btnMaximize.Click += btnMaximize_Click;

            btnMinimize = new ToolStripButton
            {
                Image = DXApplication1.Properties.Resources.Minimize,
                BackColor = Color.LightCoral,
                Size = new Size(50, 50)
            };
            btnMinimize.Click += btnMinimize_Click;  

            btnToggleCamera = new ToolStripButton
            {
                Image = DXApplication1.Properties.Resources.Power_On_Off,
                BackColor = Color.LightSkyBlue,
                Size = new Size(50, 50)
            };
            btnToggleCamera.Click += btnToggleCamera_Click;

            toolStrip.Items.Add(new ToolStripLabel("Camera") { Font = new Font("Arial", 12) });
            toolStrip.Items.Add(cmbCameraSelection);
            toolStrip.Items.Add(btnMaximize);
            toolStrip.Items.Add(btnMinimize);
            toolStrip.Items.Add(btnToggleCamera);

            this.Controls.Add(toolStrip);
        }

        #region Maximize

        private Size originalSize;
        private Point originalLocation;
        private bool isMaximized = false;

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                originalSize = this.Size;
                originalLocation = this.Location;
                this.Dock = DockStyle.Fill;
                isMaximized = true;
                btnMaximize.Enabled = false;
                btnMinimize.Enabled = true;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.Dock = DockStyle.None;
                this.Size = originalSize;
                this.Location = originalLocation;
                isMaximized = false;

                btnMaximize.Enabled = true;
                btnMinimize.Enabled = false;
            }
        }

        #endregion

        private void btnToggleCamera_Click(object sender, EventArgs e)
        {
            if (!isCameraOn)
            {
                PlayStream(@"C:\Users\ProDHai\Downloads\Download.mp4");
                isCameraOn = true;
            }
            else
            {
                StopStream();

                isCameraOn = false;
            }
        }

        public void PlayStream(string streamUrl)
        {
            if (vlcControl != null && !string.IsNullOrEmpty(streamUrl))
            {
                vlcControl.Play(new Uri(streamUrl));
            }
        }

        public void StopStream()
        {
            if (vlcControl != null)
            {
                vlcControl.Stop();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            using (var pen = new Pen(Color.Black, 2))
            {
                pe.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}
