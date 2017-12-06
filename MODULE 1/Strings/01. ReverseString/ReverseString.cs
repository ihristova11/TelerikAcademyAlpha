namespace _01.ReverseString
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class ReverseString
    {
        static void Main()
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);

            //---ANOTHER IDEA---
            //string str = Console.ReadLine();
            //var chars = new Stack<char>();
            //foreach (var ch in str)
            //{
            //    chars.Push(ch);
            //}
            //Console.WriteLine(string.Join("", chars));
        }
    }
}
