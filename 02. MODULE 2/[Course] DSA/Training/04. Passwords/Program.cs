using System;
using System.Linq;

namespace _04.Passwords
{
    public class Program
    {
        static void Main()
        {
            string line = Console.ReadLine();
            var parameters = line.Split(' ').ToArray();
            int n = int.Parse(parameters[0]); // pass len
            var symbols = parameters[1].ToCharArray();
            int k = int.Parse(parameters[2]); // k-th possible pass


        }
    }
}
