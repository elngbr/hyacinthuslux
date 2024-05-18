using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class Delivery_Form : Form
    {
        
        private List<Delivery> deliveryList;

        private const string ConnectionString = "Data Source=ClientDatabase.sqlite";
        public Delivery_Form()
        {
            InitializeComponent();
            this.deliveryList=new List<Delivery>();
        }

        private void Delivery_Form_Load(object sender, EventArgs e)
        {


            PopulateComboBoxClients();
            PopulateComboBoxProducts();
        }

        private void PopulateComboBoxProducts()
        {
            comboBoxProducts.Items.Clear();
            string query = "Select productName, productType from Product;";
            using(SQLiteConnection connection=new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command=new SQLiteCommand(query, connection);
                using(SQLiteDataReader reader =command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string name = (string)reader["productName"];
                        string type = (string)reader["productType"];

                        StringBuilder fullRow=new StringBuilder();
                        fullRow.Append(name);
                        fullRow.Append("->");
                        fullRow.Append(type);


                        comboBoxProducts.Items.Add(fullRow.ToString());
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

            
            string query = "SELECT clientId, clientFirstName, clientLastName FROM Client;";

            
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["clientId"];
                        string clientId=id.ToString();
                        string firstName = (string)reader["clientFirstName"];
                        string lastName = (string)reader["clientLastName"];

                       
                        string fullRow = $"{clientId} {firstName} {lastName}";

                        
                        comboBoxClients.Items.Add(fullRow);
                    }
                }
            }

           
            
            if (comboBoxClients.Items.Count > 0)
            {
                comboBoxClients.SelectedIndex = 0;
            }
        }


        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
