using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using DXApplication1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication1;

namespace DXApplication1.UI.Login
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            textEditUsername.KeyDown += new KeyEventHandler(TextEdit_KeyDown);
            textEditPassword.KeyDown += new KeyEventHandler(TextEdit_KeyDown);
        }
        private void TextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformLogin();
            }
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }
        private void PerformLogin()
        {
            string username = textEditUsername.Text.Trim();
            string password = textEditPassword.Text;
            bool isAuthenticated = UserDAO.Authenticate(username, password);

            if (isAuthenticated)
            {
                FormMain main = new FormMain(textEditUsername.Text);
                this.Hide();
                main.Show();
            }
            else
            {
                XtraMessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                textEditPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                textEditPassword.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}
