using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DXApplication1.DAO;
using DXApplication1.Entity;
using DXApplication1.UI.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.UI.Modules
{
    public partial class acUser : DevExpress.XtraEditors.XtraUserControl
    {
        private static acUser _instace;
        public static acUser Instance
        {
            get
            {
                if (_instace == null)
                {
                    _instace = new acUser();
                }
                return _instace;
            }
        }

        public acUser()
        {
            InitializeComponent();
        }

        private void acUser_Load(object sender, EventArgs e)
        {
            List<User> users = UserDAO.Instance.GetAllUsers();
            if (users != null && users.Count > 0)
            {
                gridControl1.DataSource = users;
                LoadCheckBox();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản!");
            }
            gridView1.CellValueChanged += gridView1_CellValueChanged;
        }
        private void LoadCheckBox()
        {
            RepositoryItemCheckEdit checkEditAdmin = new RepositoryItemCheckEdit();
            checkEditAdmin.ValueChecked = true;
            checkEditAdmin.ValueUnchecked = false;

            RepositoryItemCheckEdit checkEditManager = new RepositoryItemCheckEdit();
            checkEditManager.ValueChecked = true;
            checkEditManager.ValueUnchecked = false;

            RepositoryItemCheckEdit checkEditStatus = new RepositoryItemCheckEdit();
            checkEditStatus.ValueChecked = true;
            checkEditStatus.ValueUnchecked = false;

        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                object cellValue = gridView1.GetRowCellValue(e.RowHandle, "Id");

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int userId = Convert.ToInt32(cellValue);
                    bool isChecked = Convert.ToBoolean(e.Value);
                    string role = string.Empty;

                    if (e.Column.FieldName == "IsAdmin")
                    {
                        role = "Admin";
                    }
                    else if (e.Column.FieldName == "IsManager")
                    {
                        role = "Quản lý";
                    }

                    if (!string.IsNullOrEmpty(role))
                    {
                        UpdateUserRole(userId, role, isChecked);
                    }
                }
                else
                {
                    MessageBox.Show("ID không tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateUserRole(int userId, string role, bool isChecked)
        {
            try
            {
                if (isChecked)
                {
                    bool success = UserDAO.Instance.AssignRoleToUser(userId, role);
                    if (success)
                    {
                        MessageBox.Show($"Phân quyền tài khoản thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Phân quyền tài khoản thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bool success = UserDAO.Instance.RemoveRoleFromUser(userId, role);
                    if (success)
                    {
                        MessageBox.Show($"Thu hồi quyền thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thu hồi quyền thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.UserAdded += acUser_Load;
            addUser.ShowDialog();
        }
    }
}
