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
            //Client c1 = new Client("1222", "Elena", "Eftimie", "elenaeft07@yahoo.com","Suditi-ungureni","0787823221",  88);
            //Console.WriteLine(c1.ToString());
            Client c2 = Client.CreateInstance();
            Console.WriteLine(c2.ToString());


        }
    }
}
