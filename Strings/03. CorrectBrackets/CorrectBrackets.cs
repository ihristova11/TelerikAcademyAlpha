namespace _03.CorrectBrackets
{
    using System;
    using System.Text.RegularExpressions;

    class CorrectBrackets
    {
        static void Main()
        {
            int leftB = 0;
            int rightB = 0;
            string input = Console.ReadLine();
            string output;

            leftB = new Regex(Regex.Escape("("), RegexOptions.IgnoreCase).Matches(input).Count;
            rightB = new Regex(Regex.Escape(")"), RegexOptions.IgnoreCase).Matches(input).Count;

            if(leftB.Equals(rightB) == false)
            {
                output = "Incorrect";
            }
            else if(input.IndexOf(')') < input.IndexOf('('))
            {
                output = "Incorrect";
            }
            else
            {
                output = "Correct";
            }

            Console.WriteLine(output);
        }
    }
}
