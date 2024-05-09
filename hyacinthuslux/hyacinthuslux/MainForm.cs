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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void addClientBtn_Click(object sender, EventArgs e)
        {
            Client_Form form=new Client_Form();
            form.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product_Form fomr=new Product_Form();   
            fomr.Show();
        }
    }
}
