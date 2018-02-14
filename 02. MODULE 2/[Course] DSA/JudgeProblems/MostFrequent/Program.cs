using System;
using System.Linq;

namespace MostFrequent
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var number = (from all in numbers
                          group all by all into gr
                          orderby gr.Count() descending
                          select new { Number = gr.Key, Frequency = gr.Count() }).First();

            Console.WriteLine("{0}({1} times)",
                number.Number, number.Frequency);
        }
    }
}
