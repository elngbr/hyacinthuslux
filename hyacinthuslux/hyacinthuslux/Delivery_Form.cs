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
        private int _editIndex = -1;
       
        public Delivery_Form()
        {
            InitializeComponent();
            _delivery = new Delivery
            {
                DeliveryProducts = new List<Product>(),
                deliveryQuantities = new List<int>()
            };

            comboBoxCourierMethod.SelectedIndexChanged += ComboBoxCourierMethod_SelectedIndexChanged;
        }

        private void Delivery_Form_Load(object sender, EventArgs e)
        {
            PopulateComboBoxClients();
            PopulateComboBoxProducts();
            PopulateComboBoxCourierMethods();

            if (_delivery != null && _delivery.DeliveryClient != null)
            {
                dtpDeliveryDate.Value = _delivery.deliveryDate;
                tbLocationDel.Text = _delivery.deliveryLocation;
                comboBoxClients.Text = _delivery.DeliveryClient.clientLastName.ToString();
            }

            // If it's a new delivery, set the initial total value based on the selected courier method
            if (_delivery.deliveryLocation == null)
            {
                EnumCourier.CourierEnum val = (EnumCourier.CourierEnum)Enum.Parse(typeof(EnumCourier.CourierEnum), comboBoxCourierMethod.Text);
                _delivery.deliveryMethod = val;
                UpdateTotalValue();
            }
        }

        private void ComboBoxCourierMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCourierMethod.SelectedItem != null)
            {
                EnumCourier.CourierEnum val = (EnumCourier.CourierEnum)Enum.Parse(typeof(EnumCourier.CourierEnum), comboBoxCourierMethod.SelectedItem.ToString());
                _delivery.deliveryMethod = val;
                UpdateTotalValue();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (_delivery != null)
            {
                if (comboBoxClients.SelectedItem != null)
                {
                    int clientId = (int)comboBoxClients.SelectedItem;
                    _delivery.DeliveryClient = SubtractClient(clientId);

                    if (!string.IsNullOrWhiteSpace(tbLocationDel.Text))
                    {
                        _delivery.deliveryLocation = tbLocationDel.Text;
                        _delivery.deliveryDate = dtpDeliveryDate.Value;

                        MessageBox.Show("Delivery information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a delivery location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void PopulateComboBoxCourierMethods()
        {
            comboBoxCourierMethod.Items.Clear();
            Array courierValues = Enum.GetValues(typeof(EnumCourier.CourierEnum));
            foreach (EnumCourier.CourierEnum courier in courierValues)
            {
                comboBoxCourierMethod.Items.Add(courier.ToString());
            }

            if (comboBoxCourierMethod.Items.Count > 0)
            {
                comboBoxCourierMethod.SelectedIndex = 0;
            }
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

                connection.Close();
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

                connection.Close();
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
            _editIndex = -1;
        }

        private void btnAddProdOrder_Click(object sender, EventArgs e)
        {
            if (_editIndex == -1)
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
                    UpdateTotalValue();
                }
            }
            else
            {
                if (comboBoxProducts.SelectedItem != null && numQuantity.Value > 0)
                {
                    string productName = (string)comboBoxProducts.SelectedItem;
                    Product updatedProduct = SubtractProduct(productName);
                    int quantity = (int)numQuantity.Value;

                    _delivery.DeliveryProducts[_editIndex] = updatedProduct;
                    _delivery.deliveryQuantities[_editIndex] = quantity;

                    ResetFormForProducts();
                    DisplayProducts();
                    UpdateTotalValue();
                }
            }
        }

        private void DisplayProducts()
        {
            dgvProductsForAnOrder.Rows.Clear();

            for (int i = 0; i < _delivery.DeliveryProducts.Count; i++)
            {
                Product product = _delivery.DeliveryProducts[i];
                int quantity = _delivery.deliveryQuantities[i];
                decimal unitPrice = product.productPrice;
                decimal total = unitPrice * quantity;

                dgvProductsForAnOrder.Rows.Add(product.productName, quantity, unitPrice, total);
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

                connection.Close();
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
                        long clientIdLong = (long)reader["clientId"];
                        int cId = (int)clientIdLong;

                        return new Client
                        {
                            clientId = cId,
                            clientFirstName = (string)reader["clientFirstName"],
                            clientLastName = (string)reader["clientLastName"],
                            clientEmail = (string)reader["clientEmail"],
                            clientAddress = (string)reader["clientAddress"],
                            clientPhoneNumber = (string)reader["clientPhoneNumber"],
                            clientLoyaltyPoints = reader.IsDBNull(reader.GetOrdinal("clientLoyaltyPoints")) ? 0.0 : Convert.ToDouble(reader["clientLoyaltyPoints"])
                        };
                    }
                }
                connection.Close();
            }
            return null;
        }

        private void dgvProductsForAnOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProductsForAnOrder.Rows.Count)
            {
                _editIndex = e.RowIndex;
                string productName = dgvProductsForAnOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                int quantity = (int)dgvProductsForAnOrder.Rows[e.RowIndex].Cells[1].Value;

                comboBoxProducts.SelectedItem = productName;
                numQuantity.Value = quantity;
            }
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            if (_editIndex != -1 && comboBoxProducts.SelectedItem != null && numQuantity.Value > 0)
            {
                string productName = (string)comboBoxProducts.SelectedItem;
                Product updatedProduct = SubtractProduct(productName);
                int quantity = (int)numQuantity.Value;

                _delivery.DeliveryProducts[_editIndex] = updatedProduct;
                _delivery.deliveryQuantities[_editIndex] = quantity;

                ResetFormForProducts();
                DisplayProducts();
                UpdateTotalValue();
                _editIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select a product and enter a quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveDelivery_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem != null && !string.IsNullOrWhiteSpace(tbLocationDel.Text))
            {
                int clientId = (int)comboBoxClients.SelectedItem;
                _delivery.DeliveryClient = SubtractClient(clientId);
                _delivery.deliveryLocation = tbLocationDel.Text;
                _delivery.deliveryDate = dtpDeliveryDate.Value;

                MessageBox.Show("Delivery saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a client and enter a delivery location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteProd_Click(object sender, EventArgs e)
        {
            if (dgvProductsForAnOrder.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvProductsForAnOrder.SelectedRows[0].Index;

                dgvProductsForAnOrder.Rows.RemoveAt(selectedIndex);

                if (_delivery.DeliveryProducts.Count > selectedIndex && _delivery.deliveryQuantities.Count > selectedIndex)
                {
                    _delivery.DeliveryProducts.RemoveAt(selectedIndex);
                    _delivery.deliveryQuantities.RemoveAt(selectedIndex);
                    UpdateTotalValue(); // Update total value
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTotalValue()
        {
            decimal productSubtotal = 0;

            // Calculate subtotal of products
            for (int i = 0; i < _delivery.DeliveryProducts.Count; i++)
            {
                productSubtotal += _delivery.DeliveryProducts[i].productPrice * _delivery.deliveryQuantities[i];
            }

            tbSubtotal.Text = productSubtotal.ToString("C2");

            // Update delivery cost
            decimal deliveryCost = (decimal)Delivery.ReturnCostBasedOnDeliveryMethod(_delivery);
            tbDeliveryCost.Text = deliveryCost.ToString("C2");

            // Calculate total value
            decimal totalValue = productSubtotal + deliveryCost;
            tbTotal.Text = totalValue.ToString("C2");
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCourierMethod_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxCourierMethod.SelectedItem != null)
            {
                EnumCourier.CourierEnum val = (EnumCourier.CourierEnum)Enum.Parse(typeof(EnumCourier.CourierEnum), comboBoxCourierMethod.SelectedItem.ToString());
                _delivery.deliveryMethod = val;
                UpdateTotalValue(); 
            }
        }

        private void tbDeliveryCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductsForAnOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
