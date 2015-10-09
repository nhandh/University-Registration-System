using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URS
{
    class LoginController
    {
        public bool validateLogin(string username, string pass)
        {
            Member.member_username = username;
            Member.password = pass;
            if (Member.Validate())
            {
                return true;
            }
            return false;
        }
    }
}
