using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.ProtectedProxy
{
    public class UserProxy : IReadFile
    {
        string name;
        string role;
        User user;
        public UserProxy(string name, string role)
        {
            this.name = name;
            this.role = role;
        }
        public string ReadFile()
        {
            if (this.role.ToLower().Equals("admin"))
            {
                user = new User(this.name);
                return user.ReadFile();
            }
            return "You can't read file";
        }
    }
}
