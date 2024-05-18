using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    public class Delivery
    {
        
        public Client DeliveryClient { get;  set; }
        public List<Product> DeliveryProducts { get;  set; }
        public List<int> deliveryQuantities { get; set; }
        public String deliveryLocation { get;  set; }
        public DateTime deliveryDate { get; set; }

        public Delivery()
        {
            deliveryDate = DateTime.Now;
        }
        public Delivery(Client client, List<Product> _products, List<int>quantities, DateTime date, String location)
        {
            DeliveryClient = client;
            DeliveryProducts = new List<Product>(_products);
            this.deliveryQuantities= new List<int>(quantities);
            this.deliveryLocation = location;
            this.deliveryDate = date;


        }

        public String deliveryConcatenatedProducts()
        {
            StringBuilder s = new StringBuilder();
            for (int i=0; i<deliveryQuantities.Count;i++)
            {
                s.Append(DeliveryProducts[i].ToString() );
                s.Append("x");
                s.Append(deliveryQuantities[i].ToString());
                s.Append(' ');
            }

            s.Append(":");

            return s.ToString();

            
        }

        
       



    }
}
