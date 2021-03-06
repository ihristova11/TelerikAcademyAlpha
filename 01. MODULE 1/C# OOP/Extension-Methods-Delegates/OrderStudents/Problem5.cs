﻿using System;
using System.Collections.Generic;
using FirstBeforeLast;

namespace OrderStudents
{
    using System.Linq;

    public class Problem5
    {
        static void Main()
        {
            var students = new List<Student>
            {
                new Student("Irina", "Hristova"),
                new Student("Ivan", "Ivanov"),
                new Student("Pesho", "Peshov")
            };
            FindStudents(students);
        }

        public static void FindStudents(List<Student> students)
        {
            var found = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName);

            foreach (var student in found)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}
