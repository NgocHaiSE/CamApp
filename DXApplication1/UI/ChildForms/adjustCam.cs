using DevExpress.XtraGrid;
using DXApplication1.DAO;
using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.UI.ChildForms
{
    public partial class adjustCam : Form
    {
        public event EventHandler CameraAdjusted;

        public adjustCam()
        {
            InitializeComponent();
            LoadData();
            dgvCameraList.SelectionChanged += dgvCameraList_SelectionChanged;
        }

        private void adjustCam_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataTable cameraData = CameraDAO.Instance.GetCameraList();
            if (cameraData == null)
            {
                MessageBox.Show("Không có dữ liệu", "Fail", MessageBoxButtons.OK);
                return;
            }

            dgvCameraList.DataSource = cameraData;
            foreach (DataGridViewColumn column in dgvCameraList.Columns)
            {
                if (column.Name != "ID" && column.Name != "Tên Camera")
                {
                    column.Visible = false;
                }
            }
            dgvCameraList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvCameraList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCameraList.CurrentRow != null)
            {
                DataRowView selectedRow = dgvCameraList.CurrentRow.DataBoundItem as DataRowView;
                if (selectedRow != null)
                {
                    txtCamName.Text = selectedRow["Tên Camera"].ToString();
                    txtLocation.Text = selectedRow["Vị trí"].ToString();
                    txtLink.Text = selectedRow["Đường dẫn"].ToString();
                    txtType.Text = selectedRow["Loại Camera"].ToString();
                    txtIP.Text = selectedRow["IP"].ToString();
                    txtUsername.Text = selectedRow["Tên tài khoản"].ToString();
                    txtPassword.Text = selectedRow["Mật khẩu"].ToString();
                    checkStatus.Checked = selectedRow["Nhận diện"].ToString() == "Có";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvCameraList.CurrentRow != null)
            {
                DataRowView selectedRow = dgvCameraList.CurrentRow.DataBoundItem as DataRowView;
                if (selectedRow != null)
                {
                    Camera camera = new Camera
                    (
                        (int)selectedRow["ID"],
                        string.IsNullOrWhiteSpace(txtCamName.Text) ? null : txtCamName.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtLink.Text) ? null : txtLink.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtType.Text) ? null : txtType.Text.Trim(),
                        checkStatus.Checked ? 1 : 0,
                        string.IsNullOrWhiteSpace(txtIP.Text) ? null : txtIP.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtLocation.Text) ? null : txtLocation.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtUsername.Text) ? null : txtUsername.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtPassword.Text) ? null : txtPassword.Text.Trim()
                    );
                    try
                    {
                        CameraDAO.Instance.Update(camera);
                        CameraAdjusted?.Invoke(this, EventArgs.Empty);
                        LoadData();
                        MessageBox.Show("Cập nhật thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvCameraList.CurrentRow != null)
            {
                try
                {
                    DataRowView selectedRow = dgvCameraList.CurrentRow.DataBoundItem as DataRowView;
                    if (selectedRow != null)
                    {
                        CameraDAO.Instance.Delete((int)selectedRow["ID"], 0);
                        CameraAdjusted?.Invoke(this, EventArgs.Empty);
                        LoadData();
                        MessageBox.Show("Xóa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một camera để xóa.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}

