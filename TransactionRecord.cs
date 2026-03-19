using System.IO.Packaging;

namespace StarBuko
{
    public class TransactionRecord
    {
        public int CashierId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tendered { get; set; }
        public decimal ChangeAmount { get; set; }
        public List<TransactionItem> Items { get; set; }
    }

    public class TransactionItem
    {
        public string ProdName { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }
    }
}
//```

//---

//## Step 3 — Datastore

//First, install MySQL connector via NuGet Package Manager Console:
//```
//Install - Package MySql.Data