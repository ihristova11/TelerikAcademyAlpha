using System;

namespace HexadecimalToDecimal
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(long.Parse(Console.ReadLine(), System.Globalization.NumberStyles.HexNumber));
        }
    }
}
