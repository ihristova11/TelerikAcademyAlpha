using System;

namespace IntDoubleString
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "integer":
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine(x + 1);
                    break;
                case "real":
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", r + 1);
                    break;
                case "text":
                    string t = Console.ReadLine();
                    Console.WriteLine(t + "*");
                    break;
            }
        }
    }
}
