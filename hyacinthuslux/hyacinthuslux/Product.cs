using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{



    public class Product : ICloneable
    {

        public decimal productPrice { get; set; }
        public string productName { get; set; }
        public bool IsAvailable { get; set; }
        public FlowerEnum productType { get; set; }
        public int productStock { get; set; }

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
            Product p = null;
            p= (Product)this.Clone();
            p.productPrice = this.productPrice;
            p.productName = this.productName;
            p.productType = this.productType;
            return p;
        }
    }
}

