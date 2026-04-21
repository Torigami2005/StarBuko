using Microsoft.Reporting.WinForms;

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

            // Set parameters
            var parameters = new ReportParameter[]
            {
                new ReportParameter("TransactionId", _transaction.TransactionId.ToString()),
                new ReportParameter("CashierName", "Cashier: " + _transaction.CashierName),
                new ReportParameter("TransactionDate", "Date: " + _transaction.TransactionDate.ToString("MM/dd/yyyy hh:mm tt")),
                new ReportParameter("TotalAmount", "Total: ₱" + _transaction.TotalAmount.ToString("0.00")),
                new ReportParameter("Tendered", "Tendered: ₱" + _transaction.Tendered.ToString("0.00")),
                new ReportParameter("ChangeAmount", "Change: ₱" + _transaction.ChangeAmount.ToString("0.00"))
            };
            reportViewer1.LocalReport.SetParameters(parameters);

            // Set data source
            var itemsTable = new System.Data.DataTable();
            itemsTable.Columns.Add("ProdName");
            itemsTable.Columns.Add("ItemPrice");
            itemsTable.Columns.Add("Quantity");
            itemsTable.Columns.Add("SubTotal");

            foreach (var item in _transaction.Items)
            {
                itemsTable.Rows.Add(item.ProdName, item.ItemPrice, item.Quantity, item.SubTotal);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("ItemsDataSet", itemsTable));

            reportViewer1.RefreshReport();
        }
    }
}