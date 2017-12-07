namespace _15.ReplaceTags
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
            Console.WriteLine(parsedHTML);
        }
    }
}
