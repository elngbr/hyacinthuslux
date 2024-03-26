using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    internal class Delivery
    {
        private Client deliveryClinent;
        private List<Product> products = new List<Product>();

        //We will not create another Client, nor another Product. We will simply reference the same created objects
        public Delivery(Client client, params Product[] auxProducts)
        {
            try
            {


                foreach (Product p in auxProducts)
                {
                    p.ProductStock--;
                }
                this.deliveryClinent = client;
                this.AddProducts(auxProducts);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                deliveryClinent = null;
            }
        }

        public override string ToString()
        {
            if (this.deliveryClinent == null)
            {
                return "\nThis delivery is " + this.GetHashCode() + " but it does not have a client, so it's not viable!\n" +
                    "Maybe you wanted to append to this delivery a product which was not avilable or has 0 stock.\nConsider reediting the delivery or creating another one.\n\n\n\n";
            }
            return $"\n\n\n\n\n\n\nThis delivery was sent to the client: {this.deliveryClinent.ToString()}," +
                $" and contained the following items: {string.Join("\n", products)}";
        }


        //look here!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public void AddProducts(params Product[] productsToAdd)
        {
            foreach (Product product in productsToAdd)
            {

                if (product == null || product.ProductAvailability == false)
                {
                    throw new Exception("Product " + product.nameProduct + " is not available to be added in the delivery. May be rezerved.");
                }
                products.Add(product);


            }
        }


    }
}
