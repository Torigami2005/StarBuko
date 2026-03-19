using MySql.Data.MySqlClient;

namespace StarBuko
{
    public class TransactionRepository
    {
        public void SaveTransaction(TransactionRecord record)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();

            string insertTx = @"INSERT INTO transactions (cashier_id, total_amount, tendered, change_amount)
                                VALUES (@cid, @total, @tendered, @change);
                                SELECT LAST_INSERT_ID();";
            using var cmd = new MySqlCommand(insertTx, conn, tx);
            cmd.Parameters.AddWithValue("@cid", record.CashierId);
            cmd.Parameters.AddWithValue("@total", record.TotalAmount);
            cmd.Parameters.AddWithValue("@tendered", record.Tendered);
            cmd.Parameters.AddWithValue("@change", record.ChangeAmount);
            int transactionId = Convert.ToInt32(cmd.ExecuteScalar());

            foreach (var item in record.Items)
            {
                string insertItem = @"INSERT INTO transaction_items (transaction_id, prod_name, item_price, quantity)
                                      VALUES (@tid, @name, @price, @qty)";
                using var itemCmd = new MySqlCommand(insertItem, conn, tx);
                itemCmd.Parameters.AddWithValue("@tid", transactionId);
                itemCmd.Parameters.AddWithValue("@name", item.ProdName);
                itemCmd.Parameters.AddWithValue("@price", item.ItemPrice);
                itemCmd.Parameters.AddWithValue("@qty", item.Quantity);
                itemCmd.ExecuteNonQuery();
            }

            tx.Commit();
        }
    }
}