using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Entity
{
    public class NotificationEventArgs : EventArgs
    {
        public string EmployeeName { get; }
        public string CameraName { get; }
        public DateTime Time { get; }
        public int Accuracy { get; }
        //public Image Image { get; }

        public NotificationEventArgs(string employeeName, string cameraName, DateTime time, int accuracy)
        {
            EmployeeName = employeeName;
            CameraName = cameraName;
            Time = time;
            Accuracy = accuracy;
            //Image = image;
        }
    }
}
