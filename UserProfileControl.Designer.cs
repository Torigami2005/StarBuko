namespace StarBuko
{
    partial class UserProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            prodPicture = new PictureBox();
            itemName = new Label();
            priceValue = new Label();
            ((System.ComponentModel.ISupportInitialize)prodPicture).BeginInit();
            SuspendLayout();
            // 
            // prodPicture
            // 
            prodPicture.BackColor = Color.Silver;
            prodPicture.Location = new Point(25, 19);
            prodPicture.Name = "prodPicture";
            prodPicture.Size = new Size(100, 100);
            prodPicture.SizeMode = PictureBoxSizeMode.Zoom;
            prodPicture.TabIndex = 0;
            prodPicture.TabStop = false;
            prodPicture.Click += prodPicture_Click;
            // 
            // itemName
            // 
            itemName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemName.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            itemName.ForeColor = SystemColors.ButtonHighlight;
            itemName.Location = new Point(199, 19);
            itemName.Name = "itemName";
            itemName.Size = new Size(108, 66);
            itemName.TabIndex = 1;
            itemName.Text = "label1";
            itemName.TextAlign = ContentAlignment.TopRight;
            itemName.Click += itemName_Click;
            // 
            // priceValue
            // 
            priceValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            priceValue.AutoSize = true;
            priceValue.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceValue.ForeColor = SystemColors.ButtonHighlight;
            priceValue.Location = new Point(199, 87);
            priceValue.Name = "priceValue";
            priceValue.Size = new Size(88, 32);
            priceValue.TabIndex = 2;
            priceValue.Text = "label2";
            // 
            // UserProfileControl
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 53, 44);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(prodPicture);
            Controls.Add(priceValue);
            Controls.Add(itemName);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UserProfileControl";
            Size = new Size(321, 138);
            Load += UserProfileControl_Load;
            ((System.ComponentModel.ISupportInitialize)prodPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox prodPicture;
        private Label itemName;
        private Label priceValue;
    }
}
