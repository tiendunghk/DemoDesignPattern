
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            VietnameseTarget client = new TranslatorAdapter(new JapaneseAdaptee());
            client.Send("Xin chào");
        }
    }
}
