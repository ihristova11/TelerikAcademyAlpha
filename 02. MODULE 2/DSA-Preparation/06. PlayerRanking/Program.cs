using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace _06.PlayerRanking
{
    public class Player
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

                        //todo: add player to all the lists
                        // todo: display message for adding player
                        break;
                    case "find": // find top 5 units
                        break;
                    case "ranklist":
                        break;
                }
            }
        }
    }
}
