using Proxy.ProtectedProxy;
using Proxy.VirtualProxy;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //=======================================
            ProxyImage proxyImage = new ProxyImage("http://abc.com/a.png");
            Console.WriteLine("Call real service 1st: ");
            proxyImage.ShowImage();

            Console.WriteLine("Call real service 2nd: ");
            proxyImage.ShowImage();

            //=======================================
            /*UserProxy user1 = new UserProxy("user1", "admin");
            Console.WriteLine(user1.ReadFile());

            UserProxy user2 = new UserProxy("user2", "member");
            Console.WriteLine(user2.ReadFile());*/
        }
    }
}
