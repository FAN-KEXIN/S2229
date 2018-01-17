using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrmLogin
{
    public class LoginInfo
    {
        private string _emai;

        public string Emai
        {
            get { return _emai; }
            set { _emai = value; }
        }
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
