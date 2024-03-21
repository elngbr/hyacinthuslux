using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{



    internal class Product /*: Invoiceable*/
    {

        private decimal Price = 0;
        private string NameProduct = "DEFAULT_NAME";
        private bool IsAvailable = false;
        private byte[] ImageData;
        private FlowerEnum FlowerType = FlowerEnum.Default;
        private static HashSet<string> AlreadyUsedNames = new HashSet<string>();
        //public override void getInvoiceItem()
        //{

        //}

        public Product(decimal auxPrice, string auxNameProduct, bool auxAvailability, FlowerEnum auxFlowerType)
        {
            try
            {
                this.PriceProduct = auxPrice;
                this.nameProduct = auxNameProduct;
                this.ProductAvailability = auxAvailability;
                this.flowerType = auxFlowerType;

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }


        ///Formatted price
        public string GetFormattedPrice()
        {
            return $"{this.Price.ToString("c")}";
        }

        ///OVERRIDDEN TO STRING
        public override string ToString()
        {

            if (this.NameProduct == "DEFAULT_NAME")
            {
                return "\n\n\n\nCannot print product without name!" + " Your product is " + this.GetHashCode() + ", but it has no name!";
            }
            return $"\n\n\n\n\n\n\nName:{NameProduct}\nPrice:{this.GetFormattedPrice()}\nAvailability:{this.IsAvailable}\nFlower type:{this.FlowerType}";
        }





        ///Properties for nameProduct

        public string nameProduct
        {


            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("*******EXCEPTION THROWN!\nThe name is null or empty!\nPlease insert other name!" +
                        "\nYour inserted name is: " + value);
                }
                else if (AlreadyUsedNames.Contains(value))
                {
                    throw new Exception("*******EXCEPTION THROWN!\nThe name you inserted it's already used by other product." +
                        "\nPlease change name!\nYour inserted name is:" + value + ".\n");
                }
                else if (value[0] < 'A' || value[0] > 'Z')
                {
                    throw new IndexOutOfRangeException("*******EXCEPTION THROWN!\nThe name of the product must start with capital letter." +
                        "\nPlease change product name!" + "The inserted product name is:" + value + ".\n");
                }

                this.NameProduct = value;
                AlreadyUsedNames.Add(value);
            }

            get { return this.NameProduct; }

        }





        ///Property for price

        public decimal PriceProduct
        {
            set
            {
                if (value < 0)
                {

                    throw new ArgumentException("********EXCEPTION THROWN!\nThe price of any product should be more than 0!" +
                    "\nYour price is: " + value);
                }

                this.Price = value;
            }

            get { return this.Price; }
        }


        //Properties for enum
        public FlowerEnum flowerType
        {
            set { this.FlowerType = value; }
            get { return this.flowerType; }
        }


        //properties for Availability
        public bool ProductAvailability
        {
            set
            {
                this.IsAvailable = value;
            }



            get
            {
                return this.IsAvailable;
            }
        }



        ///overloading operators




        ///1. Operator +
        public static decimal operator +(Product p1, Product p2)
        {
            return p1.PriceProduct + p2.PriceProduct;
        }

        ///2. Operator -
        public static decimal operator -(Product p1, Product p2)
        {
            return p1.PriceProduct - p2.PriceProduct;
        }


        ///3. Operator !   
        public static bool operator !(Product p1)
        {
            return !(p1.IsAvailable == false);
        }

        ///4. Operator ~
        public static Product operator ~(Product p1)
        {
            return new Product(-p1.PriceProduct, p1.NameProduct, !p1.IsAvailable, p1.FlowerType);

        }

    }
}

