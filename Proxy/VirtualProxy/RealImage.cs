using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.VirtualProxy
{
    public class RealImage : IImage
    {
        string url;

        public RealImage(string url)
        {
            this.url = url;
            Console.WriteLine("Image loaded: " + this.url);
        }
        public void ShowImage()
        {
            Console.WriteLine("Image showed: " + this.url);
        }
    }
}
