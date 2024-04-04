using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class ProductsForm : Form
    {


        private List<Product> products=new List<Product>();
        public ProductsForm()
        {
            InitializeComponent();

            comboBoxFlowerEnum.DataSource=Enum.GetValues(typeof(FlowerEnum));
        }

      
  

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

            try
            {
                decimal price = decimal.Parse(textBoxPrice.Text);
                string name = textBoxName.Text;
                bool availability = checkBoxAvailability.Checked;
                int stock = int.Parse(textBoxStock.Text);
                FlowerEnum flowerType = (FlowerEnum)comboBoxFlowerEnum.SelectedItem;

                Product product = new Product(price, name, availability, flowerType, stock);
                products.Add(product);




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      

        private void DisplayProducts()
        {
            
            listViewProducts.Items.Clear();
            foreach(var product in products)
            {
                var listItem = new ListViewItem(product.nameProduct);
                listItem.SubItems.Add(product.PriceProduct.ToString());
                listItem.SubItems.Add(product.ProductStock.ToString());
                listItem.SubItems.Add(product.flowerType.ToString());



                listViewProducts.Items.Add(listItem);
            }

        }
    }
}
