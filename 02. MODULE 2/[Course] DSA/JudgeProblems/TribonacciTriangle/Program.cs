using System;

class Program
{
    static void Main()
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());
        long thirdNum = long.Parse(Console.ReadLine());
        long l = long.Parse(Console.ReadLine());
        long prevF;
        long prevS;
        long prevT;
        long temp, tempS;
        long[] arr = new long[20];
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