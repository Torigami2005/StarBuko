namespace StarBuko
{
    public class TransactionReportDTO
    {
        public int TransactionId { get; set; }
        public string CashierName { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Tendered { get; set; }
        public decimal ChangeAmount { get; set; }
        public List<TransactionItemDTO> Items { get; set; }
    }

    public class TransactionItemDTO
    {
        public string ProdName { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal => ItemPrice * Quantity;
    }
}