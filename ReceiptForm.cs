using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StarBuko
{
    public partial class ReceiptForm : Form
    {
        private TransactionReportDTO _transaction;

        public ReceiptForm(TransactionReportDTO transaction)
        {
            InitializeComponent();
            _transaction = transaction;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "StarBuko.Receipt.rdlc";

            var parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("TransactionId", _transaction.TransactionId.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("CashierName", "Cashier: " + _transaction.CashierName),
                new Microsoft.Reporting.WinForms.ReportParameter("TransactionDate", "Date: " + _transaction.TransactionDate.ToString("MM/dd/yyyy hh:mm tt")),
                new Microsoft.Reporting.WinForms.ReportParameter("TotalAmount", "Total: ₱" + _transaction.TotalAmount.ToString("0.00")),
                new Microsoft.Reporting.WinForms.ReportParameter("Tendered", "Tendered: ₱" + _transaction.Tendered.ToString("0.00")),
                new Microsoft.Reporting.WinForms.ReportParameter("ChangeAmount", "Change: ₱" + _transaction.ChangeAmount.ToString("0.00"))
            };

            reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("ItemsDataSet",
                    new List<TransactionItemDTO>(_transaction.Items)));

            reportViewer1.RefreshReport();
        }
    }
}