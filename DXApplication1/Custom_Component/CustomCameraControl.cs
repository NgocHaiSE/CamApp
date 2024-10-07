using System;
using System.Data;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Vlc.DotNet.Forms;
using DXApplication1.DAO;
using NetMQ;
using DevExpress.XtraPrinting.Native.Properties;

namespace DXApplication1.Custom_Component
{
    public partial class CustomCameraControl : XtraUserControl
    {
        private string link;
        private int id;
        public bool isOn;
        private bool isReceivingFrames = true; 

        public CustomCameraControl()
        {
            InitializeComponent();
            InitComboBox();
        }

        public CustomCameraControl(string link, int id)
        {
            InitializeComponent();
            InitComboBox();
            link = link;
            id = id;
        }

        private void CustomControl1_Load(object sender, EventArgs e)
        {
            StartCameraStream();
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000); 
            StartCameraStream();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }

        private void InitComboBox()
        {
            DataTable data = CameraDAO.Instance.GetAllCameras();
            foreach (DataRow row in data.Rows)
            {
                string cameraLink = row["Đường dẫn"].ToString();
                cbCamera.Items.Add(cameraLink);
            }
        }

        private void StartCameraStream()
        {
            try
            {
                vlcControl1.Play(new Uri(link));
                vlcControl1.Playing += vlcControl1_Playing;
                vlcControl1.Stopped += vlcControl1_Stopped;
                CheckFrameReception(); 
            }
            catch (Exception ex)
            {
                ShowWarningImage();
                MessageBox.Show($"Error starting camera stream: {ex.Message}");
            }
        }

        private async void CheckFrameReception()
        {
            await Task.Delay(5000); 
            if (!isReceivingFrames)
            {
                ShowWarningImage(); 
            }
        }

        private void vlcControl1_Playing(object sender, Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    btnPlay.Enabled = false;
                    btnStop.Enabled = true;
                }));
            }
            else
            {
                btnPlay.Enabled = false;
                btnStop.Enabled = true;
            }
        }
        private void vlcControl1_Stopped(object sender, Vlc.DotNet.Core.VlcMediaPlayerStoppedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    btnPlay.Enabled = true;
                    btnStop.Enabled = false;
                }));
            }
            else
            {
                btnPlay.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void ShowWarningImage()
        {
            vlcControl1.Visible = false;
        }

        public static async Task<bool> CheckUrl(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url));
                    return response.IsSuccessStatusCode; 
                }
            }
            catch
            {
                return false; 
            }
        }

        private async void btnCheckLink_Click(object sender, EventArgs e)
        {
            bool isValid = await CheckUrl(link);
            if (isValid)
            {
                MessageBox.Show("URL is valid. Calling API to turn on the camera.");
            }
            else
            {
                MessageBox.Show("Camera URL is invalid or not reachable.");
            }
        }

        private async void btnTurn_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response;
                    if (!isOn)
                    {
                        response = await client.GetAsync($"http://localhost:8000/start/{id}");
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Camera {id} đã được bật!");
                            isOn = true; 
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi bật camera!");
                        }
                    }
                    else
                    {
                        response = await client.GetAsync($"http://localhost:8000/stop/{id}");
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show($"Camera {id} đã được tắt!");
                            isOn = false; 
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi tắt camera!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
        }
    }
}
