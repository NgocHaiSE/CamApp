using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DXApplication1.DAO;
using DXApplication1.DTO;
using DXApplication1.Entity;
using DXApplication1.UI.Modules;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;
using System.Threading.Tasks;

namespace DXApplication1.UI.ChildForms
{
    public partial class addCam : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler CameraAdded;
        public addCam()
        {
            InitializeComponent();
        }

        private void addCam_Load(object sender, EventArgs e)
        {
        }

        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Camera camera = new Camera(
                    id: Convert.ToInt32(txtId.Text),
                    name: txtCamName.Text,
                    link: string.IsNullOrWhiteSpace(txtLink.Text) ? "" : txtLink.Text,
                    type: string.IsNullOrWhiteSpace(txtType.Text) ? "" : txtType.Text,
                    status: checkStatus.Checked ? 1 : 0,
                    ip: string.IsNullOrWhiteSpace(txtIP.Text) ? "" : txtIP.Text,
                    location: string.IsNullOrWhiteSpace(txtLocation.Text) ? "" : txtLocation.Text,
                    username: string.IsNullOrWhiteSpace(txtUsername.Text) ? "" : txtUsername.Text,
                    password: string.IsNullOrWhiteSpace(txtPassword.Text) ? "" : txtPassword.Text
                );

                CameraDAO.Instance.Insert(camera);
                await CallAddCamApi(camera.Id);
                CameraAdded?.Invoke(this, EventArgs.Empty);
                XtraMessageBox.Show("Thêm mới camera thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm mới camera: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task CallAddCamApi(int cameraId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://localhost:8000/addCam/{cameraId}"; 
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"API Response: {result}", "API Call", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"API Error: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error calling API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}