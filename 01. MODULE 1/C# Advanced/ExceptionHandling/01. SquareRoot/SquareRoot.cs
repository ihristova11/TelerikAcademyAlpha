namespace _01.SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine(Math.Sqrt(number).ToString("F3"));
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
