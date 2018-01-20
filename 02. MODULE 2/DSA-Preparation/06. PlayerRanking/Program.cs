using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace _06.PlayerRanking
{
    public class Player : IComparable<Player>
    {
        public Player(string name, string type, int age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public int CompareTo(Player other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age) * -1;
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Age);
        }
    }

    public class Program
    {
        static void Main()
        {
            BigList<Player> allPlayersRanklist = new BigList<Player>();
            Dictionary<string, SortedSet<Player>> typeToPlayerMap = new Dictionary<string, SortedSet<Player>>();
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "end")
            {
                var commandParameters = line
                    .Split(' ')
                    .ToArray();

                string choice = commandParameters[0];

                switch (choice)
                {
                    case "add":
                        string name = commandParameters[1];
                        string type = commandParameters[2];
                        int age = int.Parse(commandParameters[3]);
                        int position = int.Parse(commandParameters[4]);

                        Player player = new Player(name, type, age);

                        if (!typeToPlayerMap.ContainsKey(type))
                        {
                            typeToPlayerMap.Add(type, new SortedSet<Player>());
                        }

                        typeToPlayerMap[type].Add(player);
                        allPlayersRanklist.Insert(position - 1, player);
                        Console.WriteLine("Added player {0} to position {1}", player.Name, position);
                        break;
                    case "find": // find top 5 units
                        string findType = commandParameters[1];

                        if (typeToPlayerMap.ContainsKey(findType))
                        {
                            var found = typeToPlayerMap[findType].Take(5);
                            Console.WriteLine("Type {0}: {1}", findType, string.Join("; ", found));
                        }
                        else
                        {
                            Console.WriteLine("Type {0}: ", findType);
                        }
                        break;
                    case "ranklist":
                        int start = int.Parse(commandParameters[1]);
                        int end = int.Parse(commandParameters[2]);
                        int count = end - start + 1;
                        var ranked = allPlayersRanklist.Range(start - 1, count);
                        foreach (var pl in ranked)
                        {
                            result.AppendFormat("{0}. {1}; ", start++, pl);
                        }

                        string output = result.ToString().TrimEnd(';', ' ');
                        Console.WriteLine(output);
                        result.Clear();
                        break;
                }
            }
        }
    }
}
