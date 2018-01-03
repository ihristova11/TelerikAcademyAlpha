using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroups
{
    public class Program
    {
        static void Main()
        {
            var studentsClass = new List<Student>
            {
                new Student("Irina", "Hristova", 123456, "123456", "someemail@email.com", new List<int>() {6, 6, 6}, 2),
                new Student("Ivan", "Hristova", 123456, "123456", "someemail@email.com", new List<int>() {6, 6, 6}, 3),
                new Student("Pesho", "Is Back", 123456, "123456", "someemail@email.com", new List<int>() {6, 6, 6}, 2)

            };

            var studentsWithGroup2 = studentsClass.Where(s => s.GroupNumber == 2);
            foreach (var student in studentsWithGroup2)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
