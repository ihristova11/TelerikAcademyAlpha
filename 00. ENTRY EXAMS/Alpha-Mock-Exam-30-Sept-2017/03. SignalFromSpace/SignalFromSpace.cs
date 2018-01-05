using System;


namespace _03.SignalFromSpace
{
    class SignalFromSpace
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if(input[i] != input[i + 1])
                {
                    result += input[i];
                }
            }
            result += input[input.Length - 1];
            Console.WriteLine(result);
        }
    }
}
