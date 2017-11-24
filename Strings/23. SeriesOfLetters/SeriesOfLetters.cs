namespace _23.SeriesOfLetters
{
    using System;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            int i = 0;
            while(i != sb.Length - 1)
            {
                if (sb[i] == sb[i + 1])
                {
                    sb.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
