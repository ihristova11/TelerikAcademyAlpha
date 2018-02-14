using System;

namespace CheckForPlayCard
{
    public class Program
    {
        static void Main()
        {
            //string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            string input = Console.ReadLine();
            Console.WriteLine(IsCard(input));
        }

        static string IsCard(string input)
        {
            int.TryParse(input, out int result);
            if (result >= 2 && result <= 10)
            {
                return string.Format("yes {0}", input);
            }
            else if (input.ToUpper() == "Q")
            {
                return string.Format("yes {0}", input);
            }
            else if (input.ToUpper() == "K")
            {
                return string.Format("yes {0}", input);
            }
            else if (input.ToUpper() == "J")
            {
                return string.Format("yes {0}", input);
            }
            else if (input.ToUpper() == "A")
            {
                return string.Format("yes {0}", input);
            }
            else
            {
                return string.Format("no {0}", input);
            }
        }
    }
}
