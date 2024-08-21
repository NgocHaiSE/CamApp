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
using System.Windows.Forms;
using DXApplication1.UI.ChildForms;

namespace DXApplication1.UI.Modules
{
    public partial class ucCamControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ucCamControl()
        {
            InitializeComponent();
        }

        private void ucCamControl_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=01102000;database=face_db";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT \r\n    id AS \"ID\",\r\n    name AS \"Tên Camera\",\r\n    link AS \"Liên kết\",\r\n    loaction AS \"Vị trí\",\r\n    CASE \r\n        WHEN is_recog = 1 THEN 'Có'\r\n        WHEN is_recog = 0 THEN 'Không'\r\n    END AS \"Nhận diện\"\r\nFROM \r\n    camera;\r\n";
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
           addCam addCam = new addCam();
            addCam.Show();
        }
    }
}
