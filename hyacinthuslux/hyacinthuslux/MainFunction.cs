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


            Product p1 = new Product(8, "Rose", true, FlowerEnum.Hyacinth);

            Console.WriteLine(p1.ToString());

            Product p2 = new Product(8, "Rose", true, FlowerEnum.Hyacinth);

            Console.WriteLine(p2.ToString());


        }
    }
}
