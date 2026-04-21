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
            string query = "SELECT product_id, prod_name, item_price, image_name FROM products WHERE is_active=1";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Product
                {
                    ProductId = reader.GetInt32("product_id"),
                    prodName = reader.GetString("prod_name"),
                    itemPrice = reader.GetDecimal("item_price"),
                    ImageName = reader.GetString("image_name")
                });
            }
            return list;
        }

        public void AddProduct(string name, decimal price, string imageName = "")
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            string query = "INSERT INTO products (prod_name, item_price, image_name) VALUES (@n, @p, @img)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@p", price);
            cmd.Parameters.AddWithValue("@img", imageName);
            cmd.ExecuteNonQuery();
        }
    }
}