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
            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper()));
        }
    }
}
