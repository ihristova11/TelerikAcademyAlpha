using System;

namespace BonusScore
{
    public class Program
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());

            Console.WriteLine(AddBonus(score));
        }

        static string AddBonus(int score)
        {
            if (score >= 1 && score <= 3)
            {
                score *= 10;
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
            }
            else if (score <= 0 || score > 9)
            {
                return "invalid score";
            }

            return score.ToString();
        }
    }
}
