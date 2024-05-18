using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class Delivery_Form : Form
    {
        private Delivery _delivery;
        private const string ConnectionString = "Data Source=ClientDatabase.sqlite";

        public Delivery_Form()
        {
            InitializeComponent();
            _delivery = new Delivery
            {
                DeliveryProducts = new List<Product>(),
                deliveryQuantities = new List<int>()
            };
        }

        private void Delivery_Form_Load(object sender, EventArgs e)
        {
            PopulateComboBoxClients();
            PopulateComboBoxProducts();
        }

        private void PopulateComboBoxProducts()
        {
            comboBoxProducts.Items.Clear();
            string query = "SELECT productName FROM Product;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = (string)reader["productName"];
                        comboBoxProducts.Items.Add(name);
                    }
                }
            }

            if (comboBoxProducts.Items.Count > 0)
            {
                comboBoxProducts.SelectedIndex = 0;
            }
        }

        private void PopulateComboBoxClients()
        {
            comboBoxClients.Items.Clear();
            string query = "SELECT clientId FROM Client;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long clientId = (long)reader["clientId"];
                        int id = (int)clientId;
                        comboBoxClients.Items.Add(id);
                    }
                }
            }

            if (comboBoxClients.Items.Count > 0)
            {
                comboBoxClients.SelectedIndex = 0;
            }
        }

        private void ResetFormForProducts()
        {
            comboBoxProducts.SelectedIndex = 0;
            numQuantity.Value = 0;
        }

        private void btnAddProdOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem != null && numQuantity.Value > 0)
            {
                string productName = (string)comboBoxProducts.SelectedItem;
                Product selectedProduct = SubtractProduct(productName);
                int quantity = (int)numQuantity.Value;

                _delivery.DeliveryProducts.Add(selectedProduct);
                _delivery.deliveryQuantities.Add(quantity);

                ResetFormForProducts();
                DisplayProducts();
            }
        }

        private void DisplayProducts()
        {
            dgvProductsForAnOrder.Rows.Clear();

            for (int i = 0; i < _delivery.DeliveryProducts.Count; i++)
            {
                Product product = _delivery.DeliveryProducts[i];
                int quantity = _delivery.deliveryQuantities[i];

                dgvProductsForAnOrder.Rows.Add(product.productName, quantity);
            }
        }

        private Product SubtractProduct(string productName)
        {
            string query = "SELECT * FROM Product WHERE productName = @productName";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@productName", productName);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Product
                        {
                            productName = reader["productName"].ToString(),
                            productPrice = reader.IsDBNull(reader.GetOrdinal("productPrice")) ? 0 : Convert.ToDecimal(reader["productPrice"]),
                            productType = (FlowerEnum)Enum.Parse(typeof(FlowerEnum), reader["productType"].ToString()),
                            productStock = reader.IsDBNull(reader.GetOrdinal("productStock")) ? 0 : Convert.ToInt32(reader["productStock"]),
                            IsAvailable = reader.IsDBNull(reader.GetOrdinal("isAvailable")) ? false : Convert.ToBoolean(reader["isAvailable"])
                        };
                    }
                }
            }
            return null;
        }


        private Client SubtractClient(int clientId)
        {
            string query = "SELECT * FROM Client WHERE clientId = @clientId";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@clientId", clientId);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Client
                        {
                            clientId = (int)reader["clientId"],
                            clientFirstName = (string)reader["clientFirstName"],
                            clientLastName = (string)reader["clientLastName"],
                            clientEmail = (string)reader["clientEmail"],
                            clientAddress = (string)reader["clientAddress"],
                            clientPhoneNumber = (string)reader["clientPhoneNumber"],
                            clientLoyaltyPoints = (double)reader["clientLoyaltyPoints"]
                        };
                    }
                }
            }
            return null;
        }

        private void btnSaveDelivery_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem != null && !string.IsNullOrWhiteSpace(tbLocationDel.Text))
            {
                int clientId = (int)comboBoxClients.SelectedItem;
                _delivery.DeliveryClient = SubtractClient(clientId);
                _delivery.deliveryLocation = tbLocationDel.Text;
                _delivery.deliveryDate = dtpDeliveryDate.Value;

                // Here you can save the delivery to the database or pass it back to the main form
                MessageBox.Show("Delivery saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a client and enter a delivery location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
