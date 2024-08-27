using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using DXApplication1.DAO;
using DXApplication1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.UI.ChildForms
{
    public partial class addPerson : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler PersonAdded;
        public addPerson()
        {
            InitializeComponent();
        }

        private void addPerson_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Person newPerson = new Person
                (
                    code: string.IsNullOrWhiteSpace(txtCode.Text) ? "" : txtCode.Text,
                    name: string.IsNullOrWhiteSpace(txtName.Text) ? "" : txtName.Text,
                    information: string.IsNullOrWhiteSpace(txtInfo.Text) ? "" : txtInfo.Text,
                    isRecog: checkIsRecog.Checked ? 1 : 0
                ); 

                PersonDAO.Instance.AddPerson(newPerson);

                List<ImageEntity> images = imagePaths.Select((path, index) => new ImageEntity
                {
                    Link = path
                }).ToList();

                ImageDAO.Instance.AddImages(newPerson.Code, images);
                PersonAdded?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Thêm nhân viên mới thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> imagePaths = new List<string>();

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        imagePaths.Add(fileName);

                        PictureBox pictureBox = new PictureBox
                        {
                            Image = System.Drawing.Image.FromFile(fileName),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Height = 242,
                            Width = 185,
                            Margin = new Padding(10)
                        };
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
                if (imagePaths.Count > 0 && ptrMain.Image == null)
                {
                    ptrMain.Image = System.Drawing.Image.FromFile(imagePaths[0]);
                    ptrMain.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtInfo.Text = string.Empty;
            checkIsRecog.Checked = false;

            if (ptrMain.Image != null)
            {
                ptrMain.Image.Dispose();
                ptrMain.Image = null;
            }
            flowLayoutPanel1.Controls.Clear();
            imagePaths.Clear();
        }
    }
}