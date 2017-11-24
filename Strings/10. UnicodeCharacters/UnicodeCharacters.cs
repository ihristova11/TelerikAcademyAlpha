namespace _10.UnicodeCharacters
{
    using System;
    using System.Text;

    class UnicodeCharacters
    {
        public static StringBuilder sb = new StringBuilder(Console.ReadLine());
        public static StringBuilder res = new StringBuilder();

        static void Main()
        {
            char ch;
            for (int i = 0; i < sb.Length; i++)
            {
                ch = sb[i];
                ConvertToUnicode(ch);
            }
            Console.WriteLine(res);
        }

        public static void ConvertToUnicode(char ch)
        {
            res.Append("\\u");
            res.Append(((int)ch).ToString("X4"));
        }
    }
}
