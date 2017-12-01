namespace _06.Numbers1ToN
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Numbers1ToN
    {
        static void Main()
        {
            var list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
