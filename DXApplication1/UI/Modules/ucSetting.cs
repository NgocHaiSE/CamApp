using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.UI.Modules
{
    public partial class ucSetting : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucSetting _instace;
        public static ucSetting Instance
        {
            get
            {
                if (_instace == null)
                {
                    _instace = new ucSetting();
                }
                return _instace;
            }
        }
        public ucSetting()
        {
            InitializeComponent();
        }
        private void ucSetting_Load(object sender, EventArgs e)
        {
            btnSave.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btnSave.Width, btnSave.Height, 30, 30));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBotton,
            int nWidthEllips,
            int nHeightEllipse
            );
    }
}
