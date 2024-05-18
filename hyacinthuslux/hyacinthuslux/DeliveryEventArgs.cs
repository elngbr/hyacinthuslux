using hyacinthuslux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DeliveryEventArgs : EventArgs
{
    public Delivery Delivery { get; }

    public DeliveryEventArgs(Delivery delivery)
    {
        Delivery = delivery;
    }
}
