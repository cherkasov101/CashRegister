using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class UserClass
    {
        public string id;
        public string password;
        public string name;
        public bool adminRights;
        public UserClass(string id, string password, string name, string admin)
        {
            this.name = name;
            this.id = id;
            this.password = password;
            if (admin == "1")
            {
                adminRights = true;
            }
            else
            {
                adminRights |= false;
            }
        }
    }
}
