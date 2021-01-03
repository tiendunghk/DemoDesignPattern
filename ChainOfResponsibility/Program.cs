using System;

namespace ChainOfResponsibility
{
    class Program
    {
        public class ChainOfHandlers
        {
            public readonly IHandler _low = new HandlerLow();
            public readonly IHandler _medium = new HandlerMedium();
            public readonly IHandler _high = new HandlerHigher();
            public readonly IHandler _default = new HandlerDefault();
            public ChainOfHandlers()
            {
                _low.Successor = _medium;
                _medium.Successor = _high;
                _high.Successor = _default;
            }
            public void Handle(int amount)
            {
                _low.RequestDraw(amount);
            }
        }
        static void Main(string[] args)
        {
            var chain = new ChainOfHandlers();
            chain.Handle(21000);
        }
    }
}
