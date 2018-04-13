using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace _03.SuperMarketQueue
{
    public class Program
    {
        private static BigList<string> queue = new BigList<string>();
        private static Dictionary<string, int> names = new Dictionary<string, int>();
        private static StringBuilder result = new StringBuilder();
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                var commandParameters = input.Split(' ');

                switch (commandParameters[0])
                {
                    case "Append":
                        var nameToAppend = commandParameters[1];

                        queue.Add(nameToAppend);
                        if (!names.ContainsKey(nameToAppend))
                        {
                            names.Add(nameToAppend, 0);
                        }

                        names[nameToAppend]++;
                        //Console.WriteLine("OK");
                        result.AppendLine("OK");
                        break;
                    case "Insert":
                        var positionToInsert = int.Parse(commandParameters[1]);
                        var nameToInsert = commandParameters[2];

                        if (positionToInsert >= 0 && positionToInsert <= queue.Count)
                        {
                            queue.Insert(positionToInsert, nameToInsert);
                            if (!names.ContainsKey(nameToInsert))
                            {
                                names.Add(nameToInsert, 0);
                            }

                            names[nameToInsert]++;
                            //Console.WriteLine("OK");
                            result.AppendLine("OK");
                        }
                        else
                        {
                        result.AppendLine("Error");
                            //Console.WriteLine("Error");
                        }
                        break;
                    case "Find":
                        var nameToFind = commandParameters[1];

                        if (names.ContainsKey(nameToFind))
                        {
                            //Console.WriteLine(names[nameToFind]);
                            result.AppendLine(names[nameToFind].ToString());
                        }
                        else
                        {
                            //Console.WriteLine(0);
                            result.AppendLine("0");
                        }
                        break;
                    case "Serve":
                        var numberOfPeople = int.Parse(commandParameters[1]);
                        if (numberOfPeople <= queue.Count)
                        {
                            var sb = new StringBuilder();
                            var personName = string.Empty;
                            for (int i = 0; i < numberOfPeople; i++)
                            {
                                personName = queue[i];
                                sb.AppendFormat("{0} ", personName);
                                names[personName]--;
                            }

                            queue.RemoveRange(0, numberOfPeople);
                            result.AppendLine(sb.ToString().TrimEnd());
                        }
                        else
                        {
                            //Console.WriteLine("Error");
                            result.AppendLine("Error");

                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(result);
        }
    }
}