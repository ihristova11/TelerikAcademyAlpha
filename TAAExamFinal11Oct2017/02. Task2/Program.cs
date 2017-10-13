using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
        BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
        BigInteger l = BigInteger.Parse(Console.ReadLine());
        BigInteger prevF;
        BigInteger prevS;
        BigInteger prevT;
        BigInteger temp, tempS;
        BigInteger[] arr = new BigInteger[20];
        string printLine = "";
        prevF = firstNum + secondNum + thirdNum;
        prevS = secondNum + thirdNum + prevF;
        prevT = thirdNum + prevF + prevS;
        //print first and second line
        Console.WriteLine(firstNum);
        Console.WriteLine(secondNum + " " + thirdNum);

        if (l > 2)
        {
            Console.WriteLine(prevF + " " + prevS + " " + prevT);
            for (int i = 4; i <= l; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //prevF = prevF + prevS + prevT;
                    //prevS = prevF + prevS + prevT;
                    //prevT = prevF + prevS + prevT;
                    arr[j] = prevF + prevS + prevT;
                    temp = prevT;
                    tempS = prevS;
                    prevT = arr[j];
                    prevS = temp;
                    prevF = tempS;
                    if (j == i - 1)
                    {
                        printLine += arr[j];
                    }
                    else
                    {
                        printLine += arr[j] + " ";
                    }
                        //string.Format(" ", arr[j]);
                }
                Console.WriteLine(printLine);
                printLine = "";
                //Console.WriteLine(prevF + " " + prevS + " " + prevT); // print the line
            }
        }
    }
}

