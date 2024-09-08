using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
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
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler UserAdded;
        public AddUser()
        {
            InitializeComponent();
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textEditUsername.Text;
                string password = textEditPassword.Text;
                string info = textEditInfo.Text;
                bool isAdmin = checkAdmin.Checked;
                bool isManager = checkManager.Checked;
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Tên tài khoản và mật khẩu không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                UserDAO.Instance.AddUser(username, password, info, isAdmin, isManager);
                UserAdded?.Invoke(this, EventArgs.Empty);
                XtraMessageBox.Show("Thêm tài khoản mới thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm tài khoản mới: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}