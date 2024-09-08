using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AForge.Video;
using AForge.Video.DirectShow;
using DXApplication1.Entity;
using Emgu.CV;
using Emgu.CV.Structure;

namespace DXApplication1.UI.Modules
{
    public partial class ucViewCam : DevExpress.XtraEditors.XtraUserControl
    {
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
        private FilterInfoCollection videoDevices; //filter
        private VideoCaptureDevice videoSource; //device

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        private void ucViewCam_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += Device_NewFrame;
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("Không tìm thấy camera!");
            }
        }
        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            using (Image<Gray, byte> grayFrame = new Image<Gray, byte>(bitmap))
            {
                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayFrame, 1.1, 5, new Size(30, 30));

                if (rectangles.Length > 0)
                {
                    foreach (Rectangle rectangle in rectangles)
                    {
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            using (Pen pen = new Pen(Color.Red, 2))
                            {
                                graphics.DrawRectangle(pen, rectangle);
                            }
                        }
                    }
                }
            }

            pictureBoxCamera.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private ucNotification notificationControl;

        public ucViewCam(ucNotification notificationControl)
        {
            InitializeComponent();
        }

        private void OnNotificationAdded(object sender, NotificationEventArgs e)
        {
            CreateNotification(e);
        }
        public ucViewCam()
        {
            InitializeComponent();

        }

        string[] rtspUrls = {
                "rtsp://your_rtsp_url_1",
                "rtsp://your_rtsp_url_2",
                "rtsp://your_rtsp_url_3",
                "rtsp://your_rtsp_url_4"
            };

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CameraPanel.Controls.Clear();
            // Tạo lưới camera mới dựa trên lựa chọn của người dùng
            switch (CameraComboBox.SelectedItem.ToString())
            {
                case "1x1":
                    CreateCameraGrid(CameraPanel, 1, 1);
                    break;
                case "3x3":
                    CreateCameraGrid(CameraPanel, 3, 3);
                    break;
                case "2x2":
                    CreateCameraGrid(CameraPanel, 2, 2);
                    break;
                case "4x4":
                    CreateCameraGrid(CameraPanel, 4, 4);
                    break;
            }

        }
        private void CreateCameraGrid(Panel panel, int rows, int columns)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = rows,
                ColumnCount = columns,
                AutoSize = false,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            for (int row = 0; row < rows; row++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));
                for (int col = 0; col < columns; col++)
                {
                    if (row == 0)
                    {
                        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columns));
                    }
                    // Thêm các control hiển thị camera, ở đây là các PictureBox để minh họa
                    PictureBox cameraBox = new PictureBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Dock = DockStyle.Fill,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = GetPlaceholderImage() // Thay thế bằng stream video thực tế
                    };
                    tableLayoutPanel.Controls.Add(cameraBox, col, row);
                }
            }

            panel.Controls.Add(tableLayoutPanel);
        }
        private Image GetPlaceholderImage()
        {
            // Tạo một ảnh placeholder đơn giản
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Black);
                g.DrawString("Camera", new Font("Arial", 10), Brushes.White, new PointF(10, 40));
            }
            return bmp;
        }
        private void CreateNotification(NotificationEventArgs e)
        {
            Label notificationLabel = new Label
            {
                Text = $"{e.Time:dd-MM-yyyy HH:mm:ss}\n{e.EmployeeName} đã xuất hiện tại {e.CameraName}",
                AutoSize = true,
                Padding = new Padding(2),
                Margin = new Padding(3),
                BackColor = Color.LightSkyBlue,
                BorderStyle = BorderStyle.FixedSingle
            };

            panelNotification.Controls.Add(notificationLabel);
            panelNotification.Controls.SetChildIndex(notificationLabel, 0);

            panelNotification.ScrollControlIntoView(notificationLabel);
        }

    }
}
