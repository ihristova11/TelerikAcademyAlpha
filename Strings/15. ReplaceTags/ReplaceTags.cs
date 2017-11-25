namespace _15.ReplaceTags
{
    using System;
    using System.Text;

    class ReplaceTags
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            string copy = String.Copy(input);
            // string url = input.Substring(input.IndexOf("href");
            string url = "";
            string text = "";
            string oldStr = "";
            string newStr = "";
            while (input.IndexOf("href") != -1)
            {
                input = input.Remove(0, input.IndexOf("href") + "href=".Length + 1);
                url = input.Substring(0, input.IndexOf(">") - 1);
                input = input.Remove(0, url.Length + 2);
                text = input.Substring(0, input.IndexOf("</a>"));
                oldStr = "<a href=\"" + url + "\">" + text + "</а>";
                newStr = "[" + text + "](" + url + ")";
                copy = copy.Replace(oldStr, newStr);
                //Console.WriteLine(copy);
            }
            Console.WriteLine();
            Console.WriteLine(input);
            Console.WriteLine();
            Console.WriteLine(url);
            Console.WriteLine();
            Console.WriteLine(text);

            Console.WriteLine("------COPY------------");
            Console.WriteLine(copy);
            Console.WriteLine();
            Console.WriteLine("..........................");
            Console.WriteLine(oldStr);
            Console.WriteLine(newStr);
        }
    }
}
