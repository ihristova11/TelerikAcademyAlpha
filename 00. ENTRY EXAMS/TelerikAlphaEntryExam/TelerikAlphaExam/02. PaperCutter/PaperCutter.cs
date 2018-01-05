using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PaperCutter
{
    class PaperCutter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int N = n;
            int counter = -1;
            string[] sheets = new string[11]
            {
                "A10", "A9", "A8", "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0"
            };


            while (n != 0)
            {
                n = n / 2;
                counter++;


                if (n == 0)
                {
                    sheets[counter] = "";
                    n = (int)(N - Math.Pow(2, counter));
                    N = (int)(N - Math.Pow(2, counter));
                    
                    if ((n == 0))
                    {
                        break;
                    }
                    else
                    {
                        counter = -1;
                    }
                }
                
            }
            
            for (int i = 0; i < sheets.Length; i++)
            {
                if (sheets[i] != "")
                {
                    Console.WriteLine(sheets[i]);
                }
            }
        }
    }
}
