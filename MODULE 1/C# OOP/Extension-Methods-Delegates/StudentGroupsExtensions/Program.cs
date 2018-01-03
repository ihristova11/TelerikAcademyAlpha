using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using StudentGroups;

namespace StudentGroupsExtensions
{
    public static class Program
    {
        public static IEnumerable<Student> FindStudentsWithGroupNumber(this IList<Student> studentsList)
        {
            var studentsWithGroupNumber2 = studentsList.Where(s => s.GroupNumber == 2);
            return studentsWithGroupNumber2;
        }

        static void Main()
        {
            var list = new List<Student>()
            {
                new Student("Irina", "Hristova", 123456, "123456", "someemail@email.com", new List<int>() {6, 6, 6}, 2),
                new Student("Ivan", "Hristova", 123456, "123456", "someemail@email.com", new List<int>() {6, 6, 6}, 3),
                new Student("Pesho", "Is Back", 123456, "123456", "someemail@email.com", new List<int>() {6, 6, 6}, 2)
            };

            foreach (var student in list.FindStudentsWithGroupNumber())
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
