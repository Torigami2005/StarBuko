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
            record.TransactionId = transactionId;
        }

        public TransactionReportDTO GetTransactionById(int transactionId)
        {
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string query = @"SELECT t.transaction_id, t.total_amount, t.tendered, t.change_amount, 
                            t.created_at, u.username
                            FROM transactions t
                            JOIN users u ON t.cashier_id = u.user_id
                            WHERE t.transaction_id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", transactionId);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                var dto = new TransactionReportDTO
                {
                    TransactionId = reader.GetInt32("transaction_id"),
                    CashierName = reader.GetString("username"),
                    TransactionDate = reader.GetDateTime("created_at"),
                    TotalAmount = reader.GetDecimal("total_amount"),
                    Tendered = reader.GetDecimal("tendered"),
                    ChangeAmount = reader.GetDecimal("change_amount"),
                    Items = new List<TransactionItemDTO>()
                };
                reader.Close();

                string itemQuery = "SELECT prod_name, item_price, quantity FROM transaction_items WHERE transaction_id = @id";
                using var itemCmd = new MySqlCommand(itemQuery, conn);
                itemCmd.Parameters.AddWithValue("@id", transactionId);
                using var itemReader = itemCmd.ExecuteReader();
                while (itemReader.Read())
                {
                    dto.Items.Add(new TransactionItemDTO
                    {
                        ProdName = itemReader.GetString("prod_name"),
                        ItemPrice = itemReader.GetDecimal("item_price"),
                        Quantity = itemReader.GetInt32("quantity")
                    });
                }
                return dto;
            }
            return null;
        }

        public List<TransactionReportDTO> GetAllTransactions()
        {
            var list = new List<TransactionReportDTO>();
            using var conn = DatabaseHelper.GetConnection();
            conn.Open();

            string query = @"SELECT t.transaction_id, t.total_amount, t.tendered, t.change_amount,
                            t.created_at, u.username
                            FROM transactions t
                            JOIN users u ON t.cashier_id = u.user_id
                            ORDER BY t.created_at DESC";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new TransactionReportDTO
                {
                    TransactionId = reader.GetInt32("transaction_id"),
                    CashierName = reader.GetString("username"),
                    TransactionDate = reader.GetDateTime("created_at"),
                    TotalAmount = reader.GetDecimal("total_amount"),
                    Tendered = reader.GetDecimal("tendered"),
                    ChangeAmount = reader.GetDecimal("change_amount")
                });
            }
            return list;
        }
    }
}