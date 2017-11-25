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
            //string copy = String.Copy(input);
            // string url = input.Substring(input.IndexOf("href");
            string url = "";
            string text = "";
            string oldStr = "";
            int index = 0;
            string newStr = "";
            while (input.IndexOf("href") != -1)
            {
                input = input.Remove(0, input.IndexOf("href") + "href=".Length + 1);
                url = input.Substring(0, input.IndexOf(">") - 1);
                input = input.Remove(0, url.Length + 2);
                text = input.Substring(0, input.IndexOf("</a>"));
                oldStr = "<a href=\"" + url + "\">" + text + "</а>";
                newStr = "[" + text + "](" + url + ")";
                index = sb.ToString().IndexOf("<a");
                sb = sb.Remove(index, oldStr.Length);
                sb = sb.Insert(index, newStr);
            }
            Console.WriteLine(sb);
        }
    }
}
