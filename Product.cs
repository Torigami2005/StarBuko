namespace StarBuko
{
    public class Product
    {
        public int ProductId { get; set; }
        public string prodName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal itemPrice { get; set; }
        public string ImageName { get; set; } = "";
        public decimal totalPrice => ItemQuantity * itemPrice;
    }
}