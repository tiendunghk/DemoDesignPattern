using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Subsystem
{
    public class AccountService
    {
        public void getAccount(String email)
        {
            Console.WriteLine("Getting the account of " + email);
        }
    }
}
