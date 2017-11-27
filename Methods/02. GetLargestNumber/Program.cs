namespace _02.GetLargestNumber
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstNum = input[0];
            int secondNum = input[1];
            int thirdNum = input[2];
            int maxNumber = GetMax(GetMax(firstNum, secondNum), GetMax(secondNum, thirdNum));
            Console.WriteLine(maxNumber);
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {
            int maxNumber = firstNumber < secondNumber ? secondNumber : firstNumber;

            return maxNumber;
        }
    }
}
