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


        private FlowerEnum selectedFlowerType;
        public ProductsForm()
        {
            InitializeComponent();

            comboBoxFlowerEnum.DataSource=Enum.GetValues(typeof(FlowerEnum));
        }

      
        

        private void comboBoxFlowerEnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFlowerType = (FlowerEnum)comboBoxFlowerEnum.SelectedItem;
        }
    }
}
