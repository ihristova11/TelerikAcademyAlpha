using System;
using System.Linq;

namespace _03.Speeds
{
    class Speeds
    {
        static void Main()
        {
            int c = int.Parse(Console.ReadLine());
            int[] carSpeeds = new int[c];
            int[] carLength = new int[c];
            int[] indexL = new int[c];
            int len = 1;
            int lastIndex = 0;
            int counter = 0;
            int maxSum = int.MinValue;
            int sum = 0;
            int maxLen = 1;
            for (int i = 0; i < c; i++)
            {
                carSpeeds[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 1; k < c; k++)
            {
                if (carSpeeds[k - 1] < carSpeeds[k])
                {
                    len++;
                    lastIndex = k;
                    //Console.WriteLine("len==" + len);
                    //Console.WriteLine("last index==" + k);
                    //Console.WriteLine("------------------------------------------------------------");
                }
                else
                {
                    //Console.WriteLine("//****////");
                    carLength[counter] = len;
                    indexL[counter] = lastIndex;

                    //Console.WriteLine("carLength[counter]{0}=={1}", counter, carLength[counter]);
                    //Console.WriteLine("indexL[counter]{0}=={1}", counter, indexL[counter]);
                    //Console.WriteLine("------------------------------------------------------------");

                    len = 1;
                    counter++;
                }
                if (k == c - 1)
                {
                    carLength[counter] = len;
                    indexL[counter] = lastIndex;

                    //Console.WriteLine("carLength[counter]{0}=={1}", counter, carLength[counter]);
                    //Console.WriteLine("indexL[counter]{0}=={1}", counter, indexL[counter]);
                    //Console.WriteLine("------------------------------------------------------------");

                    len = 1;
                    counter++;
                }
            }

            for (int j = 0; j < c; j++)
            {
                if (carLength[j] > maxLen)
                {
                    maxLen = carLength[j];
                }
            }

            for (int l = 0; l < c; l++)
            {
                if (carLength[l] == maxLen)
                {
                    for (int p = indexL[l]; p >= (indexL[l] - carLength[l] + 1); p--)
                    {
                        sum += carSpeeds[p];
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
            ////testing
            //for (int i = 0; i < c; i++)
            //{
            //    Console.WriteLine("carLength[{0}]==", i + carLength[i]);
            //    Console.WriteLine();
            //    Console.WriteLine("indexL[{0}]==", i + indexL[i]);
            //}


        }
    }
}
