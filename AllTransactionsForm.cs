using Microsoft.Reporting.WinForms;
using System.Data;

namespace StarBuko
{
    public partial class AllTransactionsForm : Form
    {
        private ReportViewer reportViewer1;

        public AllTransactionsForm()
        {
            InitializeComponent();

            // Add ReportViewer manually
            reportViewer1 = new ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
        }

        private void AllTransactionsForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "StarBuko.AllTransactions.rdlc";

            var transactions = new TransactionRepository().GetAllTransactions();

            var dataTable = new DataTable();
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