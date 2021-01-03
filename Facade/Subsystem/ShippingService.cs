using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Subsystem
{
    public class ShippingService
    {

        public void freeShipping()
        {
            Console.WriteLine("Free Shipping");
        }

        public void standardShipping()
        {
            Console.WriteLine("Standard Shipping");
        }

        public void expressShipping()
        {
            Console.WriteLine("Express Shipping");
        }
    }
}
