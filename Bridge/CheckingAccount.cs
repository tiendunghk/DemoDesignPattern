using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class CheckingAccount : IAccount
    {
        public void OpenAccount()
        {
            Console.WriteLine("Checking Account");
        }
    }
}
