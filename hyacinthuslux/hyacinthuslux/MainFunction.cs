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
                Client c1 = new Client();
                Console.WriteLine(c1.ToString());
                Client c2 = new Client("100", "Elena", "Eftimie", "elenaeft07@gmail.com", "Suditi-ungureni", "+0787823221", 88);

                Console.WriteLine(c2.ToString());



                Client c3 = new Client("100", "Elena", "Eftimie", "elenaeft07@gmail.com", "Suditi-ungureni", "+0787823221", 88);

                Console.WriteLine(c3.ToString());


                Product p1 = new Product(100, "Rose", true, FlowerEnum.Hyacinth);

                Console.WriteLine(p1.ToString());

                Product p2 = new Product(12, "Carnation", true, FlowerEnum.Carnation);
                Product p3 = new Product(44, "Orchid", false, FlowerEnum.Orchid);

                Console.WriteLine(p2.ToString());


                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tTesting operators");

                Console.WriteLine("BINARY Operator + for 2 products prices");

                decimal priceDifference = p1 - p2;

                Console.WriteLine("\n\n\n\nThe price difference between Rose and Carnation is {0:c}.", priceDifference);
                Console.Write("\n********************************************************************************\n");

                Console.WriteLine("BINARY Operator - for 2 products prices");

                decimal totalForACarnationAndRose = p1 + p2;

                Console.WriteLine("\n\n\n\nThe total price of buying a Rose and a Carnation is {0:c}.", totalForACarnationAndRose);
                Console.Write("\n********************************************************************************\n");

                Console.WriteLine("UNARY Operator ! for 1 product availability");

                bool isOrchidAvailable = !p3;

                Console.WriteLine("\n\n\n\nThe product Orchid is available:" + isOrchidAvailable);
                Console.Write("\n********************************************************************************\n\n\n");

                Console.WriteLine("UNARY Operator ~ for 1 product. We cant see the object because of the manner I have created the ctor. "
                    + "\nPLEASE DO CHECK IMPLEMENTATION OF CTOR AND OPERATOR ~");



                Product negatedProduct = ~p3;

                Console.WriteLine("\n\n\n\n***YOU WONT SEE NEGATED PRODUCT. "
                    + "THE CTOR DOES NOT ACCEPT NEGATIVE PRICES.\nThe negated product Orchid is :" + negatedProduct);

            }


        
    }
}
