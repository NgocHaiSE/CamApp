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

namespace DXApplication1.UI.Modules
{
    public partial class ucNotification : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNotification()
        {
            InitializeComponent();
        }

        private void ucNotification_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=01102000;database=face_db";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT     n.id AS \"ID\",    p.name AS \"Tên nhân viên\",    c.name AS \"Camera\",    n.image AS \"Hình ảnh\",    n.score AS \"Độ chính xác\",    n.time AS \"Thời gian\" FROM     notification n JOIN     person p ON n.id_person = p.id JOIN   camera c ON n.id_camera = c.id";
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
    }
}
