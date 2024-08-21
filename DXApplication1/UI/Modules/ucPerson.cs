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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.Utils;
using DXApplication1.UI.ChildForms;

namespace DXApplication1.UI.Modules
{
    public partial class ucPerson : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPerson()
        {
            InitializeComponent();
        }

        private void ucPerson_Load(object sender, EventArgs e)
        {
            LoadDataToGridControl();

        }

        private void LoadDataToGridControl()
        {
            string connectionString = "server=localhost;user id=root;password=01102000;database=face_db";
            string query = @"
            SELECT 
                p.id AS 'ID',
                p.name AS 'Tên',
                p.information AS 'Thông tin',
                p.create_time AS 'Thời gian tạo',
                CASE 
                    WHEN p.is_recog = 1 THEN 'Có'
                    WHEN p.is_recog = 0 THEN 'Không'
                END AS 'Nhận diện',
                i.link AS 'Ảnh'
            FROM 
                person p
            LEFT JOIN 
                image i ON p.id = i.id_person
            WHERE 
                i.id = (
                    SELECT MIN(id) 
                    FROM image 
                    WHERE id_person = p.id
                );";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Add a new column for image data
                            dataTable.Columns.Add(new DataColumn("Hình Ảnh", typeof(byte[])));

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string imagePath = row["Ảnh"].ToString();
                                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                                {
                                    row["Hình Ảnh"] = File.ReadAllBytes(imagePath);
                                }
                                else
                                {
                                    row["Hình Ảnh"] = null;
                                }
                            }
                            dataTable.Columns.Remove("Ảnh");
                            gridControl1.DataSource = dataTable;

                            // Customize the grid to display images
                            GridView gridView = gridControl1.MainView as GridView;

                            if (!gridView.Columns.Contains(gridView.Columns["Hình Ảnh"]))
                            {
                                GridColumn imageColumn = new GridColumn
                                {
                                    FieldName = "Hình Ảnh",
                                    Caption = "Hình Ảnh",
                                    Visible = true,
                                    UnboundType = DevExpress.Data.UnboundColumnType.Object
                                };
                                gridView.Columns.Add(imageColumn);
                            }

                            gridView.Columns["Hình Ảnh"].OptionsColumn.FixedWidth = true;
                            gridView.Columns["Hình Ảnh"].Width = 150;

                            gridView.RowHeight = 150;

                            gridView.CustomColumnDisplayText += (sender, e) =>
                            {
                                if (e.Column.FieldName == "Hình Ảnh" && e.Value is byte[])
                                {
                                    e.DisplayText = string.Empty;
                                }
                            };

                            gridView.CustomDrawCell += (sender, e) =>
                            {
                                if (e.Column.FieldName == "Hình Ảnh" && e.CellValue is byte[] imageData)
                                {
                                    e.DefaultDraw();

                                    if (imageData != null && imageData.Length > 0)
                                    {
                                        using (MemoryStream ms = new MemoryStream(imageData))
                                        {
                                            Image img = Image.FromStream(ms);
                                            e.Graphics.DrawImage(img, e.Bounds);
                                        }
                                    }
                                    e.Handled = true;
                                }
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            addPerson addPerson = new addPerson(); 
            addPerson.Show();
        }
    }
}
