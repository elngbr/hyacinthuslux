using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    public class Delivery
    {
        
        public Client DeliveryClient { get; private set; }
        public List<Product> DeliveryProducts { get; private set; }

        
        public Delivery(Client client, List<Product> _products)
        {
            DeliveryClient = client;
            DeliveryProducts = new List<Product>(_products);
        }

        
       



    }
}
