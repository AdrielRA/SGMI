using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGMI
{
    public class User
    {
        private string name, email, telefone, credentials, passpassword;

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Credentials { get => credentials; set => credentials = value; }
        public string Passpassword { get => passpassword; set => passpassword = value; }
    }
}
