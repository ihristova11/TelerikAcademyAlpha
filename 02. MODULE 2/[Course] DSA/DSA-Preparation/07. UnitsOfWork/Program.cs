using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.UnitsOfWork
{
    public class Unit : IComparable<Unit>
    {
        public Unit(string name, string type, int attack)
        {
            this.Name = name;
            this.Type = type;
            this.Attack = attack;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Attack { get; set; }

        public int CompareTo(Unit other)
        {
            int result = this.Attack.CompareTo(other.Attack) * -1;
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}[{1}]({2})", this.Name, this.Type, this.Attack);
        }
    }

    public class Program
    {
        static void Main()
        {
            Dictionary<string, SortedSet<Unit>> unitsByType = new Dictionary<string, SortedSet<Unit>>();
            Dictionary<string, Unit> unitsByName = new Dictionary<string, Unit>();
            SortedSet<Unit> unitsOrderedByAttack = new SortedSet<Unit>();
            StringBuilder resultBuilder = new StringBuilder();

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
                        int attack = int.Parse(commandParameters[3]);

                        Unit unit = new Unit(name, type, attack);

                        if (unitsByName.ContainsKey(unit.Name))
                        {
                            resultBuilder.AppendFormat("FAIL: {0} already exists!", unit.Name);
                            Console.WriteLine(resultBuilder);
                            resultBuilder.Clear();
                        }
                        else
                        {
                            unitsByName.Add(unit.Name, unit);
                            unitsOrderedByAttack.Add(unit);
                            if (!unitsByType.ContainsKey(unit.Type))
                            {
                                unitsByType.Add(unit.Type, new SortedSet<Unit>());
                            }

                            unitsByType[unit.Type].Add(unit);

                            resultBuilder.AppendFormat("SUCCESS: {0} added!", unit.Name);
                            Console.WriteLine(resultBuilder);
                            resultBuilder.Clear();
                        }
                        break;
                    case "remove":
                        string removeName = commandParameters[1];
                        if (unitsByName.ContainsKey(removeName))
                        {
                            Unit unitToRemove = unitsByName[removeName];
                            unitsByName.Remove(removeName);
                            unitsByType[unitToRemove.Type].Remove(unitToRemove);
                            unitsOrderedByAttack.Remove(unitsOrderedByAttack.First(x => x.Name == removeName));
                            resultBuilder.AppendFormat("SUCCESS: {0} removed!", removeName);
                            Console.WriteLine(resultBuilder);
                            resultBuilder.Clear();
                        }
                        else
                        {
                            resultBuilder.AppendFormat("FAIL: {0} could not be found!", removeName);
                            Console.WriteLine(resultBuilder);
                            resultBuilder.Clear();
                        }
                        break;
                    case "find":
                        string findType = commandParameters[1];
                        if (unitsByType.ContainsKey(findType))
                        {
                            var found = unitsByType[findType].Take(10);
                            resultBuilder.AppendFormat("RESULT: {0}", string.Join(", ", found));
                            Console.WriteLine(resultBuilder);
                            resultBuilder.Clear();
                        }
                        else
                        {
                            resultBuilder.Append("RESULT: ");
                            Console.WriteLine(resultBuilder);
                            resultBuilder.Clear();
                        }
                        break;
                    case "power":
                        int numberOfUnits = int.Parse(commandParameters[1]);
                        var powerUnits = unitsOrderedByAttack.Take(numberOfUnits);
                        resultBuilder.AppendFormat("RESULT: {0}", string.Join(", ", powerUnits));
                        Console.WriteLine(resultBuilder);
                        resultBuilder.Clear();
                        break;
                }
            }
        }
    }
}
