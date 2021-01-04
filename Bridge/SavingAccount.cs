using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SavingAccount : IAccount
    {
        public void OpenAccount()
        {
            Console.WriteLine("Saving Account");
        }
    }
}
