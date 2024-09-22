using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AForge.Video;
using AForge.Video.DirectShow;
using DXApplication1.Entity;
using System.Threading.Tasks;
using NetMQ;
using NetMQ.Sockets;
using System.IO;
using System.Net.Http;
using Vlc.DotNet.Forms;
using System.Data;
using DXApplication1.DAO;

namespace DXApplication1.UI.Modules
{
    public partial class ucViewCam : DevExpress.XtraEditors.XtraUserControl
    {
        private static readonly HttpClient client = new HttpClient();
        private List<VlcControl> vlcControls = new List<VlcControl>();
        List<String> links = new List<String>();
        private List<int> cameraIds = new List<int>();

        private static ucViewCam _instace;

        public static ucViewCam Instance
        {
            get
            {
                if (_instace == null)
                {
                    _instace = new ucViewCam();
                }
                return _instace;
            }
        }

        private void ucViewCam_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComboBox()
        {
            comboBoxEdit1.Properties.Items.Add("1x1");
            comboBoxEdit1.Properties.Items.Add("2x2");
            comboBoxEdit1.Properties.Items.Add("3x3");
            comboBoxEdit1.Properties.Items.Add("4x4");
        }

        public ucViewCam()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        //MJPEGStream stream;

        //void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        //{
        //    Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
        //    pictureBoxCamera.Image = bmp;
        //}

        private async void CameraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = CameraDAO.Instance.GetAllCameras();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                int cameraId = Convert.ToInt32(data.Rows[i]["ID"]);
                string link = data.Rows[i]["Đường dẫn"].ToString();
                links.Add(link);
                cameraIds.Add(cameraId);
            }
            string selectedSize = comboBoxEdit1.SelectedItem.ToString();
            int numCameras = 2; 

            switch (selectedSize)
            {
                case "1x1":
                    numCameras = 1;
                    tableLayoutPanel1.ColumnCount = 1;
                    tableLayoutPanel1.RowCount = 1;
                    break;
                case "2x2":
                    numCameras = 4;
                    tableLayoutPanel1.ColumnCount = 2;
                    tableLayoutPanel1.RowCount = 2;
                    break;
                case "3x3":
                    numCameras = 9;
                    tableLayoutPanel1.ColumnCount = 3;
                    tableLayoutPanel1.RowCount = 3;
                    break;
                case "4x4":
                    numCameras = 9;
                    tableLayoutPanel1.ColumnCount = 3;
                    tableLayoutPanel1.RowCount = 3;
                    break;
            }
            int maxCamerasToShow = Math.Min(numCameras, links.Count); 

            await InitializeVlcControls(maxCamerasToShow);
        }
        private async Task StartCameraAsync(int cameraId)
        {
            try
            {
                string url = $"http://localhost:8000/start/{cameraId}";
                HttpResponseMessage response = await client.GetAsync(url); 

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Camera {cameraId} đã được khởi động thành công."); 
                }
                else
                {
                    MessageBox.Show($"Không thể khởi động camera {cameraId}. Lỗi: {response.StatusCode}"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}"); 
            }
        }

        private async Task InitializeVlcControls(int numCameras)
        {
            tableLayoutPanel1.Controls.Clear();
            vlcControls.Clear();
            var libDirectory = new System.IO.DirectoryInfo(@"C:\Program Files\VideoLAN\VLC");

            int maxCamerasToShow = Math.Min(numCameras, links.Count); 

            for (int i = 0; i < maxCamerasToShow; i++)
            {
                var vlcControl = new VlcControl
                {
                    Dock = DockStyle.Fill,  
                    VlcLibDirectory = libDirectory  
                };
                vlcControl.EndInit();

                vlcControls.Add(vlcControl); 
                tableLayoutPanel1.Controls.Add(vlcControl, i % tableLayoutPanel1.ColumnCount, i / tableLayoutPanel1.ColumnCount); // Add control to layout

                await StartCameraAsync(cameraIds[i]);
            }

            PlayCameras();
        }

        public void PlayCameras()
        {
            for (int i = 0; i < vlcControls.Count; i++)
            {
                vlcControls[i].Play(new Uri(links[i])); 
            }
        }

        private async Task StartCameraProcess(string cameraId)
        {
            try
            {
                var url = $"http://localhost:8000/start/{cameraId}";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Started camera {cameraId} successfully!");
                }
                else
                {
                    MessageBox.Show($"Failed to start camera {cameraId}: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task StopCameraProcess(string cameraId)
        {
            try
            {
                var url = $"http://localhost:8000/stop/{cameraId}";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Stopped camera {cameraId} successfully!");
                }
                else
                {
                    MessageBox.Show($"Failed to stop camera {cameraId}: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void buttonStartCamera_Click(object sender, EventArgs e)
        {

        }

        private void buttonStopCamera_Click(object sender, EventArgs e)
        {
            foreach (var vlcControl in vlcControls)
            {
                vlcControl.Stop(); 
            }
        }

    }
}
