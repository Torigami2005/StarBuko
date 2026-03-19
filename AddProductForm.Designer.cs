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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(3, 53, 44);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(191, 48);
            label1.Name = "label1";
            label1.Size = new Size(182, 38);
            label1.TabIndex = 1;
            label1.Text = "Add Product";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(228, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 39);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPrice.Location = new Point(133, 267);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(308, 27);
            txtPrice.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(3, 53, 44);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(133, 236);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtProductName.Location = new Point(133, 175);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(308, 27);
            txtProductName.TabIndex = 7;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(3, 53, 44);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(133, 132);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 6;
            label2.Text = "Product Name";
            label2.Click += label2_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 53, 44);
            ClientSize = new Size(574, 504);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
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
    }
}