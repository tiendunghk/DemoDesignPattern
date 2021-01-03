using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class HandlerLow : IHandler
    {
        public IHandler Successor { get; set; }

        public void RequestDraw(int amount)
        {
            if (amount < 10000) Console.WriteLine("Handler Low: I can handle < 10000");
            else
            {
                Console.WriteLine("Handler Low: I received that request but I can hanlde only < 10000");
                Successor?.RequestDraw(amount);
            }
        }
    }
}
