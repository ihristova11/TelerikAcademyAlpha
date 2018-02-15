using System;

class BinaryToDecimal
{
    static void Main()
    {
        var s = Console.ReadLine(); 
        long dec = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[s.Length - i - 1] == '0') continue;
            dec += (long)Math.Pow(2, i);
        }

        Console.WriteLine(dec);
    }
}