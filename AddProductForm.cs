using System;
using System.Windows.Forms;
using System.IO;

namespace StarBuko
{
    public partial class AddProductForm : Form
    {
        private string selectedImagePath = "";

        public AddProductForm()
        {
            InitializeComponent();
            pictureBoxProduct.Cursor = Cursors.Hand;
            pictureBoxProduct.Click += pictureBoxProduct_Click;
        }

        private void pictureBoxProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            dialog.Title = "Select Product Image";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;
                pictureBoxProduct.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid product name and price.");
                return;
            }

            string savedImageName = "";
            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                string ext = Path.GetExtension(selectedImagePath);
                savedImageName = txtProductName.Text.Trim().ToLower().Replace(" ", "_") + ext;
                string destPath = Path.Combine(Application.StartupPath, "images", savedImageName);
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "images"));
                File.Copy(selectedImagePath, destPath, true);
            }

            var repo = new ProductRepository();
            repo.AddProduct(txtProductName.Text.Trim(), price, savedImageName);
            MessageBox.Show("Product added successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}