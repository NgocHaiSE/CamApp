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
using System.Threading;
using DXApplication1.DesignUI;
using CustomControls;
using DXApplication1.Custom_Component;
using System.Windows.Media.Media3D;

namespace DXApplication1.UI.Modules
{
    public partial class ucViewCam : DevExpress.XtraEditors.XtraUserControl
    {
        private static readonly HttpClient client = new HttpClient();
        private List<CustomCameraControl> cameraControls = new List<CustomCameraControl>();
        private List<VlcControl> vlcControls = new List<VlcControl>();
        private List<String> links = new List<String>();
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
            StartAll();
        }

        public ucViewCam()
        {
            InitializeComponent();
        }

        private void StartSubscriber(string cameraid, PictureBox pictureBox)
        {
            using (var subscriber = new SubscriberSocket())
            {
                int customPort = 8000; 
                customPort += int.Parse(cameraid);
                subscriber.Connect($"tcp://localhost:{customPort}");

                subscriber.Subscribe("newframe");

                while (true)
                {
                    string receivedTopic = subscriber.ReceiveFrameString();
                    byte[] frameBytes = subscriber.ReceiveFrameBytes();

                    using (var ms = new MemoryStream(frameBytes))
                    {
                        var img = Image.FromStream(ms);
                        this.Invoke((MethodInvoker)delegate
                        {
                            pictureBox.Image = img;
                        });
                    }
                }
            }
        }

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
                    break;
                case "2x2":
                    numCameras = 4;
                    break;
                case "3x3":
                    numCameras = 9;
                    break;
                case "4x4":
                    numCameras = 16;
                    break;
            }

            int columnCount = (int)Math.Sqrt(numCameras);
            int rowCount = (int)Math.Ceiling((double)numCameras / columnCount);

            tableLayoutPanel2.ColumnCount = columnCount;
            tableLayoutPanel2.RowCount = rowCount;

            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel2.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / rowCount));
            }

            int maxCamerasToShow = Math.Min(numCameras, links.Count);
            await InitializeCameraControls(maxCamerasToShow);
        }


        private async Task InitializeCameraControls(int numCameras)
        {
            tableLayoutPanel2.Controls.Clear();
            cameraControls.Clear();
            int maxCamerasToShow = Math.Min(numCameras, links.Count);

            for (int i = 0; i < maxCamerasToShow; i++)
            {
                CustomCameraControl cameraControl = new CustomCameraControl(links[i], cameraIds[i]);
                cameraControl.Dock = DockStyle.Fill;

                cameraControls.Add(cameraControl);
                tableLayoutPanel2.Controls.Add(cameraControl, i % tableLayoutPanel2.ColumnCount, i / tableLayoutPanel2.ColumnCount);

                // Start the camera for each CameraControl
                //cameraControl.StartCamera(links[i]);
                //await StartCameraAsync(cameraIds[i]);
            }
            //for (int i = 0; i < maxCamerasToShow; i++)
            //{
            //    cameraControls[i].StartCamera(links[i]);

            //}
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

        private async Task StartAll()
        {
            try
            {
                var url = $"http://localhost:8000/startall";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Started all cameras successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
