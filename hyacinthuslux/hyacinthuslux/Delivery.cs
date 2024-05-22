using hyacinthuslux;
using System.Collections.Generic;
using System.Text;
using System;

public class Delivery
{
    public Client DeliveryClient { get; set; }
    public List<Product> DeliveryProducts { get; set; }
    public List<int> deliveryQuantities { get; set; }
    public string deliveryLocation { get; set; }
    public DateTime deliveryDate { get; set; }
    public EnumCourier.CourierEnum deliveryMethod { get; set; }

    private decimal _deliveryTotalValue;

    public decimal DeliveryTotalValue
    {
        get
        {
            _deliveryTotalValue = 0;
            for (int i = 0; i < deliveryQuantities.Count; i++)
            {
                _deliveryTotalValue += DeliveryProducts[i].productPrice * deliveryQuantities[i];
            }
            return _deliveryTotalValue;
        }
    }

    public decimal Total
    {
        get
        {
            return GetTotalValue();
        }
    }

    public Delivery()
    {
        deliveryDate = DateTime.Now;
        this.deliveryMethod = EnumCourier.CourierEnum.Cargus_ShipGo;
    }

    public Delivery(Client client, List<Product> products, List<int> quantities, DateTime date, string location, EnumCourier.CourierEnum delMethod)
    {
        DeliveryClient = client;
        DeliveryProducts = new List<Product>(products);
        deliveryQuantities = new List<int>(quantities);
        deliveryLocation = location;
        deliveryDate = date;
        this.deliveryMethod = delMethod;
    }

    public decimal GetTotalValue()
    {
        decimal prodTotVal = DeliveryTotalValue;
        decimal transportValue = (decimal)ReturnCostBasedOnDeliveryMethod(this);
        decimal result = prodTotVal + transportValue;
        return result;
    }

    public string DeliveryConcatenatedProducts()
    {
        StringBuilder s = new StringBuilder();
        for (int i = 0; i < deliveryQuantities.Count; i++)
        {
            s.Append(DeliveryProducts[i].ToString());
            s.Append("x");
            s.Append(deliveryQuantities[i].ToString());
            s.Append(' ');
        }

        s.Append(":");

        return s.ToString();
    }

    public static double ReturnCostBasedOnDeliveryMethod(Delivery delivery)
    {
        if (delivery.DeliveryTotalValue > 50)
        {
            return 0;
        }

        switch (delivery.deliveryMethod)
        {
            case EnumCourier.CourierEnum.Cargus:
                return 3;

            case EnumCourier.CourierEnum.Cargus_ShipGo:
                return 0;

            case EnumCourier.CourierEnum.Sameday:
                return 2;

            case EnumCourier.CourierEnum.Sameday_EasyBox:
                return 0;

            case EnumCourier.CourierEnum.FanCourier:
                return 4;

            case EnumCourier.CourierEnum.FanBox:
                return 0;

            case EnumCourier.CourierEnum.GLS:
                return 3.5;

            case EnumCourier.CourierEnum.NemoExpress:
                return 4;

            case EnumCourier.CourierEnum.From_Store:
                return 0;
        }

        return 0;
    }
}
