namespace _03.EnglishDigit
{
    using System;

    class EnglishDigit
    {
        static void Main()
        {
            Console.WriteLine(PrintTheDigitName());
        }

        public static string PrintTheDigitName()
        {
            string number = Console.ReadLine();
            int lastDigit = int.Parse(number[number.Length - 1].ToString());

            switch(lastDigit)
            {
                case 0:
                    return "zero";
                    break;
                case 1:
                    return "one";
                    break;
                case 2:
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                case 4:
                    return "four";
                    break;
                case 5:
                    return "five";
                    break;
                case 6:
                    return "six";
                    break;
                case 7:
                    return "seven";
                    break;
                case 8:
                    return "eight";
                    break;
                case 9:
                    return "nine";
                    break;
                default:
                    return "incorrect";
                    break;
            }
        }
    }
}
