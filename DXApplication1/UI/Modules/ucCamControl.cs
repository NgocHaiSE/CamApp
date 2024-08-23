using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DXApplication1.UI.ChildForms;
using DXApplication1.Utils;
using DXApplication1.DAO;
using DXApplication1.DTO;

namespace DXApplication1.UI.Modules
{
    public partial class ucCamControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ucCamControl()
        {
            InitializeComponent();
        }

        #region Method
        private void ucCamControl_Load(object sender, EventArgs e)
        {
            LoadCameraData();
        }

        private void LoadCameraData()
        {
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetCameraInfo");
            if (data != null)
            {
                gridControl1.DataSource = data;
                gridView1.BestFitColumns();
            }
            else
            {
                MessageBox.Show("Hiện không tìm thấy thông tin camera nào!");
            }
        }
        #endregion


        #region Events
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addCam addCam = new addCam();
            addCam.CameraAdded += AddCam_CameraAdded;
            addCam.Show();
        }

        private void AddCam_CameraAdded(object sender, EventArgs e)
        {
            LoadCameraData();
        }

        #endregion
    }
}
