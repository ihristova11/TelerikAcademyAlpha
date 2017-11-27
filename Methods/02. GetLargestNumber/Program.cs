namespace _02.GetLargestNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
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
