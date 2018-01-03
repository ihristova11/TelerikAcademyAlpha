namespace _01.SayHello
{
    using System;

    class SayHello
    {
        static void Main()
        {
            string name = Console.ReadLine();

            Console.WriteLine(SayHello(name));
        }

        public static string SayHello(string name)
        {
            return "Hello, " + name + "!";
        }
    }
}
