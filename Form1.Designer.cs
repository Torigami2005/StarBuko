namespace StarBuko
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridTable = new DataGridView();
            transactionButton = new Button();
            label2 = new Label();
            amountPrice = new Label();
            label3 = new Label();
            tenderedMoney = new TextBox();
            label1 = new Label();
            changePrice = new Label();
            lblWelcome = new Label();
            btnNewProduct = new Button();
            btnLogout = new Button();
            productPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridTable).BeginInit();
            SuspendLayout();
            // 
            // dataGridTable
            // 
            dataGridTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTable.Location = new Point(940, 116);
            dataGridTable.Margin = new Padding(3, 4, 3, 4);
            dataGridTable.Name = "dataGridTable";
            dataGridTable.RowHeadersWidth = 51;
            dataGridTable.Size = new Size(733, 490);
            dataGridTable.TabIndex = 2;
            dataGridTable.CellContentClick += dataGridTable_CellContentClick;
            // 
            // transactionButton
            // 
            transactionButton.AccessibleRole = AccessibleRole.None;
            transactionButton.BackColor = Color.Green;
            transactionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactionButton.ForeColor = SystemColors.ButtonHighlight;
            transactionButton.Location = new Point(1235, 639);
            transactionButton.Margin = new Padding(3, 4, 3, 4);
            transactionButton.Name = "transactionButton";
            transactionButton.Size = new Size(170, 51);
            transactionButton.TabIndex = 9;
            transactionButton.Text = "Add New Transaction";
            transactionButton.UseVisualStyleBackColor = false;
            transactionButton.Click += transactionButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1019, 708);
            label2.Name = "label2";
            label2.Size = new Size(176, 37);
            label2.TabIndex = 11;
            label2.Text = "Total Amount";
            label2.Click += label2_Click;
            // 
            // amountPrice
            // 
            amountPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountPrice.AutoSize = true;
            amountPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountPrice.Location = new Point(1570, 708);
            amountPrice.Name = "amountPrice";
            amountPrice.Size = new Size(72, 37);
            amountPrice.TabIndex = 12;
            amountPrice.Text = "0.00";
            amountPrice.Click += amountPrice_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(973, 770);
            label3.Name = "label3";
            label3.Size = new Size(228, 37);
            label3.TabIndex = 13;
            label3.Text = "Amount Tendered";
            label3.Click += label3_Click;
            // 
            // tenderedMoney
            // 
            tenderedMoney.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tenderedMoney.Location = new Point(1473, 782);
            tenderedMoney.Margin = new Padding(3, 4, 3, 4);
            tenderedMoney.Name = "tenderedMoney";
            tenderedMoney.Size = new Size(197, 27);
            tenderedMoney.TabIndex = 14;
            tenderedMoney.TextAlign = HorizontalAlignment.Right;
            tenderedMoney.TextChanged += tenderedMoney_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1081, 840);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 15;
            label1.Text = "Change";
            label1.Click += label1_Click;
            // 
            // changePrice
            // 
            changePrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            changePrice.AutoSize = true;
            changePrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changePrice.Location = new Point(1570, 840);
            changePrice.Name = "changePrice";
            changePrice.Size = new Size(72, 37);
            changePrice.TabIndex = 16;
            changePrice.Text = "0.00";
            changePrice.Click += changePrice_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(33, 26);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(310, 38);
            lblWelcome.TabIndex = 17;
            lblWelcome.Text = "Welcome to Starbuko!";
            // 
            // btnNewProduct
            // 
            btnNewProduct.AccessibleRole = AccessibleRole.None;
            btnNewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewProduct.BackColor = Color.Green;
            btnNewProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewProduct.ForeColor = SystemColors.ButtonHighlight;
            btnNewProduct.Location = new Point(367, 56);
            btnNewProduct.Margin = new Padding(3, 4, 3, 4);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(233, 51);
            btnNewProduct.TabIndex = 18;
            btnNewProduct.Text = "Add New Product";
            btnNewProduct.UseVisualStyleBackColor = false;
            btnNewProduct.Click += btnNewProduct_Click;
            // 
            // btnLogout
            // 
            btnLogout.AccessibleRole = AccessibleRole.None;
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(1550, 13);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 51);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // productPanel
            // 
            productPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            productPanel.AutoScroll = true;
            productPanel.Location = new Point(33, 116);
            productPanel.Name = "productPanel";
            productPanel.Size = new Size(901, 799);
            productPanel.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1685, 940);
            Controls.Add(productPanel);
            Controls.Add(btnLogout);
            Controls.Add(btnNewProduct);
            Controls.Add(lblWelcome);
            Controls.Add(changePrice);
            Controls.Add(label1);
            Controls.Add(tenderedMoney);
            Controls.Add(label3);
            Controls.Add(amountPrice);
            Controls.Add(label2);
            Controls.Add(transactionButton);
            Controls.Add(dataGridTable);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridTable;
        private Button transactionButton;
        private Label label2;
        private Label amountPrice;
        private Label label3;
        private TextBox tenderedMoney;
        private Label label1;
        private Label changePrice;
        private Label lblWelcome;
        private Button btnNewProduct;
        private Button btnLogout;
        private Panel productPanel;
    }
}
