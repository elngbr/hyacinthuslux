using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    internal class MainFunction
    {

        public static void Main(string[] args)
        {
            // Client c1 = new Client();
            //Console.WriteLine(c1.ToString());
            Client c2 = new Client("100", "Elena", "Eftimie", "elenaeft07@gmail.com", "Suditi-ungureni", "+0787823221", 88);

            Console.WriteLine(c2.ToString());



            Client c3 = new Client("100", "Elena", "Eftimie", "elenaeft07@gmail.com", "Suditi-ungureni", "+0787823221", 88);

            Console.WriteLine(c3.ToString());


            Product hyacinth = new Product(18, "Hyacinth", true, FlowerEnum.Hyacinth, 500);

            Console.WriteLine(hyacinth.ToString());

            Product carnation = new Product(12, "Carnation", true, FlowerEnum.Carnation, 300);
            Product orchid = new Product(25, "Orchid", false, FlowerEnum.Orchid, 100);

            Console.WriteLine(carnation.ToString());


            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tTesting operators");

            Console.WriteLine("BINARY Operator + for 2 products prices");

            decimal priceDifference = hyacinth - carnation;

            Console.WriteLine("\n\n\n\nThe price difference between Rose and Carnation is {0:c}.", priceDifference);
            Console.Write("\n********************************************************************************\n");

            Console.WriteLine("BINARY Operator - for 2 products prices");

            decimal totalForACarnationAndRose = hyacinth + carnation;

            Console.WriteLine("\n\n\n\nThe total price of buying a Rose and a Carnation is {0:c}.", totalForACarnationAndRose);
            Console.Write("\n********************************************************************************\n");

            Console.WriteLine("UNARY Operator ! for 1 product availability");

            bool isOrchidAvailable = !orchid;

            Console.WriteLine("\n\n\n\nThe product Orchid is available:" + isOrchidAvailable);
            Console.Write("\n********************************************************************************\n\n\n");

            Console.WriteLine("UNARY Operator ~ for 1 product. We cant see the object because of the manner I have created the ctor. "
                + "\nPLEASE DO CHECK IMPLEMENTATION OF CTOR AND OPERATOR ~");



            Product negatedProduct = ~orchid;

            Console.WriteLine("\n\n\n\n***YOU WONT SEE NEGATED PRODUCT. "
                + "THE CTOR DOES NOT ACCEPT NEGATIVE PRICES.\nThe negated product Orchid is :" + negatedProduct);

            Console.WriteLine("\n Testing copy ctor for both Client&Product from ICloneable to prove deep copy. " +
                "\n The Icloneable cpy ctor will not work because I have setted the condition for 2 objects to not have the same name." +
                "\nPrepare ICloneable for the test but here in product and Client you cannot do it.");


            //Product clonedProduct = (Product)p3.Clone();
            //Console.WriteLine(clonedProduct.ToString());

            Console.WriteLine("Stock of hyacinth is: " + hyacinth.getStockOfProduct());

            Console.WriteLine("Stock of orchid is: " + orchid.getStockOfProduct());
            Console.WriteLine("Stock of carnation is: " + carnation.getStockOfProduct());

            Delivery delivery1 = new Delivery(c2, hyacinth, orchid, carnation, hyacinth, hyacinth);
            Console.WriteLine(delivery1.ToString());

            Console.WriteLine("Stock of hyacinth is: " + hyacinth.getStockOfProduct());

            Console.WriteLine("Stock of orchid is: " + orchid.getStockOfProduct());
            Console.WriteLine("Stock of carnation is: " + carnation.getStockOfProduct());

        }


    }
}
