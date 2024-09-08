using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DesignUI
{
    public class DesignButton
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
           int nLeft,
           int nTop,
           int nRight,
           int nBotton,
           int nWidthEllips,
           int nHeightEllipse
           );
    }
}
