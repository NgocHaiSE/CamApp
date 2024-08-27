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
using DXApplication1.DAO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.IO;
using ZstdSharp.Unsafe;
using DXApplication1.DTO;

namespace DXApplication1.UI.Modules
{
    public partial class ucNotification : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNotification()
        {
            InitializeComponent();
            barDateFilter.EditValueChanged += new EventHandler(DateSelect);
            barCameraFilter.EditValueChanged += new EventHandler(CameraSelect);
            GridView gridView = gridControl1.MainView as GridView;
            gridView.Columns["Thời gian"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView.Columns["Thời gian"].DisplayFormat.FormatString = "dd-MM-yyyy"; // Example: 26-Aug-2024
            LoadCameras();
        }
        private void LoadCameras()
        {
            DataTable data = CameraDAO.Instance.GetCameraList();

            repositoryItemComboBox1.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                string cameraName = row["Tên Camera"].ToString();
                repositoryItemComboBox1.Items.Add(cameraName);
            }
        }
        private void DateSelect(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CameraSelect(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string selectedDate = barDateFilter.EditValue?.ToString() ?? string.Empty;
            string selectedCamera = barCameraFilter.EditValue?.ToString() ?? string.Empty;

            DateTime dateValue;
            string filterCondition = "";
            if (DateTime.TryParse(selectedDate, out dateValue))
            {
                dateValue = dateValue.Date;
                //string formattedDate = dateValue.ToString("dd-MM-yyyy");
                filterCondition = $"[Thời gian] = #" + dateValue + "#";
            }

            if (!string.IsNullOrEmpty(selectedCamera))
            {
                if (!string.IsNullOrEmpty(filterCondition))
                {
                    filterCondition += " AND ";
                }
                filterCondition += $"[Tên camera] = '{selectedCamera}'";
            }
            GridView gridView = gridControl1.MainView as GridView;
            gridView.ActiveFilterString = filterCondition;
        }

        private void ucNotification_Load(object sender, EventArgs e)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteProcedure("GetAllNotifications");
            if (dataTable != null)
            {
                gridControl1.DataSource = dataTable;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView1.OptionsBehavior.Editable = false;

                AddUnboundColumn(gridView1);
                gridView1.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
                SetImageSize();
                gridView1.RowHeight = 250;
                //gridView1.BestFitColumns();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!");
            }
        }
        private void SetImageSize()
        {
            GridColumn imageColumn = gridView1.Columns["Hình ảnh"];
            if (imageColumn != null)
            {
                RepositoryItemPictureEdit pictureEdit = imageColumn.ColumnEdit as RepositoryItemPictureEdit;

                if (pictureEdit != null)
                {
                    pictureEdit.SizeMode = PictureSizeMode.Stretch;
                    pictureEdit.CustomHeight = 250;
                }
            }
        }
        private void AddUnboundColumn(GridView view)
        {
            if (!view.Columns.Any(col => col.FieldName == "Image"))
            {
                GridColumn colImage = new GridColumn();
                colImage.FieldName = "Image";
                colImage.Caption = "Ảnh";
                colImage.UnboundType = UnboundColumnType.Object;
                colImage.OptionsColumn.AllowEdit = false;
                colImage.Visible = true;
                colImage.Width = 200;

                view.Columns.Add(colImage);
                AssignPictureEdittoImageColumn(colImage);
            }
        }
        private void AssignPictureEdittoImageColumn(GridColumn column)
        {
            RepositoryItemPictureEdit riPictureEdit = new RepositoryItemPictureEdit();
            riPictureEdit.SizeMode = PictureSizeMode.Zoom;
            gridControl1.RepositoryItems.Add(riPictureEdit);
            column.ColumnEdit = riPictureEdit;
        }
        Dictionary<string, Image> imageCache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);
        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;
                string fileName = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), "Link ảnh") as string ?? string.Empty;
                if (!imageCache.ContainsKey(fileName))
                {
                    Image img = GetImage(fileName);
                    imageCache.Add(fileName, img);
                }
                e.Value = imageCache[fileName];
            }
        }
        private Image GetImage(string path)
        {
            Image img = null;
            try
            {
                if (File.Exists(path))
                    img = Image.FromFile(path);
                else
                {
                    string basePath = AppDomain.CurrentDomain.BaseDirectory;
                    string imagePath = Path.Combine(basePath, "imgs", "default.jpg");
                    img = Image.FromFile(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string imagePath = Path.Combine(basePath, "imgs", "default.jpg");
                img = Image.FromFile(imagePath);
            }
            return img;
        }

    }
}
