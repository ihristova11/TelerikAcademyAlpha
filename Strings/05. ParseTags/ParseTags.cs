namespace _05.ParseTags
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ParseTags
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"<upcase>(.*?)</upcase>";

            Console.WriteLine(Regex.Replace(text, pattern, word => word.Groups[1].Value.ToUpper()));
        }
    }
}
