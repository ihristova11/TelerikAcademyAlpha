namespace _12.ParseURL
{
    using System;

    class ParseURL
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string protocol = input.Substring(0, input.IndexOf(':'));

            input = input.Remove(0, input.IndexOf(':') + 3);

            string server = input.Substring(0, input.IndexOf('/'));

            input = input.Remove(0, input.IndexOf('/'));
            string resource = input;

            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + resource);
        }
    }
}
