using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    public class Client:IComparable<Client>
    {
        private string clientId { get; set; }
        private string clientFirstName { get; set; }
        private string clientLastName { get; set; }
        private string clientEmail { get; set; }
        private string clientAddress { get; set; }
        private string clientPhoneNumber { get; set; }
        private double clientLoyaltyPoints { get; set; }

        public Client(string Id, string fname, string lname, string email, string address, string phonenumber, double loyaltyPoints)
        {
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
