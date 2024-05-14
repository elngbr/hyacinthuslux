using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    public class InvalidAddressException : Exception
    {

        public String address { get; set; } 
        public InvalidAddressException(String address) 
        {
            this.address = address;
        }

        public override string Message
        {
            get
            {
                return "The Address " + address + " is invalid";
            }
        }

    }
}
