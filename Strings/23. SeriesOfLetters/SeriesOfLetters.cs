namespace _23.SeriesOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main()
        {
            //solution with HashSet
            string input = Console.ReadLine();
            HashSet<string> hs = new HashSet<string>();

            foreach (var ch in input)
            {
                hs.Add(ch.ToString());
            }
            Console.WriteLine(string.Join("", hs));

            //solution with StringBuilder
            //StringBuilder sb = new StringBuilder(Console.ReadLine());
            //int i = 0;
            //while(i != sb.Length - 1)
            //{
            //    if (sb[i] == sb[i + 1])
            //    {
            //        sb.Remove(i, 1);
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}
            //Console.WriteLine(sb.ToString());
        }
    }
}
