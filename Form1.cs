using System.ComponentModel;

namespace StarBuko
{

    public partial class Form1 : Form
    {

        private int _lastTransactionId = 0;
        private User _currentUser;
        private List<Product> products = new List<Product>();
        private BindingList<Product> cart = new BindingList<Product>();
        private List<UserProfileControl> productControls = new List<UserProfileControl>();

        public Form1(User user)
        {
            InitializeComponent();
            _currentUser = user;
            lblWelcome.Text = $"Welcome, {_currentUser.Username}!";
            btnNewProduct.Visible = _currentUser.Role == "admin";
            InitializeGrid();
            LoadProducts();
        }



        private void InitializeGrid()
        {
            dataGridTable.AutoGenerateColumns = false;
            dataGridTable.AllowUserToAddRows = false;
            dataGridTable.DataSource = cart;
            dataGridTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Product Name", DataPropertyName = "prodName", ReadOnly = true });
            dataGridTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "itemPrice", ReadOnly = true });
            dataGridTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "ItemQuantity", ReadOnly = true });
            dataGridTable.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "totalPrice", ReadOnly = true });
        }

        private void LoadProducts()
        {
            foreach (var ctrl in productControls)
            {
                productPanel.Controls.Remove(ctrl);
                ctrl.Dispose();
            }
            productControls.Clear();

            var repo = new ProductRepository();
            products = repo.GetActiveProducts();

            int x = 5, y = 5;
            int ctrlWidth = 430;
            int ctrlHeight = 180;
            int paddingX = 10;
            int paddingY = 10;

            foreach (var product in products)
            {
                var ctrl = new UserProfileControl
                {
                    Title = product.prodName,
                    LabelPrice = product.itemPrice.ToString("0.00"),
                    Size = new Size(ctrlWidth, ctrlHeight),
                    Location = new Point(x, y)
                };

                if (!string.IsNullOrEmpty(product.ImageName))
                {
                    string fullPath = Path.Combine(Application.StartupPath, "images", product.ImageName);
                    if (File.Exists(fullPath))
                        ctrl.PictureBoxImage = Image.FromFile(fullPath);
                }

                ctrl.ProductClicked += AddToCart;
                productControls.Add(ctrl);
                productPanel.Controls.Add(ctrl);

                x += ctrlWidth + paddingX;
                if (x + ctrlWidth > productPanel.Width)
                {
                    x = 5;
                    y += ctrlHeight + paddingY;
                }
            }
        }

        private void AddToCart(object sender, EventArgs e)
        {
            UserProfileControl control = (UserProfileControl)sender;
            string baseName = control.Title;
            decimal basePrice = Convert.ToDecimal(control.LabelPrice);

            DialogResult result = MessageBox.Show(
                "Select cup size:\nYes = Grande (+20)\nNo = Venti (+30)\nCancel = Regular",
                "Cup Size", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            string cupSize = "";
            decimal finalPrice = basePrice;

            if (result == DialogResult.Yes) { cupSize = "Grande"; finalPrice += 20m; }
            else if (result == DialogResult.No) { cupSize = "Venti"; finalPrice += 30m; }

            string displayName = string.IsNullOrEmpty(cupSize) ? baseName : $"{baseName} ({cupSize})";

            Product existing = cart.FirstOrDefault(p => p.prodName == displayName);
            if (existing != null) { existing.ItemQuantity++; dataGridTable.Refresh(); }
            else cart.Add(new Product { prodName = displayName, itemPrice = finalPrice, ItemQuantity = 1 });

            ComputeTotal();
        }

        private void ComputeTotal()
        {
            decimal sum = cart.Sum(p => p.totalPrice);
            amountPrice.Text = sum.ToString("0.00");
            if (decimal.TryParse(tenderedMoney.Text, out decimal tender))
                changePrice.Text = (tender - sum >= 0 ? tender - sum : 0).ToString("0.00");
        }

        private void tenderedMoney_TextChanged(object sender, EventArgs e) => ComputeTotal();

        private void transactionButton_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0) { MessageBox.Show("Cart is empty."); return; }
            if (!decimal.TryParse(tenderedMoney.Text, out decimal tender) || tender < cart.Sum(p => p.totalPrice))
            {
                MessageBox.Show("Please enter a valid tendered amount."); return;
            }

            var record = new TransactionRecord
            {
                CashierId = _currentUser.UserId,
                TotalAmount = cart.Sum(p => p.totalPrice),
                Tendered = tender,
                ChangeAmount = tender - cart.Sum(p => p.totalPrice),
                Items = cart.Select(p => new TransactionItem
                {
                    ProdName = p.prodName,
                    ItemPrice = p.itemPrice,
                    Quantity = p.ItemQuantity
                }).ToList()
            };

            new TransactionRepository().SaveTransaction(record);
            _lastTransactionId = record.TransactionId;
            MessageBox.Show("Transaction saved! You can now print the receipt.");

            cart.Clear();
            amountPrice.Text = "0.00";
            tenderedMoney.Text = "";
            changePrice.Text = "0.00";
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var newMain = new Form1(loginForm.LoggedInUser);
                newMain.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void dataGridTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void amountPrice_Click(object sender, EventArgs e) => ComputeTotal();
        private void changePrice_Click(object sender, EventArgs e) => ComputeTotal();

        private void btnNewProduct_Click_1(object sender, EventArgs e)
        {
            var form = new AddProductForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reportForm = new AllTransactionsForm();
            reportForm.ShowDialog();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (_lastTransactionId == 0)
            {
                MessageBox.Show("No transaction yet. Please complete a transaction first.");
                return;
            }

            var repo = new TransactionRepository();
            var transaction = repo.GetTransactionById(_lastTransactionId);

            if (transaction != null)
            {
                var receiptForm = new ReceiptForm(transaction);
                receiptForm.ShowDialog();
            }
        }


    }
}