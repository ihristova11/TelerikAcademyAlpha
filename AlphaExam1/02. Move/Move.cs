﻿namespace _02.Move
{
    using System;
    using System.Linq;

    class Move
    {
        static void Main()
        {
            int position = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool notExit = true;

            while(notExit)
            {

            }
        }
    }
}