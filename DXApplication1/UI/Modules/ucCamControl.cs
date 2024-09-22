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
using System.Net.Http;

namespace DXApplication1.UI.Modules
{
    public partial class ucCamControl : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucCamControl _instace;
        public static ucCamControl Instance
        {
            get
            {
                if (_instace == null)
                {
                    _instace = new ucCamControl();
                }
                return _instace;
            }
        }
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
            DataTable data = DataProvider.Instance.ExecuteProcedure("GetAllCameras");
            if (data != null)
            {
                gridControl1.DataSource = data;
            }
            else
            {
                MessageBox.Show("Hiện không tìm thấy thông tin camera nào!");
            }
        }
        #endregion

        #region Events
        private void barbtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addCam addCam = new addCam();
            addCam.CameraAdded += RefreshData;
            addCam.Show();
        }

        private void RefreshData(object sender, EventArgs e)
        {
            LoadCameraData();
        }

        private void barbtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            adjustCam adjustCam = new adjustCam();
            adjustCam.CameraAdjusted += RefreshData;
            adjustCam.Show();
        }
        #endregion

        private async Task CallCheckLinkApi(string cameraLink)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://localhost:8000/checkLink/{cameraLink}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Link camera vẫn hoạt động", "API Call", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Link camera không còn hoạt động", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error calling API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int focusedRowHandle = gridView1.FocusedRowHandle;
            string cameraLink = gridView1.GetRowCellValue(focusedRowHandle, "Đường dẫn").ToString();
            CallCheckLinkApi(cameraLink);
        }
    }
}
