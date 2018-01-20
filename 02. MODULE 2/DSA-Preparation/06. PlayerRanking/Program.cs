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
                result = this.Age.CompareTo(other.Age);
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
            Dictionary<string, OrderedSet<Player>> typeToPlayerMap = new Dictionary<string, OrderedSet<Player>>();
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

                        if (typeToPlayerMap.ContainsKey(type))
                        {
                            if (typeToPlayerMap[type].Count == 5)
                            {
                                Player lastPlayer = typeToPlayerMap[type][4];
                                if (lastPlayer.CompareTo(player) > 0)
                                {
                                    typeToPlayerMap[type].Remove(lastPlayer);
                                    typeToPlayerMap[type].Add(player);
                                }
                            }
                            else
                            {
                                typeToPlayerMap[type].Add(player);
                            }
                        }
                        else
                        {
                            typeToPlayerMap[type] = new OrderedSet<Player>();
                            typeToPlayerMap[type].Add(player);
                        }

                        allPlayersRanklist.Insert(position - 1, player);

                        result.AppendFormat("Added player {0} to position {1}", player.Name, position);
                        result.AppendLine();
                        break;
                    case "find": // find top 5 units
                        string findType = commandParameters[1];
                        if (typeToPlayerMap.ContainsKey(findType))
                        {
                            var players = typeToPlayerMap[findType];
                            result.AppendFormat("Type {0}:", findType);
                            foreach (Player p in players)
                            {
                                result.AppendFormat(" {0};", p);
                            }

                            result.Remove(result.Length - 1, 1);
                            result.AppendLine();
                        }
                        else
                        {
                            result.AppendFormat("Type {0}: ", findType);
                            result.AppendLine();
                        }
                        break;
                    case "ranklist":
                        int start = int.Parse(commandParameters[1]);
                        int end = int.Parse(commandParameters[2]);
                        int count = end - start + 1;
                        var rankedPlayers = allPlayersRanklist.Range(start - 1, count);

                        int playerPosition = start;
                        foreach (Player p in rankedPlayers)
                        {
                            result.AppendFormat("{0}. {1}; ", playerPosition++, p);
                        }

                        result.Remove(result.Length - 2, 2);
                        result.AppendLine();
                        break;
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
