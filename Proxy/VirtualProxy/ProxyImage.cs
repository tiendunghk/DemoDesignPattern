using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.VirtualProxy
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string url;

        public ProxyImage(string url)
        {
            this.url = url;
            Console.WriteLine("Image unloaded: " + this.url);
        }
        public void ShowImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(this.url);
            }
            else
            {
                Console.WriteLine("Image already existed: " + this.url);
            }
            realImage.ShowImage();
        }
    }
}
