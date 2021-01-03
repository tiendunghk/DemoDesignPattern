using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler Successor { get; set; }
        void RequestDraw(int amount);
    }
}
