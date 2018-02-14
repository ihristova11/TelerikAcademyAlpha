using System;
using System.Collections.Generic;
using System.Linq;

namespace BiggestOfFive
{
    public class Program
    {
        static void Main()
        {
            List<double> numbers = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine(numbers.Max());
        }
    }
}
