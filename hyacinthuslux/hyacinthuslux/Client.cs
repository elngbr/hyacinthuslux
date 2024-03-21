using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    internal class Client
    {
        private string clientId = "DEFAULT_ID";
        private string clientFirstName = "FirstNameDefault";
        private string clientLastName = "LastNameDefault";
        private string clientEmail = "email@deafult.ro";
        private string clientAddress = "Street Default, no. -1";
        private string clientPhoneNumber = "Default no";
        private double clientLoyaltyPoints = 0.00;
        private static HashSet<string> AlreadyUsedIds = new HashSet<string>();
        private const int MAXIMUM_PHONE_NUMBER_DIGITS = 16;
        private const int MINIMUM_PHONE_NUMBER_DIGITS = 8;
        private const int MAXIMUM_LOYALTY_POINTS = 100;

        public String ClientId
        {
            set
            {
                if (AlreadyUsedIds.Contains(value))
                {
                    throw new ArgumentException("*********EXCEPTION THROWN!\nThe ClientId you inserted it's already used by someone else." +
                        "\nPlease change ID!\nYour inserted ID is:" + value + ".\n");
                }
                else if (string.IsNullOrEmpty(this.clientId))
                {
                    //throw new Exception("***********EXCEPTION THROWN!\nThe ClientId you inserted is null or empty." +
                    //  "\nPlease change ID!\nYour inserted ID is:" + auxClientId + ".\n");
                }
                clientId = value;
                AlreadyUsedIds.Add(value);
            }

            get { return this.clientId; }
        }

        public String ClientFirstName
        {

            set
            {
                if (value[0] < 'A' || value[0] > 'Z')
                {
                    throw new ArgumentException("EXCEPTION THROWN!\nThe first name of the client must start with capital letter." +
                        "\nPlease change first name!" + "The inserted first name is:" + value + ".\n");
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("EXCEPTION THROWN!\nThe first name of the client is null or empty." +
                        "\nPlease change first name!" + "\nThe inserted first name is:" + value + ".\n");
                }
                this.clientFirstName = value;

            }
            get { return this.clientFirstName; }
        }




        public String ClientLastName
        {
            set
            {
                if (value[0] < 'A' || value[0] > 'Z')
                {
                    throw new ArgumentException("EXCEPTION THROWN!\nThe last name of the client must start with capital letter." +
                        "\nPlease change last name!" + "The inserted last name is:" + value + ".\n");
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("EXCEPTION THROWN!\nThe first name of the client is null or empty." +
                        "\nPlease change first name!" + "\nThe inserted first name is:" + value + ".\n");
                }
                this.clientLastName = value;

            }
            get
            { return this.clientLastName; }
        }


        public String ClientEmail
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("EXCEPTION THROWN!\nThe email of the client is null or empty." +
                        "\nPlease change email!" + "\nThe inserted email is:" + value + ".\n");
                }
                this.clientEmail = value;
            }

            get { return this.clientEmail; }

        }


        public string ClientAddress
        {
            get { return clientAddress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("EXCEPTION THROWN!\nThe address of the client is null or empty. Please change the address!");
                }
                clientAddress = value;
            }
        }

        public string ClientPhoneNumber
        {
            get { return clientPhoneNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("EXCEPTION THROWN!\nThe phone number of the client is null or empty. Please change the phone number!");
                }
                else if (value.Length < MINIMUM_PHONE_NUMBER_DIGITS || value.Length > MAXIMUM_PHONE_NUMBER_DIGITS)
                {
                    throw new ArgumentException("EXCEPTION THROWN!\nThe phone number length is out of bounds [8-16]. Please provide a valid phone number!");
                }
                clientPhoneNumber = value;
            }
        }

        public double ClientLoyaltyPoints
        {
            get { return this.clientLoyaltyPoints; }
            set
            {
                if (value < 0 || value > Client.MAXIMUM_LOYALTY_POINTS)
                {
                    throw new ArgumentException("EXCEPTION THROWN!\nThe loyalty points of the client are out of bounds [0-100]. Please provide valid loyalty points!");
                }
                clientLoyaltyPoints = value;
            }
        }

        //constructors
        public Client(string auxClientId, string auxClientFirstName, string auxClientLastName, string auxClientEmail
            , string auxClientAddress, string auxClientPhoneNumber, double auxClientLoyalityPoints)

        {
            try
            {
                this.ClientId = auxClientId;
                this.ClientEmail = auxClientEmail;
                this.ClientPhoneNumber = auxClientPhoneNumber;
                this.ClientAddress = auxClientAddress;
                this.ClientFirstName = auxClientFirstName;
                this.ClientLastName = auxClientLastName;
                this.ClientLoyaltyPoints = auxClientLoyalityPoints;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public Client()
        {

        }

        public override string ToString()
        {

            if (this.clientId == "DEFAULT_ID")
            {
                return "\n\n\n\n\n\nCannot print a client without ID!" + " Your object is " + this.GetHashCode() + ", but it has no ID!";
            }
            return $"\n\n\n\n\n\nID:{clientId}\nName:{clientFirstName + " " + clientLastName}\nEmail:{clientEmail},\nAddress: {clientAddress}," +
                $"\nPhone Number:{clientPhoneNumber},\nLoyality Points:{clientLoyaltyPoints}";
        }


        public static Client CreateInstance()
        {
            return new Client();
        }
    }
}
