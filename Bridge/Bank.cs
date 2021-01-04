using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class Bank
    {

        protected IAccount account;

        public Bank(IAccount account)
        {
            this.account = account;
        }

        public abstract void OpenAccount();
    }
}
