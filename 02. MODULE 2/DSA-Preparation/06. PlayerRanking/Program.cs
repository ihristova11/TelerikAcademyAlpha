using System;
using System.Collections.Generic;
using System.Linq;
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
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }
    }

    public class Program
    {
        static void Main()
        {
            BigList<Player> allPlayersRanklist = new BigList<Player>();
            Dictionary<string, SortedSet<Player>> typeToPlayerMap = new Dictionary<string, SortedSet<Player>>();

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
                        Console.WriteLine(string.Format("Added player {0} to position {1}", player.Name, position));
                        break;
                    case "find": // find top 5 units
                        string findType = commandParameters[1];

                        if (typeToPlayerMap.ContainsKey(findType))
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine("Type {0}: ", findType);
                        }
                        break;
                    case "ranklist":
                        break;
                }
            }
        }
    }
}
