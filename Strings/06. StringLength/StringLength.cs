namespace _06.StringLength
{
    using System;

    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                input = input.PadRight(20, '*');
            }

            Console.WriteLine(input);
        }
    }
}
