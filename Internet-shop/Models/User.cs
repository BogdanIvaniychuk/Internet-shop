using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_shop.Models
{
    public class User
    {
        private string mail;
        private string password;

        public string Mail { get { return mail; } set { mail = value; } }

        public string Password { get { return password; } set { password = value; } }
    }
}
