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
using DXApplication1.Entity;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;

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
            DataTable dataTable = DataProvider.Instance.ExecuteProcedure("GetAllPersons");
            if (dataTable != null)
            {
                gridControl1.DataSource = dataTable;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView1.OptionsBehavior.Editable = false;

                AddUnboundColumn(gridView1);
                gridView1.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
                SetImageSize();
                gridView1.RowHeight = 200;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!");
            }
        }

        #region SettingImage
        private void SetImageSize()
        {
            GridColumn imageColumn = gridView1.Columns["Ảnh"];
            if (imageColumn != null)
            {
                RepositoryItemPictureEdit pictureEdit = imageColumn.ColumnEdit as RepositoryItemPictureEdit;

                if (pictureEdit != null)
                {
                    pictureEdit.SizeMode = PictureSizeMode.Stretch; 
                    pictureEdit.CustomHeight = 200; 
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
                    img = Image.FromFile(@"D:\C#\AppCamera\DXApplication1\DXApplication1\DXApplication1\imgs\default.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                img = Image.FromFile(@"D:\C#\AppCamera\DXApplication1\DXApplication1\DXApplication1\imgs\default.jpg"); 
            }
            return img;
        }
        #endregion
        #endregion

        #region Events
        private void barbtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addPerson addPerson = new addPerson();
            addPerson.PersonAdded += ucPerson_Load;
            addPerson.Show();
        }

        #endregion

        private void barbtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                int personId = Convert.ToInt32(gridView1.GetRowCellValue(selectedRowHandle, "ID"));

                var editForm = new adjustPerson(personId); 
                editForm.PersonAdjusted += ucPerson_Load;
                editForm.Show();

            }
        }
    }
}
