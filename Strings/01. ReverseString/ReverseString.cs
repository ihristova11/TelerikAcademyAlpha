namespace _01.ReverseString
{
    using System;

    class ReverseString
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
