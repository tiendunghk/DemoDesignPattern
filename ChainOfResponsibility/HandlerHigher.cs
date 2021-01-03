using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class HandlerHigher : IHandler
    {
        public IHandler Successor { get; set; }

        public void RequestDraw(int amount)
        {
            if (amount < 30000) Console.WriteLine("Handler Higher: I can handle < 30000");
            else
            {
                Console.WriteLine("Handler Higher: I received that request but I can hanlde only <30000");
                Successor?.RequestDraw(amount);
            }
        }
    }
}
