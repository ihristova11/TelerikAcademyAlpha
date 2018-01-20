using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.JediMeditation
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sequenceOfJedis = Console.ReadLine()
                .Split(' ')
                .ToArray();

            LinkedList<string> orderedJedis = new LinkedList<string>();

            OrderJedis(orderedJedis, sequenceOfJedis);
            Console.WriteLine(string.Join(" ", orderedJedis));
        }

        private static void OrderJedis(LinkedList<string> orderedJedis, string[] sequenceOfJedis)
        {
            LinkedListNode<string> m = null;
            LinkedListNode<string> k = null;
            LinkedListNode<string> p = null;

            foreach (var jedi in sequenceOfJedis) // M > K > P
            {
                switch (jedi[0])
                {
                    case 'M':
                        var newM = new LinkedListNode<string>(jedi);
                        if (m == null)
                        {
                            orderedJedis.AddFirst(newM);
                        }
                        else
                        {
                            orderedJedis.AddAfter(m, newM);
                        }

                        m = newM; // make the newM last el
                        break;
                    case 'K':
                        var newK = new LinkedListNode<string>(jedi);
                        if (k == null)
                        {
                            if (m == null)
                            {
                                orderedJedis.AddFirst(newK);
                            }
                            else
                            {
                                orderedJedis.AddAfter(m, newK);
                            }
                        }
                        else
                        {
                            orderedJedis.AddAfter(k, newK);
                        }

                        k = newK; // make newK last el
                        break;
                    case 'P':
                        var newP = new LinkedListNode<string>(jedi);
                        if (p == null)
                        {
                            if (k == null)
                            {
                                if (m == null)
                                {
                                    orderedJedis.AddFirst(newP);
                                }
                                else
                                {
                                    orderedJedis.AddAfter(m, newP);
                                }
                            }
                            else
                            {
                                orderedJedis.AddAfter(k, newP);
                            }
                        }
                        else
                        {
                            orderedJedis.AddAfter(p, newP);
                        }

                        p = newP; // make newP last el
                        break; ;
                }
            }

        }
    }
}
