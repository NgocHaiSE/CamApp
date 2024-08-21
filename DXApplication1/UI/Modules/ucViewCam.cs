using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AForge.Video;
using AForge.Video.DirectShow;

namespace DXApplication1.UI.Modules
{
    public partial class ucViewCam : DevExpress.XtraEditors.XtraUserControl
    {
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

    }
}
