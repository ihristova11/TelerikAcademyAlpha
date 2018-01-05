using System;


namespace _02.MergingAndSquashing
{
    class MergingAndSquashing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            string[] squashed = new string[n - 1];
            string[] merged = new string[n - 1];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                //merged operations
                merged[i - 1] += (numbers[i - 1] % 10).ToString();
                merged[i - 1] += (numbers[i] / 10).ToString();

                //squash operations
                squashed[i - 1] += (numbers[i - 1] / 10).ToString();

                if(numbers[i - 1] % 10 + numbers[i] / 10 >= 10)
                {
                    squashed[i - 1] += ((numbers[i - 1] % 10 + numbers[i] / 10) % 10).ToString();
                }
                else
                {
                    squashed[i - 1] += (numbers[i - 1] % 10 + numbers[i] / 10).ToString();
                }
                squashed[i - 1] += (numbers[i] % 10).ToString();
            }

            //print merged numbers
            Console.WriteLine(string.Join(" ", merged));

            //print squashed numbers
            Console.WriteLine(string.Join(" ", squashed));
        }
    }
}
