using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_New123
{
    public class Patterns
    {
        public static string Regex_FName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFName(string FName)
        {
            return Regex.IsMatch(FName, Regex_FName);
        }
    }
}


