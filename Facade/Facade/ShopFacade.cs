using Facade.Subsystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Facade
{
    public class ShopFacade
    {
        AccountService accountService;
        PaymentService paymentService;
        ShippingService shippingService;
        private ShopFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
        }
        private static ShopFacade _instance;
        public static ShopFacade Instance()
        {
            if (_instance == null) _instance = new ShopFacade();
            return _instance;
        }
        public void buyProductByCashWithFreeShipping(String email)
        {
            accountService.getAccount(email);
            paymentService.paymentByCash();
            shippingService.freeShipping();
            Console.WriteLine("Done!\n");
        }

        public void buyProductByPaypalWithStandardShipping(String email)
        {
            accountService.getAccount(email);
            paymentService.paymentByPaypal();
            shippingService.standardShipping();
            Console.WriteLine("Done!\n");
        }
    }
}
