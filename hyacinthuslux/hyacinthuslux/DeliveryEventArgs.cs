using System;

namespace hyacinthuslux
{
    public class DeliveryEventArgs : EventArgs
    {
        public Delivery Delivery { get; private set; }

        public DeliveryEventArgs(Delivery delivery)
        {
            Delivery = delivery;
        }
    }
}
