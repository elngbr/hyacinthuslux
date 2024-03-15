using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
    internal class Client
    {
        private string ClientId;
        private string ClientFirstName;
        private string ClientLastName;
        private string ClientEmail;
        private string ClientAddress;
        private string ClientPhoneNumber;
        private double ClientLoyalityPoints;
        private static HashSet<string> AlreadyUsedIds = new HashSet<string>();
        private const int MAXIMUM_PHONE_NUMBER_DIGITS = 16;
        private const int MINIMUM_PHONE_NUMBER_DIGITS = 8;
        private const int MAXIMUM_LOYALITY_POINTS = 100;

        //getters
        public string GetClientId() { return this.ClientId; }
        public string GetClientFirstName() { return this.ClientFirstName; }
        public string GetClinentLastName() { return this.ClientLastName; }
        public string GetClinetEmail() { return this.ClientEmail; }
        public string GetClientAddress() { return this.ClientAddress; }
        public string GetClinetPhoneNumber() { return this.ClientPhoneNumber; }
        public double GetClinetLoyalityPoints() { return this.ClientLoyalityPoints; }

        //setters
        public void SetClinetId(string auxClientId)
        {
            if (AlreadyUsedIds.Contains(auxClientId))
            {
                throw new ArgumentException("EXCEPTION THROWN!\nThe ClientId you inserted it's already used by someone else." +
                    "\nPlease change ID!\nYour inserted ID is:" + auxClientId + ".\n");
            }
            else if (string.IsNullOrEmpty(this.ClientId))
            {
                throw new Exception("EXCEPTION THROWN!\nThe ClientId you inserted is null or empty." +
                    "\nPlease change ID!\nYour inserted ID is:" + auxClientId + ".\n");
            }
            ClientId = auxClientId;
            AlreadyUsedIds.Add(auxClientId);
        }

        public void SetClinetFirstName(string auxClientFirstName)
        {
            if (auxClientFirstName[0] < 'A' || auxClientFirstName[0] > 'Z')
            {
                throw new ArgumentException("EXCEPTION THROWN!\nThe first name of the client must start with capital letter." +
                    "\nPlease change first name!" + "The inserted first name is:" + auxClientFirstName + ".\n");
            }
            else if (string.IsNullOrEmpty(auxClientFirstName))
            {
                throw new Exception("EXCEPTION THROWN!\nThe first name of the client is null or empty." +
                    "\nPlease change first name!" + "\nThe inserted first name is:" + auxClientFirstName + ".\n");
            }
            this.ClientFirstName = auxClientFirstName;

        }

        public void SetClinetLastName(string auxClientLastName)
        {
            if (auxClientLastName[0] < 'A' || auxClientLastName[0] > 'Z' || auxClientLastName == null)
            {
                throw new ArgumentException("EXCEPTION THROWN!\nThe last name of the client must start with capital letter." +
                    "\nPlease change last name!" + "The inserted last name is:" + auxClientLastName + ".\n");
            }
            else if (string.IsNullOrEmpty(auxClientLastName))
            {
                throw new Exception("EXCEPTION THROWN!\nThe first name of the client is null or empty." +
                    "\nPlease change first name!" + "\nThe inserted first name is:" + auxClientLastName + ".\n");
            }
            this.ClientLastName = auxClientLastName;

        }

        public void SetClinetEmail(string auxClientEmail)
        {
            if (string.IsNullOrEmpty(auxClientEmail))
            {
                throw new ArgumentException("EXCEPTION THROWN!\nThe email of the client is null or empty." +
                    "\nPlease change email!" + "\nThe inserted email is:" + auxClientEmail + ".\n");
            }
            this.ClientEmail = auxClientEmail;
        }

        public void SetClinetAddress(string auxClientAddress)
        {
            if (string.IsNullOrEmpty(auxClientAddress))
            {
                throw new ArgumentException("EXCEPTION THROWN!\nThe email of the client shoud not be NULL." +
                    "\nPlease change email!" + "\nThe inserted email is:" + auxClientAddress + ".\n");
            }
            this.ClientAddress = auxClientAddress;
        }

        public void SetClientPhoneNumber(string auxClientPhoneNumber)
        {
            if (auxClientPhoneNumber.Length > MAXIMUM_PHONE_NUMBER_DIGITS || auxClientPhoneNumber.Length < MINIMUM_PHONE_NUMBER_DIGITS)
            {
                throw new IndexOutOfRangeException("EXCEPTION THROWN!\n Phone number length is out of bounds [8-16].\n" +
                    "Your inserted phone number is: " + auxClientPhoneNumber);

            }
            else if (string.IsNullOrEmpty(auxClientPhoneNumber))
            {
                throw new ArgumentException("EXCEPTION THROWN!\n Phone number null or empty.\n" +
                    "Your inserted phone number is: " + auxClientPhoneNumber);
            }

            this.ClientPhoneNumber = auxClientPhoneNumber;

        }

        public void SetClientLoyalityPoints(double auxClientLoyalityPoints)
        {
            if (auxClientLoyalityPoints>MAXIMUM_LOYALITY_POINTS ||auxClientLoyalityPoints<0)
            {
                throw new IndexOutOfRangeException("EXCEPTION THROWN!\n Loyality points are out of bounds [0-100].\n"
                    "Your inserted loyality points are:" + auxClientLoyalityPoints);
            }
            
            this.ClientLoyalityPoints= auxClientLoyalityPoints;
        }

        //constructors
        public Client(string auxClientId, string auxClientFirstName, string auxClientLastName, string auxClientEmail
            , string auxClientAddress, string auxClientPhoneNumber, double auxClientLoyalityPoints)

        {
            try
            { this.SetClinetId(auxClientId); }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            try
            {
                this.SetClinetEmail(auxClientEmail);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            this.SetClientPhoneNumber(auxClientPhoneNumber);
            this.SetClinetAddress(auxClientAddress);
            this.SetClinetFirstName(auxClientFirstName);
            this.SetClinetLastName(auxClientLastName);
            this.SetClientLoyalityPoints(auxClientLoyalityPoints);
        }


        public override string ToString()
        {
            return $"ID:{ClinentId}\nName:{ClientFirstName + ClientLastName}\nEmail:{ClientEmail},\nAddress: {ClientAddress}," +
                $"\nPhone Number:{ClientPhoneNumber},\n Loyality Points:{ClientLoyalityPoints}";
        }

    }
}
