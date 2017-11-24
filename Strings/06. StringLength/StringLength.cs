namespace _06.StringLength
{
    using System;

    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int len = input.Length;

            if (input.Length < 20)
            {
                //Console.WriteLine(input.PadRight((20 - len), '*'));
                input = input.PadRight(20, '*');
            }

            Console.WriteLine(input);
        }
    }
}
