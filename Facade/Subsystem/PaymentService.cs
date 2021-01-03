using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Subsystem
{
    public class PaymentService
    {

        public void paymentByPaypal()
        {
            Console.WriteLine("Payment by Paypal");
        }

        public void paymentByCreditCard()
        {
            Console.WriteLine("Payment by Credit Card");
        }

        public void paymentByCash()
        {
            Console.WriteLine("Payment by cash");
        }
    }
}
