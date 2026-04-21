namespace StarBuko
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnSave = new Button();
            txtPrice = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            pictureBoxProduct = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(3, 53, 44);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(167, 36);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 1;
            label1.Text = "Add Product";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(193, 425);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top;
            txtPrice.Location = new Point(116, 200);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(270, 23);
            txtPrice.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(3, 53, 44);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(116, 177);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Top;
            txtProductName.Location = new Point(116, 131);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(270, 23);
            txtProductName.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(3, 53, 44);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(116, 99);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 6;
            label2.Text = "Product Name";
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackColor = Color.FromArgb(255, 255, 192);
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.Location = new Point(193, 258);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(155, 144);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProduct.TabIndex = 11;
            pictureBoxProduct.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(3, 53, 44);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(72, 258);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 12;
            label4.Text = "Picture (click)";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 53, 44);
            ClientSize = new Size(502, 561);
            Controls.Add(label4);
            Controls.Add(pictureBoxProduct);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private PictureBox pictureBoxProduct;
        private Label label4;
    }
}