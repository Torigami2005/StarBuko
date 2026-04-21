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
            btnReceipt = new Button();
            btnGenerateReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTable).BeginInit();
            SuspendLayout();
            // 
            // dataGridTable
            // 
            dataGridTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTable.Location = new Point(948, 87);
            dataGridTable.Name = "dataGridTable";
            dataGridTable.RowHeadersWidth = 51;
            dataGridTable.Size = new Size(612, 297);
            dataGridTable.TabIndex = 2;
            dataGridTable.CellContentClick += dataGridTable_CellContentClick;
            // 
            // transactionButton
            // 
            transactionButton.AccessibleRole = AccessibleRole.None;
            transactionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            transactionButton.BackColor = Color.Green;
            transactionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactionButton.ForeColor = SystemColors.ButtonHighlight;
            transactionButton.Location = new Point(1180, 390);
            transactionButton.Name = "transactionButton";
            transactionButton.Size = new Size(149, 38);
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
            label2.Location = new Point(991, 442);
            label2.Name = "label2";
            label2.Size = new Size(138, 30);
            label2.TabIndex = 11;
            label2.Text = "Total Amount";
            label2.Click += label2_Click;
            // 
            // amountPrice
            // 
            amountPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountPrice.AutoSize = true;
            amountPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountPrice.Location = new Point(1473, 442);
            amountPrice.Name = "amountPrice";
            amountPrice.Size = new Size(55, 30);
            amountPrice.TabIndex = 12;
            amountPrice.Text = "0.00";
            amountPrice.Click += amountPrice_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(950, 489);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 13;
            label3.Text = "Amount Tendered";
            label3.Click += label3_Click;
            // 
            // tenderedMoney
            // 
            tenderedMoney.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tenderedMoney.Location = new Point(1388, 497);
            tenderedMoney.Name = "tenderedMoney";
            tenderedMoney.Size = new Size(173, 23);
            tenderedMoney.TabIndex = 14;
            tenderedMoney.TextAlign = HorizontalAlignment.Right;
            tenderedMoney.TextChanged += tenderedMoney_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1045, 541);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 15;
            label1.Text = "Change";
            label1.Click += label1_Click;
            // 
            // changePrice
            // 
            changePrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            changePrice.AutoSize = true;
            changePrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changePrice.Location = new Point(1473, 541);
            changePrice.Name = "changePrice";
            changePrice.Size = new Size(55, 30);
            changePrice.TabIndex = 16;
            changePrice.Text = "0.00";
            changePrice.Click += changePrice_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(29, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(242, 30);
            lblWelcome.TabIndex = 17;
            lblWelcome.Text = "Welcome to Starbuko!";
            // 
            // btnNewProduct
            // 
            btnNewProduct.AccessibleRole = AccessibleRole.None;
            btnNewProduct.BackColor = Color.Green;
            btnNewProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewProduct.ForeColor = SystemColors.ButtonHighlight;
            btnNewProduct.Location = new Point(321, 42);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(204, 38);
            btnNewProduct.TabIndex = 18;
            btnNewProduct.Text = "Add New Product";
            btnNewProduct.UseVisualStyleBackColor = false;
            btnNewProduct.Click += btnNewProduct_Click;
            // 
            // btnLogout
            // 
            btnLogout.AccessibleRole = AccessibleRole.None;
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.Red;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(1453, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 38);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // productPanel
            // 
            productPanel.Anchor = AnchorStyles.Left;
            productPanel.AutoScroll = true;
            productPanel.Location = new Point(29, 87);
            productPanel.Margin = new Padding(3, 2, 3, 2);
            productPanel.Name = "productPanel";
            productPanel.Size = new Size(913, 599);
            productPanel.TabIndex = 20;
            // 
            // btnReceipt
            // 
            btnReceipt.AccessibleRole = AccessibleRole.None;
            btnReceipt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReceipt.BackColor = Color.Blue;
            btnReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReceipt.ForeColor = SystemColors.ButtonHighlight;
            btnReceipt.Location = new Point(1000, 611);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(149, 38);
            btnReceipt.TabIndex = 21;
            btnReceipt.Text = "Print Receipt";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.AccessibleRole = AccessibleRole.None;
            btnGenerateReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerateReport.BackColor = Color.Purple;
            btnGenerateReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = SystemColors.ButtonHighlight;
            btnGenerateReport.Location = new Point(1388, 611);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(149, 38);
            btnGenerateReport.TabIndex = 22;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1571, 705);
            Controls.Add(btnGenerateReport);
            Controls.Add(btnReceipt);
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
        private Button btnReceipt;
        private Button btnGenerateReport;
    }
}
