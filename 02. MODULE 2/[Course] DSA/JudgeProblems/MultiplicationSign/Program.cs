using System;

namespace MultiplicationSign
{
    public class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(FindSign(a, b, c));
        }

        static string FindSign(double a, double b, double c)
        {
            double product = a * b * c;
            if (product < 0) return "-";
            if (product > 0) return "+";
            else
            {
                return "0";
            }
            //if (a == 0 || b == 0 || c == 0)
            //{
            //    return "0";
            //}
            //else if (a > 0 && b > 0 && c > 0)
            //{
            //    return "+";
            //}
            //else if (a < 0 && b < 0 && c < 0)
            //{
            //    return "+";
            //}
            //else if (a > 0 && b > 0 && c < 0)
            //{
            //    return "-";
            //}
            //else if (a < 0 && b > 0 && c > 0)
            //{
            //    return "-";
            //}
            //else if (a > 0 && b < 0 && c > 0)
            //{
            //    return "-";
            //}
            //else if (a > 0 && b < 0 && c < 0)
            //{
            //    return "+";
            //}
            //else if (a < 0 && b > 0 && c < 0)
            //{
            //    return "+";
            //}
            //else
            //{
            //    return "+";
            //}
        }
    }
}
