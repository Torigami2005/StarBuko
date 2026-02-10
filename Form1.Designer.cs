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
            prodName = new DataGridViewTextBoxColumn();
            ItemQuantity = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            DragDrink = new UserProfileControl();
            MatchLatt = new UserProfileControl();
            PinkDrink = new UserProfileControl();
            StrawCream = new UserProfileControl();
            StrawAcai = new UserProfileControl();
            XOXOFrap = new UserProfileControl();
            ((System.ComponentModel.ISupportInitialize)dataGridTable).BeginInit();
            SuspendLayout();
            // 
            // chocoChip
            // 
            chocoChip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            DarkCaraFrap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DarkCaraFrap.BackColor = Color.FromArgb(3, 53, 44);
            DarkCaraFrap.BorderStyle = BorderStyle.FixedSingle;
            DarkCaraFrap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DarkCaraFrap.LabelPrice = "₱ 160.00";
            DarkCaraFrap.Location = new Point(28, 183);
            DarkCaraFrap.Margin = new Padding(4);
            DarkCaraFrap.Name = "DarkCaraFrap";
            DarkCaraFrap.PictureBoxImage = null;
            DarkCaraFrap.Size = new Size(384, 140);
            DarkCaraFrap.TabIndex = 1;
            DarkCaraFrap.Title = "Dark Caramel Frappucino";
            DarkCaraFrap.Load += DarkCaraFrap_Load;
            // 
            // dataGridTable
            // 
            dataGridTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTable.Columns.AddRange(new DataGridViewColumn[] { prodName, ItemQuantity, Column3, Column4, Column5, Column6 });
            dataGridTable.Location = new Point(821, 72);
            dataGridTable.Name = "dataGridTable";
            dataGridTable.Size = new Size(641, 288);
            dataGridTable.TabIndex = 2;
            dataGridTable.CellContentClick += dataGridTable_CellContentClick;
            // 
            // prodName
            // 
            prodName.HeaderText = "ProductName";
            prodName.Name = "prodName";
            // 
            // ItemQuantity
            // 
            ItemQuantity.HeaderText = "Quantity";
            ItemQuantity.Name = "ItemQuantity";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            // 
            // DragDrink
            // 
            DragDrink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DragDrink.BackColor = Color.FromArgb(3, 53, 44);
            DragDrink.BorderStyle = BorderStyle.FixedSingle;
            DragDrink.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DragDrink.LabelPrice = "₱ 100.00";
            DragDrink.Location = new Point(28, 331);
            DragDrink.Margin = new Padding(4);
            DragDrink.Name = "DragDrink";
            DragDrink.PictureBoxImage = null;
            DragDrink.Size = new Size(384, 140);
            DragDrink.TabIndex = 3;
            DragDrink.Title = "Dragon Drink";
            DragDrink.Load += DragDrink_Load;
            // 
            // MatchLatt
            // 
            MatchLatt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MatchLatt.BackColor = Color.FromArgb(3, 53, 44);
            MatchLatt.BorderStyle = BorderStyle.FixedSingle;
            MatchLatt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MatchLatt.LabelPrice = "₱ 125.00";
            MatchLatt.Location = new Point(28, 479);
            MatchLatt.Margin = new Padding(4);
            MatchLatt.Name = "MatchLatt";
            MatchLatt.PictureBoxImage = null;
            MatchLatt.Size = new Size(384, 140);
            MatchLatt.TabIndex = 4;
            MatchLatt.Title = "Matcha Latte";
            MatchLatt.Load += MatchLatt_Load;
            // 
            // PinkDrink
            // 
            PinkDrink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PinkDrink.BackColor = Color.FromArgb(3, 53, 44);
            PinkDrink.BorderStyle = BorderStyle.FixedSingle;
            PinkDrink.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PinkDrink.LabelPrice = "₱ 155.00";
            PinkDrink.Location = new Point(420, 35);
            PinkDrink.Margin = new Padding(4);
            PinkDrink.Name = "PinkDrink";
            PinkDrink.PictureBoxImage = null;
            PinkDrink.Size = new Size(384, 140);
            PinkDrink.TabIndex = 5;
            PinkDrink.Title = "Pink Drink";
            PinkDrink.Load += PinkDrink_Load;
            // 
            // StrawCream
            // 
            StrawCream.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StrawCream.BackColor = Color.FromArgb(3, 53, 44);
            StrawCream.BorderStyle = BorderStyle.FixedSingle;
            StrawCream.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StrawCream.LabelPrice = "₱ 140.00";
            StrawCream.Location = new Point(420, 183);
            StrawCream.Margin = new Padding(4);
            StrawCream.Name = "StrawCream";
            StrawCream.PictureBoxImage = null;
            StrawCream.Size = new Size(384, 140);
            StrawCream.TabIndex = 6;
            StrawCream.Title = "Strawberry Cream";
            StrawCream.Load += StrawCream_Load;
            // 
            // StrawAcai
            // 
            StrawAcai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StrawAcai.BackColor = Color.FromArgb(3, 53, 44);
            StrawAcai.BorderStyle = BorderStyle.FixedSingle;
            StrawAcai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StrawAcai.LabelPrice = "₱ 180.00";
            StrawAcai.Location = new Point(420, 331);
            StrawAcai.Margin = new Padding(4);
            StrawAcai.Name = "StrawAcai";
            StrawAcai.PictureBoxImage = null;
            StrawAcai.Size = new Size(384, 140);
            StrawAcai.TabIndex = 7;
            StrawAcai.Title = "Strawberry Acai";
            StrawAcai.Load += StrawAcai_Load;
            // 
            // XOXOFrap
            // 
            XOXOFrap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            XOXOFrap.BackColor = Color.FromArgb(3, 53, 44);
            XOXOFrap.BorderStyle = BorderStyle.FixedSingle;
            XOXOFrap.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            XOXOFrap.LabelPrice = "₱ 115.00";
            XOXOFrap.Location = new Point(420, 479);
            XOXOFrap.Margin = new Padding(4);
            XOXOFrap.Name = "XOXOFrap";
            XOXOFrap.PictureBoxImage = null;
            XOXOFrap.Size = new Size(384, 140);
            XOXOFrap.TabIndex = 8;
            XOXOFrap.Title = "XOXO Frappucino";
            XOXOFrap.Load += XOXOFrap_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 653);
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
        private DataGridViewTextBoxColumn prodName;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
