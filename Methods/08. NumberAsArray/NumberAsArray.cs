namespace _08.NumberAsArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class NumberAsArray
    {
        static void Main()
        {
            //reading the input
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] firstNumber = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondNumber = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(  SumNumbers(firstNumber, secondNumber)); 
        }

        public static string SumNumbers(int[] firstNum, int[] secondNum)
        {
            var result = new List<int>();
            int carry = 0;

            if (firstNum.Length < secondNum.Length)
            {
                return SumNumbers(secondNum, firstNum);
            }

            for (int i = 0; i < secondNum.Length; i++)
            {
                if (firstNum[i] + secondNum[i] + carry < 10)
                {
                    result.Add(firstNum[i] + secondNum[i] + carry);
                    carry = 0;
                }
                else
                {
                    result.Add((firstNum[i] + secondNum[i] + carry) % 10);
                    carry = 1;
                }
            }

            for (int j = secondNum.Length; j < firstNum.Length; j++)
            {
                if (firstNum[j] + carry < 10)
                {
                    result.Add(firstNum[j] + carry);
                    carry = 0;
                }
                else
                {
                    result.Add((firstNum[j] + carry) % 10);
                    carry = 1;
                }
            }

            return string.Join(" ", result);
        }
    }
}