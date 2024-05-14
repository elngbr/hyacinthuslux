using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    [Serializable]
    public class Client:IComparable<Client>
    {
        public int clientId { get; set; }
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }
        public string clientEmail { get; set; }
        public string clientAddress { get; set; }
        public string clientPhoneNumber { get; set; }
        public double clientLoyaltyPoints { get; set; }

        public Client(int Id, string fname, string lname, string email, string address, string phonenumber, double loyaltyPoints)
        {

            if (address .Contains( "Florida"))
            {
                throw new InvalidAddressException(address);
            }

            if(phonenumber=="0787823221")
            {
                throw new Exception("Elena's phone number is not a valid phone number!");
            }
            this.clientAddress = address;
            this.clientId = Id;
            this.clientFirstName = fname;

            this.clientLastName = lname;
            this.clientEmail = email;
            this.clientLoyaltyPoints = loyaltyPoints;
            this.clientPhoneNumber = phonenumber;
        }
        public Client() { }

         public int CompareTo(Client other)
        {
            return this.clientId.CompareTo(other.clientId);
        }
    }
}
