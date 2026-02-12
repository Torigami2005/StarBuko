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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            chocoChip = new UserProfileControl();
            DarkCaraFrap = new UserProfileControl();
            dataGridTable = new DataGridView();
            DragDrink = new UserProfileControl();
            MatchLatt = new UserProfileControl();
            PinkDrink = new UserProfileControl();
            StrawCream = new UserProfileControl();
            StrawAcai = new UserProfileControl();
            XOXOFrap = new UserProfileControl();
            transactionButton = new Button();
            label2 = new Label();
            amountPrice = new Label();
            label3 = new Label();
            tenderedMoney = new TextBox();
            label1 = new Label();
            changePrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridTable).BeginInit();
            SuspendLayout();
            // 
            // chocoChip
            // 
            chocoChip.BackColor = Color.FromArgb(3, 53, 44);
            chocoChip.BorderStyle = BorderStyle.FixedSingle;
            chocoChip.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chocoChip.LabelPrice = "₱ 135.00";
            chocoChip.Location = new Point(28, 35);
            chocoChip.Margin = new Padding(4);
            chocoChip.Name = "chocoChip";
            chocoChip.PictureBoxImage = (Image)resources.GetObject("chocoChip.PictureBoxImage");
            chocoChip.Size = new Size(384, 140);
            chocoChip.TabIndex = 0;
            chocoChip.Title = "Chocolate Chip";
            chocoChip.Load += chocoChip_Load;
            // 
            // DarkCaraFrap
            // 
            DarkCaraFrap.BackColor = Color.FromArgb(3, 53, 44);
            DarkCaraFrap.BorderStyle = BorderStyle.FixedSingle;
            DarkCaraFrap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DarkCaraFrap.LabelPrice = "₱ 160.00";
            DarkCaraFrap.Location = new Point(28, 183);
            DarkCaraFrap.Margin = new Padding(4);
            DarkCaraFrap.Name = "DarkCaraFrap";
            DarkCaraFrap.PictureBoxImage = (Image)resources.GetObject("DarkCaraFrap.PictureBoxImage");
            DarkCaraFrap.Size = new Size(384, 140);
            DarkCaraFrap.TabIndex = 1;
            DarkCaraFrap.Title = "Dark Caramel Frappucino";
            DarkCaraFrap.Load += DarkCaraFrap_Load;
            // 
            // dataGridTable
            // 
            dataGridTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTable.Location = new Point(821, 72);
            dataGridTable.Name = "dataGridTable";
            dataGridTable.Size = new Size(641, 399);
            dataGridTable.TabIndex = 2;
            dataGridTable.CellContentClick += dataGridTable_CellContentClick;
            // 
            // DragDrink
            // 
            DragDrink.BackColor = Color.FromArgb(3, 53, 44);
            DragDrink.BorderStyle = BorderStyle.FixedSingle;
            DragDrink.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DragDrink.LabelPrice = "₱ 100.00";
            DragDrink.Location = new Point(28, 331);
            DragDrink.Margin = new Padding(4);
            DragDrink.Name = "DragDrink";
            DragDrink.PictureBoxImage = (Image)resources.GetObject("DragDrink.PictureBoxImage");
            DragDrink.Size = new Size(384, 140);
            DragDrink.TabIndex = 3;
            DragDrink.Title = "Dragon Drink";
            DragDrink.Load += DragDrink_Load;
            // 
            // MatchLatt
            // 
            MatchLatt.BackColor = Color.FromArgb(3, 53, 44);
            MatchLatt.BorderStyle = BorderStyle.FixedSingle;
            MatchLatt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MatchLatt.LabelPrice = "₱ 125.00";
            MatchLatt.Location = new Point(28, 479);
            MatchLatt.Margin = new Padding(4);
            MatchLatt.Name = "MatchLatt";
            MatchLatt.PictureBoxImage = (Image)resources.GetObject("MatchLatt.PictureBoxImage");
            MatchLatt.Size = new Size(384, 140);
            MatchLatt.TabIndex = 4;
            MatchLatt.Title = "Matcha Latte";
            MatchLatt.Load += MatchLatt_Load;
            // 
            // PinkDrink
            // 
            PinkDrink.BackColor = Color.FromArgb(3, 53, 44);
            PinkDrink.BorderStyle = BorderStyle.FixedSingle;
            PinkDrink.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PinkDrink.LabelPrice = "₱ 155.00";
            PinkDrink.Location = new Point(420, 35);
            PinkDrink.Margin = new Padding(4);
            PinkDrink.Name = "PinkDrink";
            PinkDrink.PictureBoxImage = (Image)resources.GetObject("PinkDrink.PictureBoxImage");
            PinkDrink.Size = new Size(384, 140);
            PinkDrink.TabIndex = 5;
            PinkDrink.Title = "Pink Drink";
            PinkDrink.Load += PinkDrink_Load;
            // 
            // StrawCream
            // 
            StrawCream.BackColor = Color.FromArgb(3, 53, 44);
            StrawCream.BorderStyle = BorderStyle.FixedSingle;
            StrawCream.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StrawCream.LabelPrice = "₱ 140.00";
            StrawCream.Location = new Point(420, 183);
            StrawCream.Margin = new Padding(4);
            StrawCream.Name = "StrawCream";
            StrawCream.PictureBoxImage = (Image)resources.GetObject("StrawCream.PictureBoxImage");
            StrawCream.Size = new Size(384, 140);
            StrawCream.TabIndex = 6;
            StrawCream.Title = "Strawberry Cream";
            StrawCream.Load += StrawCream_Load;
            // 
            // StrawAcai
            // 
            StrawAcai.BackColor = Color.FromArgb(3, 53, 44);
            StrawAcai.BorderStyle = BorderStyle.FixedSingle;
            StrawAcai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StrawAcai.LabelPrice = "₱ 180.00";
            StrawAcai.Location = new Point(420, 331);
            StrawAcai.Margin = new Padding(4);
            StrawAcai.Name = "StrawAcai";
            StrawAcai.PictureBoxImage = (Image)resources.GetObject("StrawAcai.PictureBoxImage");
            StrawAcai.Size = new Size(384, 140);
            StrawAcai.TabIndex = 7;
            StrawAcai.Title = "Strawberry Acai";
            StrawAcai.Load += StrawAcai_Load;
            // 
            // XOXOFrap
            // 
            XOXOFrap.BackColor = Color.FromArgb(3, 53, 44);
            XOXOFrap.BorderStyle = BorderStyle.FixedSingle;
            XOXOFrap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            XOXOFrap.LabelPrice = "₱ 115.00";
            XOXOFrap.Location = new Point(420, 479);
            XOXOFrap.Margin = new Padding(4);
            XOXOFrap.Name = "XOXOFrap";
            XOXOFrap.PictureBoxImage = (Image)resources.GetObject("XOXOFrap.PictureBoxImage");
            XOXOFrap.Size = new Size(384, 140);
            XOXOFrap.TabIndex = 8;
            XOXOFrap.Title = "XOXO Frappucino";
            XOXOFrap.Load += XOXOFrap_Load;
            // 
            // transactionButton
            // 
            transactionButton.AccessibleRole = AccessibleRole.None;
            transactionButton.BackColor = Color.Green;
            transactionButton.ForeColor = SystemColors.ButtonHighlight;
            transactionButton.Location = new Point(1067, 28);
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
            label2.Location = new Point(892, 479);
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
            amountPrice.Location = new Point(1374, 479);
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
            label3.Location = new Point(851, 525);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 13;
            label3.Text = "Amount Tendered";
            label3.Click += label3_Click;
            // 
            // tenderedMoney
            // 
            tenderedMoney.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tenderedMoney.Location = new Point(1289, 534);
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
            label1.Location = new Point(946, 578);
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
            changePrice.Location = new Point(1374, 578);
            changePrice.Name = "changePrice";
            changePrice.Size = new Size(55, 30);
            changePrice.TabIndex = 16;
            changePrice.Text = "0.00";
            changePrice.Click += changePrice_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1474, 653);
            Controls.Add(changePrice);
            Controls.Add(label1);
            Controls.Add(tenderedMoney);
            Controls.Add(label3);
            Controls.Add(amountPrice);
            Controls.Add(label2);
            Controls.Add(transactionButton);
            Controls.Add(XOXOFrap);
            Controls.Add(StrawAcai);
            Controls.Add(StrawCream);
            Controls.Add(PinkDrink);
            Controls.Add(MatchLatt);
            Controls.Add(DragDrink);
            Controls.Add(dataGridTable);
            Controls.Add(DarkCaraFrap);
            Controls.Add(chocoChip);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserProfileControl chocoChip;
        private UserProfileControl DarkCaraFrap;
        private DataGridView dataGridTable;
        private UserProfileControl DragDrink;
        private UserProfileControl MatchLatt;
        private UserProfileControl PinkDrink;
        private UserProfileControl StrawCream;
        private UserProfileControl StrawAcai;
        private UserProfileControl XOXOFrap;
        private Button transactionButton;
        private Label label2;
        private Label amountPrice;
        private Label label3;
        private TextBox tenderedMoney;
        private Label label1;
        private Label changePrice;
    }
}
