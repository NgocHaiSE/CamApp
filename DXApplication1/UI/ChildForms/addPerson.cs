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
using System.Net.Http.Headers;
using System.Net.Http;
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
                            DevExpress.XtraEditors.PictureEdit pictureEdit = new DevExpress.XtraEditors.PictureEdit
                            {
                                Image = System.Drawing.Image.FromFile(fileName),
                                Properties = { SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch },
                                Height = 240,
                                Width = 180,
                                Margin = new Padding(3)
                            };

                            stackPanel1.Controls.Add(pictureEdit);
                            //if (imagePaths.Count > 0 && ptrMain.Image == null)
                            //{
                            //    ptrMain.Image = System.Drawing.Image.FromFile(imagePaths[0]);
                            //    ptrMain.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                            //}
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

        private void barbtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Person newPerson = new Person
                (
                    code: string.IsNullOrWhiteSpace(txtCode.Text) ? "" : txtCode.Text,
                    name: string.IsNullOrWhiteSpace(txtName.Text) ? "" : txtName.Text,
                    gender: cbGender.SelectedItem.ToString() == "Nam" ? 1 : 0,
                    birth: dateEditBirth.DateTime,
                    phone: string.IsNullOrWhiteSpace(txtPhone.Text) ? "" : txtPhone.Text,
                    address: string.IsNullOrWhiteSpace(txtAddress.Text) ? "" : txtAddress.Text,
                    information: string.IsNullOrWhiteSpace(memoInfo.Text) ? "" : memoInfo.Text,
                    isRecog: cbIsRecog.SelectedItem.ToString() == "Có" ? 1 : 0
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
    }
}