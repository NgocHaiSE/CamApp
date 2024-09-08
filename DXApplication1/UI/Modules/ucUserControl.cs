using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DXApplication1.UI.ChildForms;

namespace DXApplication1.UI.Modules
{
    public partial class ucUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucUserControl _instace;
        public static ucUserControl Instance
        {
            get
            {
                if (_instace == null)
                {
                    _instace = new ucUserControl();
                }
                return _instace;
            }
        }
        public ucUserControl()
        {
            InitializeComponent();
        }

        private void ucUserControl_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=01102000;database=face_db";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT \r\n    id AS \"ID\",\r\n    username AS \"Tên đăng nhập\",\r\n    CASE \r\n        WHEN role = '1' THEN 'Quản trị viên'\r\n        WHEN role = '0' THEN 'Người dùng'\r\n        ELSE 'Khác'\r\n    END AS \"Loại người dùng\",\r\n    create_time AS \"Thời gian tạo\"\r\nFROM \r\n    user;\r\n";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    gridControl1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }
    }
}
