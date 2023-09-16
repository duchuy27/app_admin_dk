using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class param_login
    {
        public string login { get; set; }
        public string password { get; set; }
        public string db { get; set; }

        public param_login(string login, string password, string db)
        {
            this.login = login;
            this.password = password;
            this.db = db;
        }
    }
}
