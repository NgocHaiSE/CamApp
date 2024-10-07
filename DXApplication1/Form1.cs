using DXApplication1.UI.ChildForms;
using Mysqlx.Crud;
using NetMQ.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetMQ;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() => StartSubscriber("0", pictureBox1)); // Nhận dữ liệu từ camera 0
            Task.Run(() => StartSubscriber("1", pictureBox2));
            Task.Run(() => StartSubscriber("2", pictureBox3));
            Task.Run(() => StartSubscriber("3", pictureBox4));
        }

        private void StartSubscriber(string topic, PictureBox pictureBox)
        {
            using (var subscriber = new SubscriberSocket())
            {
                subscriber.Connect("tcp://localhost:5555");
                subscriber.Subscribe(topic);

                while (true)
                {
                    string receivedTopic = subscriber.ReceiveFrameString();
                    byte[] frameBytes = subscriber.ReceiveFrameBytes();

                    using (var ms = new MemoryStream(frameBytes))
                    {
                        var img = Image.FromStream(ms);
                        this.Invoke((MethodInvoker)delegate {
                            pictureBox.Image = img;
                        });
                    }
                }
            }
        }
    }
}
