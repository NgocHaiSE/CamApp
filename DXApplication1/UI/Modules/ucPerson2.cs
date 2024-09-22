using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DXApplication1.DAO;
using DXApplication1.UI.ChildForms;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.UI.Modules
{
    public partial class ucPerson2 : DevExpress.DXperience.Demos.TutorialControlBase /*DevExpress.XtraEditors.XtraUserControl*/
    {
        private static ucPerson2 _instace;
        public static ucPerson2 Instance
        {
            get
            {
                if(_instace == null)
                {
                    _instace = new ucPerson2();
                }
                return _instace;
            }
        }
        public ucPerson2()
        {
            InitializeComponent();
        }

        private void ucPerson2_Load(object sender, EventArgs e)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteProcedure("GetAllPersons");
            if (dataTable != null)
            {
                gridControl1.DataSource = dataTable;
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView1.OptionsBehavior.Editable = false;
                
                RepositoryItemPictureEdit pictureEdit = new RepositoryItemPictureEdit();
                gridControl1.RepositoryItems.Add(pictureEdit);
                gridView1.Columns["Link ảnh"].ColumnEdit = pictureEdit;
                gridView1.Columns["Ngày tạo"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gridView1.Columns["Ngày tạo"].DisplayFormat.FormatString = "dd-MM-yyyy"; 
                gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
                labelControlName.Text = gridView1.GetRowCellValue(0, "Họ tên").ToString();
                pictureEdit1.Image = Image.FromFile(gridView1.GetRowCellValue(0, "Link ảnh").ToString());
                richEditControl1.Text = gridView1.GetRowCellValue(0, "Thông tin").ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!");
            }
        }
        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                string imageLink = row["Link ảnh"].ToString(); 

                if (File.Exists(imageLink))
                {
                    pictureEdit1.Image = Image.FromFile(imageLink);
                }
                else
                {
                    pictureEdit1.Image = null;
                }
                labelControlName.Text = row["Họ tên"].ToString();
                richEditControl1.Text = row["Thông tin"].ToString();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditInfo editInfo = new EditInfo((int) gridView1.GetRowCellValue(0, "ID"), richEditControl1.Text);
            editInfo.InfoEdited += ucPerson2_Load;
            editInfo.ShowDialog();
        }

        private void richEditControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            popupMenu1.ShowPopup(barManager1, richEditControl1.PointToScreen(e.Location));

        }

        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int focusedRowHandle = gridView1.FocusedRowHandle;
            int id = (int)gridView1.GetRowCellValue(focusedRowHandle, "ID");
            adjustPerson adjustPerson = new adjustPerson(id);
            adjustPerson.PersonAdjusted += ucPerson2_Load;
            adjustPerson.Show();
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addPerson addPerson = new addPerson();
            addPerson.PersonAdded += ucPerson2_Load;
            addPerson.Show();
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int focusedRowHandle = gridView1.FocusedRowHandle;

            int id = (int)gridView1.GetRowCellValue(focusedRowHandle, "ID");

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = PersonDAO.Instance.DeletePerson(id);

                if (isDeleted)
                {
                    MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Failed to delete the record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshData()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteProcedure("GetAllPersons");
            gridControl1.DataSource = dataTable;
        }
    }
}
