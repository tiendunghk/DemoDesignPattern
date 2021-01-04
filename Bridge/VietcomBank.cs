using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class VietcomBank : Bank
    {
        public VietcomBank(IAccount account) : base(account)
        {

        }
        public override void OpenAccount()
        {
            Console.WriteLine("Open your account at VietcomBank is a ");
            account.OpenAccount();
        }
    }
}
