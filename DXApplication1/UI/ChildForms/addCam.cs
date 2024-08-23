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
            LoadCompanies();
        }
        private void LoadCompanies()
        {
            List<CompanyDTO> companyList = CompanyDAO.Instance.GetAllCompanies();

            cbCompany.DataSource = companyList;
            cbCompany.DisplayMember = "name"; 
            cbCompany.ValueMember = "id"; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Camera camera = new Camera(
                    id: Convert.ToInt32(txtId.Text),
                    name: txtCamName.Text,
                    location: string.IsNullOrWhiteSpace(txtLocation.Text) ? "" : txtLocation.Text,
                    link: txtLink.Text,
                    type: Convert.ToInt32(cbType.Text),
                    ip: txtIP.Text,
                    username: string.IsNullOrWhiteSpace(txtUsername.Text) ? "" : txtUsername.Text,
                    password: string.IsNullOrWhiteSpace(txtPassword.Text) ? "" : txtPassword.Text,
                    status: checkStatus.Checked ? 1 : 0,
                    companyId: (int)cbCompany.SelectedValue
                );

                CameraDAO.Instance.Insert(camera);
                CameraAdded?.Invoke(this, EventArgs.Empty);
                XtraMessageBox.Show("Thêm mới camera thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm mới camera: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}