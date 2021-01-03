using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class JapaneseAdaptee
    {
        public void receive(string words)
        {
            Console.WriteLine("Retrieving words from Adapter ...");
            Console.WriteLine(words);
        }
    }
}
