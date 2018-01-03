using System;
using System.CodeDom;
using System.Collections.Generic;
using FirstBeforeLast;
using System.Linq;
namespace AgeRange
{
    public class Problem4
    {
        public static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Irina", "Hristova", 18),
                new Student("Ivan", "Hristov", 25),
                new Student("Ivan", "Ivanov", 19)
            };
            FindStudents(students);
        }

        public static void FindStudents(List<Student> students)
        {
            var foundStudents =
                from student in students
                where student.Age > 18 && student.Age < 24
                select student;

            foreach (var student in foundStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Age}");
            }
        }
    }
}
