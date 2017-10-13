using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<BigInteger> numbers = new List<BigInteger>(Array.ConvertAll(input.Split(' '), BigInteger.Parse));
        BigInteger distance = 0;
        BigInteger sum = 0;

        //for (int i = 1; i < numbers.Count; i++)
        //{
        //    distance = (BigInteger)(Math.Abs(numbers[i - 1] - numbers[i])); // finds the distance

        //    //moving positions
        //    if (distance % 2 == 0)
        //    {
        //        sum += distance;
        //        i++;
        //    }
        //}

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i - 1] >= numbers[i])
            {
                distance = numbers[i - 1] - numbers[i];
            }
            else
            {
                distance = numbers[i] - numbers[i - 1];
            }
            //moving positions
            if (distance % 2 == 0)
            {
                sum += distance;
                i++;
            }
        }

        Console.WriteLine(sum);




        //while(j < numbers.Count)
        //{
        //    distance = (BigInteger)(Math.Abs(numbers[j - 1] - numbers[j]));
        //    if (distance % 2 == 0)
        //    {
        //        sum += distance;
        //        j += 2;
        //    }
        //    else
        //    {
        //        j++;
        //    }
        //}
    }
}

