using System.ComponentModel;

namespace StarBuko
{
    public partial class Form1 : Form
    {

        List<Product> products = new List<Product>();
        BindingList<Product> cart = new BindingList<Product>();
        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
            LoadProducts();
        }

        private void InitializeGrid()
        {
            dataGridTable.AutoGenerateColumns = false;
            dataGridTable.AllowUserToAddRows = false;

            dataGridTable.DataSource = cart;

            dataGridTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridTable.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Product Name",
                DataPropertyName = "prodName",
                ReadOnly = true
            });
            dataGridTable.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Price",
                DataPropertyName = "itemPrice",
                ReadOnly = true
            });
            dataGridTable.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Quantity",
                DataPropertyName = "ItemQuantity",
                ReadOnly = true
            });
            dataGridTable.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Total",
                DataPropertyName = "totalPrice",
                ReadOnly = true
            });
        }

        private void LoadProducts()
        {
            products = ProductsList.GetProducts();

            chocoChip.Title = products[0].prodName;
            chocoChip.LabelPrice = products[0].itemPrice.ToString("0.00");

            DarkCaraFrap.Title = products[1].prodName;
            DarkCaraFrap.LabelPrice = products[1].itemPrice.ToString("0.00");

            DragDrink.Title = products[2].prodName;
            DragDrink.LabelPrice = products[2].itemPrice.ToString("0.00");

            MatchLatt.Title = products[3].prodName;
            MatchLatt.LabelPrice = products[3].itemPrice.ToString("0.00");

            PinkDrink.Title = products[4].prodName;
            PinkDrink.LabelPrice = products[4].itemPrice.ToString("0.00");

            StrawCream.Title = products[5].prodName;
            StrawCream.LabelPrice = products[5].itemPrice.ToString("0.00");

            StrawAcai.Title = products[6].prodName;
            StrawAcai.LabelPrice = products[6].itemPrice.ToString("0.00");

            XOXOFrap.Title = products[7].prodName;
            XOXOFrap.LabelPrice = products[7].itemPrice.ToString("0.00");

            chocoChip.ProductClicked += AddToCart;
            DarkCaraFrap.ProductClicked += AddToCart;
            DragDrink.ProductClicked += AddToCart;
            MatchLatt.ProductClicked += AddToCart;
            PinkDrink.ProductClicked += AddToCart;
            StrawCream.ProductClicked += AddToCart;
            StrawAcai.ProductClicked += AddToCart;
            XOXOFrap.ProductClicked += AddToCart;
        }
        private void AddToCart(object sender, EventArgs e)
        {
            UserProfileControl control = (UserProfileControl)sender;
            string baseName = control.Title;
            decimal basePrice = Convert.ToDecimal(control.LabelPrice);

            DialogResult result = MessageBox.Show(
                "Select cup size:\nYes = Grande (+20)\nNo = Venti (+30)\nCancel = Regular",
                "Cup Size",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            string cupSize = "";
            decimal finalPrice = basePrice;

            if (result == DialogResult.Yes)
            {
                cupSize = "Grande";
                finalPrice += 20m;
            }
            else if (result == DialogResult.No)
            {
                cupSize = "Venti";
                finalPrice += 30m;
            }

            // Build product name with cup size
            string displayName = string.IsNullOrEmpty(cupSize) ? baseName : $"{baseName} ({cupSize})";

            Product existing = cart.FirstOrDefault(p => p.prodName == displayName);
            if (existing != null)
            {
                existing.ItemQuantity++;
                dataGridTable.Refresh();
            }
            else
            {
                cart.Add(new Product
                {
                    prodName = displayName,
                    itemPrice = finalPrice,
                    ItemQuantity = 1
                });
            }

            ComputeTotal();
        }


        private void userProfileControl1_Load(object sender, EventArgs e)
        {
        }

        private void chocoChip_Load(object sender, EventArgs e)
        {

        }

        private void DarkCaraFrap_Load(object sender, EventArgs e)
        {

        }
        private void DragDrink_Load(object sender, EventArgs e)
        {

        }

        private void MatchLatt_Load(object sender, EventArgs e)
        {

        }
        private void PinkDrink_Load(object sender, EventArgs e)
        {

        }

        private void StrawCream_Load(object sender, EventArgs e)
        {

        }

        private void StrawAcai_Load(object sender, EventArgs e)
        {

        }

        private void XOXOFrap_Load(object sender, EventArgs e)
        {

        }

        private void dataGridTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tenderedMoney_TextChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            decimal tender = 0;

            decimal.TryParse(amountPrice.Text, out total);

            if (decimal.TryParse(tenderedMoney.Text, out tender))
            {
                decimal change = tender - total;

                if (change >= 0)
                    changePrice.Text = change.ToString("0.00");
                else
                    changePrice.Text = change.ToString("0.00");
            }
            else
            {
                changePrice.Text = "0.00";
            }
        }

        private void ComputeTotal()
        {
            decimal sum = cart.Sum(p => p.totalPrice);
            amountPrice.Text = sum.ToString("0.00");

            if (decimal.TryParse(tenderedMoney.Text, out decimal tender))
            {
                decimal change = tender - sum;
                changePrice.Text = change >= 0 ? change.ToString("0.00") : "0.00";
            }
        }
        private void amountPrice_Click(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void changePrice_Click(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            cart.Clear();

            amountPrice.Text = "0.00";
            tenderedMoney.Text = "";
            changePrice.Text = "0.00";

        }
    }
}
