using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class HandlerDefault : IHandler
    {
        public IHandler Successor { get; set; }

        public void RequestDraw(int amount)
        {
            Console.WriteLine("Hanlder Default: I received that request.");
        }
    }
}
