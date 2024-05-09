using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class Product_Form : Form
    {
        public Product_Form()
        {
            InitializeComponent();
        }
        ErrorProvider errorProvider =new ErrorProvider();
        List<Product> products = new List<Product>();
       

        private void Product_Form_Load(object sender, EventArgs e)
        {
            products=new List<Product>();
            cbTypeFlower.DataSource=  Enum.GetValues(typeof(FlowerEnum));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal price;
            FlowerEnum type = (FlowerEnum)Enum.Parse(typeof(FlowerEnum), cbTypeFlower.Text);
            bool success = Decimal.TryParse(tbPrice.Text, out price);
            Product _product = new Product(price, tbTitle.Text, ckBAvailability.Checked, type, (int)numStock.Value);
            products.Add(_product);
            ResetForm();
            DisplayProducts();
        }


        private void ResetForm()
        {
            ckBAvailability.Checked = false;
            tbPrice.Text = tbTitle.Text = string.Empty;
            numStock.Value = 1;
            cbTypeFlower.Text = FlowerEnum.Hyacinth.ToString();

        }

        private void DisplayProducts()
        {
            lvProducts.Items.Clear();

            foreach (var _products in products)
            {
                {
                    var auxListItem = new ListViewItem(_products.productName);
                    auxListItem.SubItems.Add(_products.productPrice.ToString());
                    auxListItem.SubItems.Add(_products.productStock.ToString());
                    auxListItem.SubItems.Add(_products.productType.ToString());
                    auxListItem.SubItems.Add(_products.IsAvailable.ToString());
                   

                    auxListItem.Tag = _products;
                    lvProducts.Items.Add(auxListItem);

                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                var selectedProduct = lvProducts.SelectedItems[0].Tag as Product;

                decimal price;
                
                bool success = Decimal.TryParse(tbPrice.Text, out price);

                selectedProduct.productName=tbTitle.Text;
                selectedProduct.productPrice = price;
                selectedProduct.productStock = (int)numStock.Value;
                selectedProduct.productType= (FlowerEnum)Enum.Parse(typeof(FlowerEnum), cbTypeFlower.Text);
                selectedProduct.IsAvailable = ckBAvailability.Checked;

                lvProducts.SelectedItems[0].Text = tbTitle.Text;
                lvProducts.SelectedItems[0].SubItems[1].Text = price.ToString();
                lvProducts.SelectedItems[0].SubItems[2].Text = numStock.Value.ToString();
                lvProducts.SelectedItems[0].SubItems[3].Text = cbTypeFlower.Text;
                lvProducts.SelectedItems[0].SubItems[4].Text = ckBAvailability.Checked.ToString();
                
               
                ResetForm();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                var _product = lvProducts.SelectedItems[0].Tag as Product;


               products.Remove(_product);
                ResetForm();
                DisplayProducts();

            }
        }

        private void lvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                var selectedProduct = lvProducts.SelectedItems[0].Tag as Product;


                numStock.Value = selectedProduct.productStock;
                tbPrice.Text = selectedProduct.productPrice.ToString();
                tbTitle.Text=selectedProduct.productName.ToString();
                ckBAvailability.Checked=selectedProduct.IsAvailable.Equals(true);
                cbTypeFlower.Text=selectedProduct.productType.ToString();
            }
        }
    }
}
