using System;

namespace _07.UnitsOfWork
{
    public class Unit : IComparable<Unit>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Attack { get; set; }

        public int CompareTo(Unit other)
        {
            throw new NotImplementedException();
        }
    }

    public class Program
    {
        static void Main()
        {
        }
    }
}
