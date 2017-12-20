using System;
using System.Text.RegularExpressions;

namespace Dealership.Models
{
    public class Validator
    {
        public static void ValidateUser(string input, string pattern, string msg)
        {
            if (string.IsNullOrEmpty(input) || new Regex(pattern).IsMatch(input))
            {
                throw new ArgumentException(msg);
            }
        }
    }
}
