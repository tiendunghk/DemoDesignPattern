using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class TPBank : Bank
    {
        public TPBank(IAccount account) : base(account)
        {

        }
        public override void OpenAccount()
        {
            Console.WriteLine("Open your account at TPBank is a ");
            account.OpenAccount();
        }
    }
}
