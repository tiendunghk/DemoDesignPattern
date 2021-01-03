using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TranslatorAdapter : VietnameseTarget
    {


        private JapaneseAdaptee adaptee;

        public TranslatorAdapter(JapaneseAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Send(string words)
        {
            Console.WriteLine("Reading Words ...");
            Console.WriteLine(words);
            string vietnameseWords = this.Translate(words);
            Console.WriteLine("Sending Words ...");
            adaptee.receive(vietnameseWords);
        }

        private string Translate(string vietnameseWords)
        {
            Console.WriteLine("Translated!");
            return "こんにちは";
        }
    }
}
