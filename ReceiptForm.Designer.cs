namespace StarBuko
{
    partial class ReceiptForm
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

            this.reportViewer1.Dock = DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 600);
            this.reportViewer1.TabIndex = 0;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReceiptForm";
            this.Text = "Transaction Receipt";
            this.Load += ReceiptForm_Load;
            this.ResumeLayout(false);
        }

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}