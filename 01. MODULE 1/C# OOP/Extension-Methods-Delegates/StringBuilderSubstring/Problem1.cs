namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    public static class Problem1
    {
        static void Main()
        {
            //testing
            StringBuilder strb = new StringBuilder("Irina");
            Console.WriteLine(strb.Substring(0, 2));
        }

        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                result.Append(sb[i]);
            }

            return result;
        }
    }
}
