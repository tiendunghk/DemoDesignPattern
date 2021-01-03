using Facade.Facade;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopFacade.Instance().buyProductByCashWithFreeShipping("abc@gmail.com");
            ShopFacade.Instance().buyProductByPaypalWithStandardShipping("abc@gmail.com");
        }
    }
}
