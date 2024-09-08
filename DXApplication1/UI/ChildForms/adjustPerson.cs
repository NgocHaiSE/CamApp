using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DXApplication1.DAO;
using DXApplication1.Entity;
using MySql.Data.MySqlClient;
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
    public partial class adjustPerson : DevExpress.XtraEditors.XtraForm
    {
        private int personId;

        public event EventHandler PersonAdjusted;
        public adjustPerson()
        {
            InitializeComponent();
        }
        #region Method
        public adjustPerson(int id)
        {
            InitializeComponent();
            personId = id;
            LoadPersonData();
        }

        private void LoadPersonData()
        {
            DataTable personData = PersonDAO.Instance.GetPerson(personId);

            if (personData == null || personData.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên với ID: " + personId);
                return;
            }

            DataRow row = personData.Rows[0];
            txtCode.Text = row["Mã nhân viên"].ToString();
            txtName.Text = row["Họ tên"].ToString();
            //rtxtInfo.Text = row["Thông tin"].ToString();
            checkIsRecog.Checked = row["Nhận diện"].ToString() == "Có";
            string imageUrl = row["Link ảnh"].ToString(); 
            if (!string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    ptrMain.Image = Image.FromFile(imageUrl); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                }
            }
            else
            {
                ptrMain.Image = Image.FromFile(@"D:\C#\AppCamera\DXApplication1\DXApplication1\DXApplication1\imgs\default.jpg"); ; // Nếu không có link, để trống ảnh
            }
            ptrMain.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            LoadImageData(row["Mã nhân viên"].ToString());
        }
        private void LoadImageData(string personCode)
        {
            flowLayoutPanel1.Controls.Clear();
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@p_personcode", MySqlDbType.VarChar) { Value = personCode }
            };
            DataTable imageData = DataProvider.Instance.ExecuteProcedure("GetImage", parameters);
            foreach (DataRow row in imageData.Rows)
            {
                string imageUrl = row["link"].ToString();
                if (!string.IsNullOrEmpty(imageUrl))
                {
                    try
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromFile(imageUrl);
                        pb.SizeMode = PictureBoxSizeMode.Zoom; 
                        pb.Width = 185; 
                        pb.Height = 240; 
                        pb.Padding = new Padding(10);
                        pb.MouseUp += (sender, e) =>
                        {
                            if (e.Button == MouseButtons.Right)
                            {
                                popupMenu1.Tag = pb; 
                                popupMenu1.ShowPopup(barManager1, Control.MousePosition); 
                            }
                        };

                        flowLayoutPanel1.Controls.Add(pb);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Events
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
                            Height = 250,
                            Width = 190,
                            Margin = new Padding(10)
                        };
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Person adjustedPerson = new Person
                (
                    code: string.IsNullOrWhiteSpace(txtCode.Text) ? "" : txtCode.Text,
                    name: string.IsNullOrWhiteSpace(txtName.Text) ? "" : txtName.Text,
                    information: null,
                    isRecog: checkIsRecog.Checked ? 1 : 0
                );
                adjustedPerson.Id = personId;

                PersonDAO.Instance.AdjustPerson(adjustedPerson);

                List<ImageEntity> images = imagePaths.Select((path, index) => new ImageEntity
                {
                    Link = path
                }).ToList();

                ImageDAO.Instance.AddImages(adjustedPerson.Code, images);
                PersonAdjusted?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Chỉnh sửa thông tin thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void barbtnReplace_ItemClick(object sender, ItemClickEventArgs e)
        {
            PictureBox selectedPictureBox = popupMenu1.Tag as PictureBox;
            if (selectedPictureBox != null)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string newImagePath = openFileDialog.FileName;

                        try
                        {
                            selectedPictureBox.Image = Image.FromFile(newImagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể thay thế ảnh: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void barbtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            PictureBox selectedPictureBox = popupMenu1.Tag as PictureBox;
            if (selectedPictureBox != null)
            {
                try
                {
                    flowLayoutPanel1.Controls.Remove(selectedPictureBox);
                    selectedPictureBox.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa ảnh: " + ex.Message);
                }
            }
        }
    }
}