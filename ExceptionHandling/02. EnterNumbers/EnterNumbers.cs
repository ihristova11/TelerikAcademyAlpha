namespace _02.EnterNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class EnterNumbers
    {
        //public static int number;
        public static int count = 1;
        public static List<int> enteredNumbers = new List<int>();
        //public static bool isSorted = true;

        static void Main()
        {
            ReadNumber(0, 100);
        }

        public static void ReadNumber(int start, int end)
        {
            for (int i = 0; i < 10; i++)
            {
                enteredNumbers.Add(int.Parse(Console.ReadLine()));
            }

            try
            {
                if (enteredNumbers.Any(x => x < start) || enteredNumbers.Any(x => x > end) || !IsSorted())
                {
                    throw new Exception();
                }
                Console.WriteLine("1 < " + string.Join(" < ", enteredNumbers) + " < 100");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        public static bool IsSorted()
        {
            for (int i = 0; i < enteredNumbers.Count - 1; i++)
            {
                if (enteredNumbers[i] >= enteredNumbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
