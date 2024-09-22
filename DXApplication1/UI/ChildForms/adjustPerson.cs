using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Commands;
using DXApplication1.DAO;
using DXApplication1.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
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
            txtPhone.Text = row["Số điện thoại"].ToString();
            txtAddress.Text = row["Địa chỉ"].ToString();
            cbGender.Text = row["Giới tính"].ToString();
            dateEditBirth.Text = row["Ngày sinh"].ToString();
            cbIsRecog.Text = row["Nhận diện"].ToString();
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
            stackPanel1.Controls.Clear();
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
                        pb.SizeMode = PictureBoxSizeMode.StretchImage; 
                        pb.Width = 180; 
                        pb.Height = 240; 
                        pb.Padding = new Padding(3);
                        pb.MouseUp += (sender, e) =>
                        {
                            if (e.Button == MouseButtons.Right)
                            {
                                popupMenu1.Tag = pb; 
                                popupMenu1.ShowPopup(barManager1, Control.MousePosition); 
                            }
                        };
                        stackPanel1.Controls.Add(pb);
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
        private async void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        string result = await UploadImageToAPI(fileName);
                        if (result.Contains("Upload Successful"))
                        {
                            imagePaths.Add(fileName);
                            PictureBox pictureBox = new PictureBox
                            {
                                Image = Image.FromFile(fileName),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Width = 180,
                                Height = 240,
                                Margin = new Padding(3),
                            };
                            pictureBox.MouseUp += (sender2, e2) =>
                            {
                                if (e2.Button == MouseButtons.Right)
                                {
                                    popupMenu1.Tag = pictureBox;
                                    popupMenu1.ShowPopup(barManager1, Control.MousePosition);
                                }
                            };

                            stackPanel1.Controls.Add(pictureBox);
                            MessageBox.Show("Tải ảnh lên thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Tải ảnh thất bại: {result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void barbtnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            memoInfo.Text = string.Empty;
            cbIsRecog.SelectedItem = false;

            if (ptrMain.Image != null)
            {
                ptrMain.Image.Dispose();
                ptrMain.Image = null;
            }
            stackPanel1.Controls.Clear();
            imagePaths.Clear();
        }

        private async void barbtnReplace_ItemClick(object sender, ItemClickEventArgs e)
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
                            string result = await UploadImageToAPI(newImagePath);
                            if (result.Contains("Upload Successful"))
                            {
                                selectedPictureBox.Image = Image.FromFile(newImagePath);
                                MessageBox.Show("Tải ảnh lên thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Tải ảnh thất bại: {result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể thay thế ảnh: " + ex.Message);
                        }
                    }
                }
            }
        }

        public async Task<string> UploadImageToAPI(string imagePath)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://localhost:8000/upload-face";
                    using (var formData = new MultipartFormDataContent())
                    {
                        var fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                        var fileContent = new StreamContent(fileStream);
                        fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                        formData.Add(fileContent, "file", Path.GetFileName(imagePath));

                        HttpResponseMessage response = await client.PostAsync(url, formData);

                        string responseString = await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            return $"Upload Successful: {responseString}";
                        }
                        else
                        {
                            return $"Upload Failed: {responseString}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private void barbtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            PictureBox selectedPictureBox = popupMenu1.Tag as PictureBox;
            if (selectedPictureBox != null)
            {
                try
                {
                    stackPanel1.Controls.Remove(selectedPictureBox);
                    selectedPictureBox.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa ảnh: " + ex.Message);
                }
            }
        }
        #endregion

        private void barbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Person adjustedPerson = new Person
                (
                    code: string.IsNullOrWhiteSpace(txtCode.Text) ? "" : txtCode.Text,
                    name: string.IsNullOrWhiteSpace(txtName.Text) ? "" : txtName.Text,
                    information: string.IsNullOrWhiteSpace(memoInfo.Text) ? "" : memoInfo.Text,
                    gender: cbGender.SelectedItem.ToString() == "Nam" ? 1 : 0,
                    birth: dateEditBirth.EditValue == null ? (DateTime?)null : dateEditBirth.DateTime,
                    phone: string.IsNullOrWhiteSpace(txtPhone.Text) ? "" : txtPhone.Text,
                    address: string.IsNullOrWhiteSpace(txtAddress.Text) ? "" : txtAddress.Text,
                    isRecog: cbIsRecog.SelectedItem.ToString() == "Có" ? 1 : 0
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
    }
}