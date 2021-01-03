using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.ProtectedProxy
{
    public class User : IReadFile
    {
        private string name;
        private string role = "admin";

        public User(string name)
        {
            this.name = name;
        }

        public string ReadFile()
        {
            return name + " read";
        }
    }
}
