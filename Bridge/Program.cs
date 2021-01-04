using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank vietcomBank = new VietcomBank(new CheckingAccount());
            vietcomBank.OpenAccount();

            Bank tpBank = new TPBank(new CheckingAccount());
            tpBank.OpenAccount();
        }
    }
}
