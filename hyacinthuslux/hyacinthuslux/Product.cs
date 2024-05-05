using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{



    public class Product : ICloneable
    {

        private decimal productPrice { get; set; }
        private string productName { get; set; }
        private bool IsAvailable { get; set; }
        private FlowerEnum productType { get; set; }
        private int productStock { get; set; }

        public Product() { }

        public Product(decimal auxPrice, string auxNameProduct, bool auxAvailability, FlowerEnum auxFlowerType, int auxProductStock)
        {
            this.productPrice = auxPrice;
            this.productName = auxNameProduct;
            this.productType = auxFlowerType;
            this.productStock = auxProductStock;
            this.IsAvailable= auxAvailability;
        }

        public object Clone()
        {
            return this.productStock.CompareTo(this.productPrice);
        }
    }
}

