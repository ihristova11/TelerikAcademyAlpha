namespace _04.SubstringInText
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class SubstringInText
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            int count = new Regex(Regex.Escape(pattern), RegexOptions.IgnoreCase).Matches(text).Count;
            Console.WriteLine(count);
        }
    }
}
