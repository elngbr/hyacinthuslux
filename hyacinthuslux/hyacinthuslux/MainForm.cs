using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class MainForm : Form
    {
        private List<Delivery> deliveries;

        public MainForm()
        {
            InitializeComponent();
            deliveries = new List<Delivery>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
            Delivery_Form form = new Delivery_Form();
            form.DeliverySaved += DeliveryForm_DeliverySaved;
            form.Show();
        }

        private void DeliveryForm_DeliverySaved(object sender, DeliveryEventArgs e)
        {
            Delivery delivery = e.Delivery;
            deliveries.Add(delivery);

            string clientName = $"{delivery.DeliveryClient.clientFirstName} {delivery.DeliveryClient.clientLastName}";

            StringBuilder products = new StringBuilder();
            StringBuilder quantities = new StringBuilder();
            for (int i = 0; i < delivery.DeliveryProducts.Count; i++)
            {
                products.Append(delivery.DeliveryProducts[i].productName);
                quantities.Append(delivery.deliveryQuantities[i]);
                if (i < delivery.DeliveryProducts.Count - 1)
                {
                    products.Append(", ");
                    quantities.Append(", ");
                }
            }

            dataGridViewDeliveries.Rows.Add(
                clientName,
                delivery.DeliveryClient.clientId,
                quantities.ToString(),
                products.ToString(),
                delivery.deliveryMethod,
                delivery.deliveryDate.ToShortDateString(),
                delivery.deliveryLocation,
                delivery.DeliveryTotalValue
            );
        }

        private void btnDeleteDelivery_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeliveries.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewDeliveries.SelectedRows[0];
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected delivery?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Find the delivery to delete from the list
                    string clientName = selectedRow.Cells[0].Value.ToString();
                    int clientId = (int)selectedRow.Cells[1].Value;
                    var deliveryToRemove = deliveries.FirstOrDefault(d => d.DeliveryClient.clientId == clientId && d.DeliveryClient.clientFirstName + " " + d.DeliveryClient.clientLastName == clientName);

                    if (deliveryToRemove != null)
                    {
                        deliveries.Remove(deliveryToRemove);
                    }

                    dataGridViewDeliveries.Rows.Remove(selectedRow);
                    MessageBox.Show("Delivery deleted successfully.", "Deletion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a delivery to delete.", "No Delivery Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CouriersPieChart_Click(object sender, EventArgs e)
        {
            var courierDistribution = deliveries
                .GroupBy(d => d.deliveryMethod)
                .ToDictionary(g => g.Key, g => g.Count());

            CouriersDistribution form = new CouriersDistribution(courierDistribution);
            form.Show();
        }

    }
}
