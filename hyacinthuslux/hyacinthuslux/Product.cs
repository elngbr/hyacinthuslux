using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hyacinthuslux
{
   

        internal enum FlowerEnum
        {
            Hyacinth, //Zambila
            Rose,
            Tulip,
            Lavender,
            Peony,    //Bujor
            Iris,
            Dahlia,
            Orchid,   //Orhidee
            Snowdrop,  //Ghiocel
            Magnolia,
            Sunflower,
            Tuberose,
            Daffodil, //narcisa
            Lily,     //crizantema
            Lilac,
            Zinnia,
            Azalea,
            Carnation //garoafa
        }

        internal class Product /*: Invoiceable*/
        {

            private float Price;
            private string NameProduct;
            private bool IsAvailable = false;
            private byte[] ImageData;
            private FlowerEnum FlowerType;
            private static HashSet<string> AlreadyUsedNames = new HashSet<string>();
            //public override void getInvoiceItem()
            //{

            //}

            public Product(float auxPrice, string auxNameProduct, bool auxAvailability, FlowerEnum auxFlowerType)
            {
                try
                {
                    this.SetPrice(auxPrice);
                    this.SetName(auxNameProduct);
                    this.SetAvailability(auxAvailability);
                    this.SetFlowerType(auxFlowerType);

                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }


            public FlowerEnum GetFlowerType()
            {
                return this.FlowerType;

                #region
                //switch (this.FlowerType)
                //{
                //    case 0:
                //        return "Hyacinth";
                //    case 1:
                //        return "Rose";
                //    case 2:
                //        return "Tulip";
                //    case 3:
                //        return "Hyacinth";
                //    case 4:
                //        return "Hyacinth";
                //    case 5:
                //        return "Hyacinth";
                //    case 6:
                //        return "Hyacinth";
                //    case 7:
                //        return "Hyacinth";
                //    case 8:
                //        return "Hyacinth";
                //    case 9:
                //        return "Hyacinth";
                //    case 10:
                //        return "Hyacinth";
                //    case 11:
                //        return "Hyacinth";
                //    case 12:
                //        return "Hyacinth";
                //    case 13:
                //        return "Hyacinth";
                //    case 14:
                //        return "Hyacinth";
                //    case 15:
                //        return "Hyacinth";
                //    case 16:
                //        return "Hyacinth";
                //    case 1:
                //        return "Hyacinth";
                #endregion
            }

            public void SetFlowerType(FlowerEnum flowerType)
            {
                this.FlowerType = flowerType;
            }


            public override string ToString()
            {

                if (string.IsNullOrEmpty(this.NameProduct))
                {
                    return "\n\n\n\nCannot print product without name!" + " Your product is " + this.GetHashCode() + ", but it has no name!";
                }
                return $"\n\n\n\n\n\n\nName:{NameProduct}\nPrice:{Price.ToString("c")}\nAvailability:{this.IsAvailable}\nFlower type:{this.FlowerType}";
            }
            public void SetName(string auxName)
            {
                if (string.IsNullOrEmpty(auxName))
                {
                    throw new ArgumentException("*******EXCEPTION THROWN!\nThe name is null or empty!\nPlease insert other name!" +
                        "\nYour inserted name is: " + auxName);
                }
                else if (AlreadyUsedNames.Contains(auxName))
                {
                    throw new Exception("*******EXCEPTION THROWN!\nThe name you inserted it's already used by other product." +
                        "\nPlease change name!\nYour inserted name is:" + auxName + ".\n");
                }
                else if (auxName[0] < 'A' || auxName[0] > 'Z')
                {
                    throw new IndexOutOfRangeException("*******EXCEPTION THROWN!\nThe name of the product must start with capital letter." +
                        "\nPlease change product name!" + "The inserted product name is:" + auxName + ".\n");
                }

                this.NameProduct = auxName;
                AlreadyUsedNames.Add(auxName);
            }

            public void SetPrice(float auxPrice)
            {
                if (auxPrice < 0)
                {

                    throw new ArgumentException("********EXCEPTION THROWN!\nThe price of any product should be more than 0!" +
                    "\nYour price is: " + auxPrice);
                }

                this.Price = auxPrice;
            }

            public void SetAvailability(bool auxAvailability)
            {
                this.IsAvailable = auxAvailability;
            }
            public string GetFormattedPrice()
            {
                return $"{this.Price.ToString():c}";
            }

            public string GetNameProduct()
            {
                return this.NameProduct;
            }

            public bool GetAvailability()
            {
                return this.IsAvailable;
            }
        }
}

