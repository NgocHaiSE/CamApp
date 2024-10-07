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
using DevExpress.Utils.Animation;
using DevExpress.XtraBars;

namespace DXApplication1.UI.ChildForms
{
    public partial class addPerson : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler PersonAdded;
        public addPerson()
        {
            InitializeComponent();
        }

        private void addPerson_Load(object sender, EventArgs e) { }

        private List<string> imagePaths = new List<string>();

        private async void btnAddImage_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            //    openFileDialog.Multiselect = true;
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        imagePaths.Add(openFileDialog.FileName);
            //PictureBox pb = new PictureBox();
            //pb.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            //pb.SizeMode = PictureBoxSizeMode.StretchImage;
            //pb.Width = 180;
            //pb.Height = 240;
            //pb.Padding = new Padding(3);
            //pb.MouseUp += (sender3, e3) =>
            //{
            //    if (e3.Button == MouseButtons.Right)
            //    {
            //        popupMenu2.Tag = pb;
            //        popupMenu2.ShowPopup(barManager1, Control.MousePosition);
            //    }
            //};
            //flowLayoutPanel1.Controls.Add(pb);
            //    }
            //}
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
                            PictureBox pb = new PictureBox();
                            pb.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Width = 180;
                            pb.Height = 240;
                            pb.Padding = new Padding(3);
                            pb.MouseUp += (sender3, e3) =>
                            {
                                if (e3.Button == MouseButtons.Right)
                                {
                                    popupMenu2.Tag = pb;
                                    popupMenu2.ShowPopup(barManager1, Control.MousePosition);
                                }
                            };
                            flowLayoutPanel1.Controls.Add(pb);
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

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtCode.Text = string.Empty;
            txtCode.Text = string.Empty;
            cbIsRecog.SelectedItem = false;

            if (ptrMain.Image != null)
            {
                ptrMain.Image.Dispose();
                ptrMain.Image = null;
            }
            flowLayoutPanel1.Controls.Clear();
            imagePaths.Clear();
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            var slideAnimation = this.transitionManager1.GetTransition<PushTransition>(this.officeNavigationBar1);
            this.transitionManager1.StartTransition(this.officeNavigationBar1);
            if (e.Item == navibarGeneral)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = false;
            }
            else if(e.Item == navibarInfo)
            {
                panelControl2.Visible = false;
                panelControl3.Visible = true;
            }
            this.transitionManager1.EndTransition();
        }

        private async void barbtnReplace_ItemClick(object sender, ItemClickEventArgs e)
        {
            PictureBox selectedPictureBox = popupMenu2.Tag as PictureBox;
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
        private void barbtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            PictureBox selectedPictureBox = popupMenu2.Tag as PictureBox;
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new person instance
                Person newPerson = new Person
                (
                    code: string.IsNullOrWhiteSpace(txtCode.Text) ? "" : txtCode.Text,
                    name: string.IsNullOrWhiteSpace(txtName.Text) ? "" : txtName.Text,
                    gender: cbGender.SelectedItem.ToString() == "Nam" ? 1 : 0,
                    birth: dpBirth.DateTime,
                    phone: string.IsNullOrWhiteSpace(txtPhone.Text) ? "" : txtPhone.Text,
                    address: string.IsNullOrWhiteSpace(txtAddress.Text) ? "" : txtAddress.Text,
                    information: string.IsNullOrWhiteSpace(txtCode.Text) ? "" : txtCode.Text,
                    isRecog: cbIsRecog.SelectedItem.ToString() == "Có" ? 1 : 0
                );

                // Add the new person to the database
                PersonDAO.Instance.AddPerson(newPerson);

                // List to hold ImageEntity objects
                List<ImageEntity> images = new List<ImageEntity>();

                // Loop through image paths and upload each image
                foreach (string imagePath in imagePaths)
                {
                    // Upload image to API
                    string uploadResult = await UploadImageToAPI(imagePath);

                    // Optionally, log the upload result (success or failure)
                    Console.WriteLine(uploadResult);

                    // If upload is successful, add the image to the list
                    if (uploadResult.StartsWith("Upload Successful"))
                    {
                        images.Add(new ImageEntity
                        {
                            Link = Path.GetFileName(imagePath)
                        });
                    }
                }

                // Add the images to the database
                ImageDAO.Instance.AddImages(newPerson.Code, images);

                // Invoke the PersonAdded event (if any subscribers)
                PersonAdded?.Invoke(this, EventArgs.Empty);

                // Show success message
                MessageBox.Show("Thêm nhân viên mới thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}