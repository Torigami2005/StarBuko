namespace StarBuko
{
    partial class AllTransactionsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 600);
            this.Name = "AllTransactionsForm";
            this.Text = "All Transactions Report";
            this.Load += AllTransactionsForm_Load;
            this.ResumeLayout(false);
        }
    }
}