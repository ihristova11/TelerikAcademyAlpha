using System;

namespace DecimalToHexadecimal
{
    public class Program
    {
        static void Main()
        {
            long dec = long.Parse(Console.ReadLine());

            Console.WriteLine(DecimalToHexadecimal(dec));
        }

        public static string DecimalToHexadecimal(long dec)
        {
            if (dec < 1) return "0";

            long hex = dec;
            string hexStr = string.Empty;

            while (dec > 0)
            {
                hex = dec % 16;

                if (hex < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());

                dec /= 16;
            }

            return hexStr;
        }
    }
}
