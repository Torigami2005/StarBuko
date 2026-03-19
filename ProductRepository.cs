using MySql.Data.MySqlClient;

namespace StarBuko
{
    public class ProductRepository
    {
        public List<Product> GetActiveProducts()
        {
            var list = new List<Product>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string query = "SELECT product_id, prod_name, item_price FROM products WHERE is_active=1";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Product
                {
                    ProductId = reader.GetInt32("product_id"),
                    prodName = reader.GetString("prod_name"),
                    itemPrice = reader.GetDecimal("item_price")
                });
            }
            return list;
        }

        public void AddProduct(string name, decimal price)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string query = "INSERT INTO products (prod_name, item_price) VALUES (@n, @p)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.ExecuteNonQuery();
        }
    }
}