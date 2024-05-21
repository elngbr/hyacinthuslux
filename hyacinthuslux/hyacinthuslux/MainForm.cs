using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        private BindingList<Delivery> _deliveries;
        private Dictionary<string, int> _initialProductStocks;
        private Dictionary<string, int> _remainingProductStocks;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainForm()
        {
            InitializeComponent();
            _deliveries = new BindingList<Delivery>();
            _initialProductStocks = new Dictionary<string, int>();
            _remainingProductStocks = new Dictionary<string, int>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadInitialProductStocks();
            UpdateRemainingProductStocks();

            // Disable auto generation of columns
            dataGridViewDeliveries.AutoGenerateColumns = false;

            // Clear any existing columns first
            dataGridViewDeliveries.Columns.Clear();

            // Add custom columns
            dataGridViewDeliveries.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeliveryClient",
                HeaderText = "Client Name",
                Name = "DeliveryClientColumn"
            });
            dataGridViewDeliveries.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "deliveryDate",
                HeaderText = "Delivery Date",
                Name = "DeliveryDateColumn"
            });
            dataGridViewDeliveries.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "deliveryLocation",
                HeaderText = "Delivery Location",
                Name = "DeliveryLocationColumn"
            });
            dataGridViewDeliveries.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "deliveryMethod",
                HeaderText = "Delivery Method",
                Name = "DeliveryMethodColumn"
            });
            dataGridViewDeliveries.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                Name = "DeliveryTotalColumn"
            });
            // Add other columns similarly if needed

            // Bind the data source
            dataGridViewDeliveries.DataSource = _deliveries;
        }


        private void LoadInitialProductStocks()
        {
            _initialProductStocks.Clear();
            string query = "SELECT productName, productStock FROM Product WHERE isAvailable = 1;";

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=ClientDatabase.sqlite"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["productName"].ToString();
                        int stock = Convert.ToInt32(reader["productStock"]);
                        _initialProductStocks[name] = stock;
                    }
                }
                connection.Close();
            }

            _remainingProductStocks = new Dictionary<string, int>(_initialProductStocks);
        }

        private void UpdateRemainingProductStocks()
        {
            _remainingProductStocks = new Dictionary<string, int>(_initialProductStocks);

            foreach (var delivery in _deliveries)
            {
                for (int i = 0; i < delivery.DeliveryProducts.Count; i++)
                {
                    string productName = delivery.DeliveryProducts[i].productName;
                    int quantity = delivery.deliveryQuantities[i];

                    if (_remainingProductStocks.ContainsKey(productName))
                    {
                        _remainingProductStocks[productName] -= quantity;
                    }
                }
            }
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            Client_Form form = new Client_Form();
            form.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product_Form form = new Product_Form();
            form.Show();
        }

        private void addDeliveryBtn_Click(object sender, EventArgs e)
        {
            Delivery_Form form = new Delivery_Form(_remainingProductStocks);
            form.DeliverySaved += DeliveryForm_DeliverySaved;
            form.Show();
        }

        private void DeliveryForm_DeliverySaved(object sender, DeliveryEventArgs e)
        {
            Delivery delivery = e.Delivery;
            _deliveries.Add(delivery);

            UpdateRemainingProductStocks();
            OnPropertyChanged(nameof(_deliveries));
        }

        private void btnDeleteDelivery_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeliveries.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDeliveries.SelectedRows[0];
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected delivery?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string clientName = selectedRow.Cells[0].Value.ToString();
                    int clientId = (int)selectedRow.Cells[1].Value;
                    var deliveryToRemove = _deliveries.FirstOrDefault(d => d.DeliveryClient.clientId == clientId && d.DeliveryClient.clientFirstName + " " + d.DeliveryClient.clientLastName == clientName);

                    if (deliveryToRemove != null)
                    {
                        _deliveries.Remove(deliveryToRemove);
                    }

                    MessageBox.Show("Delivery deleted successfully.", "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateRemainingProductStocks();
                    OnPropertyChanged(nameof(_deliveries));
                }
            }
            else
            {
                MessageBox.Show("Please select a delivery to delete.", "No Delivery Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CouriersPieChart_Click(object sender, EventArgs e)
        {
            var courierDistribution = _deliveries
                .GroupBy(d => d.deliveryMethod)
                .ToDictionary(g => g.Key, g => g.Count());

            CouriersDistribution form = new CouriersDistribution(courierDistribution);
            form.Show();
        }

        private void CouriersBarChart_Click(object sender, EventArgs e)
        {
            var courierDistribution = _deliveries
                .GroupBy(d => d.deliveryMethod)
                .ToDictionary(g => g.Key, g => g.Count());

            BarChartCouriers form = new BarChartCouriers(courierDistribution);
            form.Show();
        }

        private void btnUserCtrl_Click(object sender, EventArgs e)
        {
            UserControlChart userControlChart = new UserControlChart();
            userControlChart.Show();

            List<string> labelsList = new List<string>();
            List<int> dataList = new List<int>();

            foreach (var delivery in _deliveries)
            {
                string deliveryMethodString = delivery.deliveryMethod.ToString();
                int index = labelsList.IndexOf(deliveryMethodString);
                if (index != -1)
                {
                    dataList[index]++;
                }
                else
                {
                    labelsList.Add(deliveryMethodString);
                    dataList.Add(1);
                }
            }

            string[] labelsArray = labelsList.ToArray();
            int[] dataArray = dataList.ToArray();

            userControlChart.SetChart(labelsArray, dataArray);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void dataGridViewDeliveries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}