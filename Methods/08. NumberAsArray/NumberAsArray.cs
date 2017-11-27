namespace _08.NumberAsArray
{
    using System;
    using System.Linq;

    class NumberAsArray
    {
        static void Main()
        {
            //reading the input
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] firstNumber = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondNumber = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            SumNumbers(firstNumber, secondNumber);
        }

        public static void SumNumbers(int[] firstNum, int[] secondNum)
        {
            int[] result = new int[Math.Max(firstNum.Length, secondNum.Length) + 1];

            for (int i = 0; i < Math.Min(firstNum.Length, secondNum.Length); i++)
            {
                if (firstNum[i] + secondNum[i] < 10)
                {
                    result[i] += firstNum[i] + secondNum[i];
                }
                else
                {
                    result[i] += (firstNum[i] + secondNum[i]) % 10;
                    result[i + 1] += 1;
                }
            }

            if(firstNum.Length > secondNum.Length)
            {
                for (int i = secondNum.Length; i < firstNum.Length; i++)
                {
                    result[i] += firstNum[i];
                }
            }
            else if(secondNum.Length < firstNum.Length)
            {
                for (int i = firstNum.Length; i < secondNum.Length; i++)
                {
                    result[i] += secondNum[i];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
