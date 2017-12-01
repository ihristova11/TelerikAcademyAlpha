namespace _05.ExchangeIfGreater
{
    using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            double a, b;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
