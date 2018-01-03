namespace _03.AllocateArray
{
    using System;

    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}
