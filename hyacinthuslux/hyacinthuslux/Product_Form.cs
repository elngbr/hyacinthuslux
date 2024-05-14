﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(tbTitle.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbTitle, "It is mandatory to have a title!");

            }

            if (String.IsNullOrWhiteSpace(tbTitle.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbTitle, "It is mandatory to have a title!");

            }

            if(tbTitle.Text.Length <2) 
            {
                e.Cancel = true;
                errorProvider.SetError(tbTitle, "Flower Name too short!");
            }
        }

        private void tbPrice_Validating(object sender, CancelEventArgs e)
        {
            decimal price=decimal.Parse(tbPrice.Text);
            if(price>600 || price <0)
            {
                e.Cancel = true;
                errorProvider.SetError(tbPrice, "Invalid price!");
            }
        }

        private void numStock_Validating(object sender, CancelEventArgs e)
        {
            if(numStock.Value>100)
            {
                e.Cancel = true;
                errorProvider.SetError(numStock, "Stock too large!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void SerializeBinary_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();

            if (svf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(svf.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, products);
                }
            }
        }

        private void DeserializeBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(ofd.FileName))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    products = (List<Product>)bf.Deserialize(fs);
                    DisplayProducts();

                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(svf.FileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Product>));

                    ser.Serialize(fs, products);
                }
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenRead(ofd.FileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Product>));
                    products = (List<Product>)ser.Deserialize(fs);
                    DisplayProducts();


                }
            }
        }
    }
}
