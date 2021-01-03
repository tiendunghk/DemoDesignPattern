using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class HandlerMedium : IHandler
    {
        public IHandler Successor { get; set; }

        public void RequestDraw(int amount)
        {
            if (amount < 20000) Console.WriteLine("Handler Medium: I can handle < 20000");
            else
            {
                Console.WriteLine("Handler Medium: I received that request but I can hanlde only <20000");
                Successor?.RequestDraw(amount);
            }
        }
    }
}
