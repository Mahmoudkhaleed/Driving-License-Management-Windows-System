using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DVLD_Project.Global_Classes
{
    public class clsValidate
    {
        public static bool IsEmailValid(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                           + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]+(\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*))"
                           + @"@((?!\.)[a-z0-9-]+\.)*([a-z0-9]{2,63}|[a-z0-9][a-z0-9-]{0,61}[a-z0-9])$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
