namespace _01.SendMeTheCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SendMeTheCode
    {
        static void Main()
        {
            long result = 0;
            int s;
            string input = Console.ReadLine();
            List<int> digits = new List<int>();
            string message = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                digits.Add(int.Parse(input[i].ToString()));
            }
            
            for (int i = 0; i < digits.Count; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    result += digits[i] * digits[i] *( i + 1);
                }
                else
                {
                    result += digits[i] * (i + 1) * (i + 1);
                }
            }

            if (result % 10 == 0)
            {
                Console.WriteLine("10");
                Console.WriteLine("Big Vik wins again!");
                return;
            }
            else
            {
                s = (int)(result % 26);
                s++;
                for (int i = 0; i < result % 10; i++)
                {
                    if (('A' - 1 + s + i) > 'Z')
                    {
                        s = -1 * i + 1;
                    }
                    message += (char)('A' - 1 + s + i);
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(message);
        }
    }
}
