using DevExpress.XtraEditors;
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

namespace DXApplication1.UI.ChildForms
{
    public partial class EditInfo : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler InfoEdited;
        private int personId;
        public EditInfo()
        {
            InitializeComponent();
        }
        public EditInfo(int personId, string info)
        {
            InitializeComponent();
            this.personId = personId;
            richEditControl1.Text = info;
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonDAO.Instance.UpdatePersonInfo(personId, richEditControl1.Text);
            InfoEdited?.Invoke(this, EventArgs.Empty);
            XtraMessageBox.Show("Chỉnh sửa thông tin nhân viên thành công!", "Success", MessageBoxButtons.OK);
        }

    }
}