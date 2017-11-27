namespace _07.ReverseNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class ReverseNumber
    {
        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseDecimal(number.ToString()));
        }

        public static string ReverseDecimal(string number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }

            return sb.ToString();
        }
    }
}
