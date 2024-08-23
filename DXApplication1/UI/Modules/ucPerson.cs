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
using DXApplication1.DAO;

namespace DXApplication1.UI.Modules
{
    public partial class ucPerson : DevExpress.XtraEditors.XtraUserControl
    {
        public ucPerson()
        {
            InitializeComponent();
        }

        #region Method
        private void ucPerson_Load(object sender, EventArgs e)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteProcedure("GetPersonInfo");

            if (dataTable != null)
            {
                ConvertImagePathsToImages(dataTable);

                gridControl1.DataSource = dataTable;
                AdjustGridViewSettings();
                gridView1.BestFitColumns();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!");
            }
        }

        private void ConvertImagePathsToImages(DataTable dataTable)
        {
            if (dataTable.Columns.Contains("Link ảnh"))
            {
                DataColumn imageColumn = new DataColumn("Image", typeof(Image));
                dataTable.Columns.Add(imageColumn);
                foreach (DataRow row in dataTable.Rows)
                {
                    string imagePath = row["Link ảnh"].ToString();
                    if (File.Exists(imagePath))
                    {
                        try
                        {
                            using (Image img = Image.FromFile(imagePath))
                            {
                                row["Image"] = new Bitmap(img);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi tải ảnh từ đường dẫn {imagePath}: {ex.Message}");
                            row["Image"] = DBNull.Value;
                        }
                    }
                    else
                    {
                        row["Image"] = DBNull.Value;
                    }
                }
                dataTable.Columns.Remove("Link ảnh");
            }
        }

        private void AdjustGridViewSettings()
        {
            if (gridControl1.MainView is DevExpress.XtraGrid.Views.Grid.GridView gridView)
            {
                gridView.Columns["Image"].Width = 200; 
                gridView.RowHeight = 200; 

                gridView.Columns["Image"].OptionsColumn.FixedWidth = true;
                gridView.Columns["Image"].UnboundType = DevExpress.Data.UnboundColumnType.Object;
                gridView.Columns["Image"].OptionsColumn.AllowEdit = false;
                gridView.Columns["Image"].OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            }
        }
        #endregion

        #region Events
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            addPerson addPerson = new addPerson(); 
            addPerson.Show();
        }
        #endregion
    }
}
