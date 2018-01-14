using System;
using System.Collections.Generic;
using System.Text;

namespace BracketsExpression
{
    public class BracketsExpression
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            Stack<int> openBracketsIndexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openBracketsIndexes.Push(i);
                }

                if (expression[i] == ')')
                {
                    for (int j = openBracketsIndexes.Pop(); j <= i; j++)
                    {
                        result.Append(expression[j]);
                    }
                    Console.WriteLine(result);
                    result.Clear();
                }
            }
        }
    }
}
