using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        private const string ConnectionString = "Data Source=ClientDatabase.sqlite";

        public Product_Form()
        {
            InitializeComponent();
            products = new List<Product>();
        }
        ErrorProvider errorProvider =new ErrorProvider();
        List<Product> products = new List<Product>();
       

        private void createProduct(Product product)
        {
            string query = "INSERT INTO Product (productName, productType, productStock, productPrice, isAvailable) values " +
                " (@name, @type, @stock, @price, @availability);";

            using(SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command=new SQLiteCommand(query,connection);
                command.Parameters.AddWithValue("@name", product.productName);
                command.Parameters.AddWithValue("@type", product.productType.ToString());
                command.Parameters.AddWithValue("@stock", product.productStock);
                command.Parameters.AddWithValue("@price", product.productPrice);
                command.Parameters.AddWithValue("@availability", product.IsAvailable);

                command.ExecuteNonQuery();

            }
        }


        private void readProduct()
        {
            string query = "Select* from Product;";

            using(SQLiteConnection connection=new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string name = (string)reader["productName"];
                        long price = (long)reader["productPrice"];
                        long stock = (long)reader["productStock"];
                        bool av = bool.TryParse(reader["isAvailable"].ToString(), out av);
                        FlowerEnum f = Enum.TryParse(reader["productType"].ToString(), out FlowerEnum parsedEnum) ? parsedEnum : FlowerEnum.Default;


                        Product product =new Product(price, name, av,f, (int)stock);
                        products.Add(product);
                    }
                }
            }
        }

        private void updateProduct(Product product, string oldname)
        {
            string query = "UPDATE Product set productType=@type, productPrice=@price, isAvailable=@avail" +
                ", productStock=@stock,productName=@name where productName=@oldname; ";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", product.productName);
                command.Parameters.AddWithValue("@price", product.productPrice);
                command.Parameters.AddWithValue("@avail", product.IsAvailable);
                command.Parameters.AddWithValue("@stock", product.productStock);
                command.Parameters.AddWithValue("@type", product.productType);
                command.Parameters.AddWithValue("@oldname", oldname);

                command.ExecuteNonQuery();

                foreach (var p in products)
                {
                    if (p.productName == product.productName)
                    {
                        p.productType = product.productType;
                        p.productPrice = product.productPrice;
                        p.IsAvailable = product.IsAvailable;
                        p.productStock = product.productStock;
                        break; 
                    }
                }
            }
        }



        private void Product_Form_Load(object sender, EventArgs e)
        {
            
            cbTypeFlower.DataSource=  Enum.GetValues(typeof(FlowerEnum));
            readProduct();
            DisplayProducts();

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

            createProduct(_product);
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
                string oldname=selectedProduct.productName.ToString(); ;
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
                updateProduct(selectedProduct, oldname);
                
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                var _product = lvProducts.SelectedItems[0].Tag as Product;

                DeleteProduct(_product.productName);
                //readProduct();
               products.Remove(_product);
                ResetForm();
                DisplayProducts();

            }
        }

        private void DeleteProduct(string name)
        {
            string query = "DELETE FROM Product where productName=@name;";
            using (SQLiteConnection connection =new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command=new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);

                command.ExecuteNonQuery();
            }
        }

        private void lvProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                var selectedProduct = lvProducts.SelectedItems[0].Tag as Product;
                string oldname= selectedProduct.productName;

                numStock.Value = selectedProduct.productStock;
                tbPrice.Text = selectedProduct.productPrice.ToString();
                tbTitle.Text=selectedProduct.productName.ToString();
                ckBAvailability.Checked=selectedProduct.IsAvailable.Equals(true);
                cbTypeFlower.Text=selectedProduct.productType.ToString();

                updateProduct(selectedProduct, oldname);
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
