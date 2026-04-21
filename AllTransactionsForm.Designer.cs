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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();

            // reportViewer1
            this.reportViewer1.Dock = DockStyle.Fill;
            this.reportViewer1.Location = new Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new Size(900, 600);
            this.reportViewer1.TabIndex = 0;

            // AllTransactionsForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 600);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AllTransactionsForm";
            this.Text = "All Transactions Report";
            this.Load += AllTransactionsForm_Load;
            this.ResumeLayout(false);
        }

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}