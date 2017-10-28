using Northwind.Framework.Helpers;
using System.Text.RegularExpressions;

namespace Northwind.Domain
{
    public class CommonPolicy
    {
        public static void CheckMail(string mailAddress)
        {
            var match = Regex.Match(mailAddress, RegexContants.Email);
            if (!match.Success)
                throw new InvalidEMailException();
        }
    }
}
