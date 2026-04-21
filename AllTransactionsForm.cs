using Microsoft.Reporting.WebForms;

using Microsoft.Reporting.WinForms;

namespace StarBuko
{
    public partial class AllTransactionsForm : Form
    {
        public AllTransactionsForm()
        {
            InitializeComponent();
        }

        private void AllTransactionsForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "StarBuko.AllTransactions.rdlc";

            var transactions = new TransactionRepository().GetAllTransactions();

            var dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("TransactionId", typeof(int));
            dataTable.Columns.Add("CashierName", typeof(string));
            dataTable.Columns.Add("TransactionDate", typeof(DateTime));
            dataTable.Columns.Add("TotalAmount", typeof(decimal));
            dataTable.Columns.Add("Tendered", typeof(decimal));
            dataTable.Columns.Add("ChangeAmount", typeof(decimal));

            foreach (var t in transactions)
            {
                dataTable.Rows.Add(
                    t.TransactionId,
                    t.CashierName,
                    t.TransactionDate,
                    t.TotalAmount,
                    t.Tendered,
                    t.ChangeAmount
                );
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("TransactionsDataSet", dataTable));

            reportViewer1.RefreshReport();
        }
    }
}