﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using StudentGroups;

namespace StudentGroupsExtensions
{
    public static class Program
    {
        public static void Main()
        {
            var list = new List<Student>()
            {
                new Student("Irina", "Hristova", 123456, "123456", "irina99@abv.bg", new List<int>() {6, 6, 6}, 2),
                new Student("Ivan", "Hristov", 123456, "02813456", "someemail@email.com", new List<int>() {6, 6, 6}, 3),
                new Student("Pesho", "Is Back", 123456, "123456", "someemail@email.com", new List<int>() {6, 6, 6}, 2)
            };

            foreach (var student in list.FindStudentsWithGroupNumber())
            {
                Console.WriteLine($"{student.ToString()} <--- student with group number 2");
            }

            foreach (var student in list.FindStudentsWithSofiaTel())
            {
                Console.WriteLine($"{student.ToString()} <--- student Sofia tel");
            }

            foreach (var student in list.FindStudentsWithEmail("abv.bg"))
            {
                Console.WriteLine($"{student.ToString()} <--- student with abv.bg email");
            }
        }

        //extensions methods

        // --- PROBLEM 10 ---
        public static IEnumerable<Student> FindStudentsWithGroupNumber(this IList<Student> studentsList)
        {
            var studentsWithGroupNumber2 = studentsList.Where(s => s.GroupNumber == 2);
            return studentsWithGroupNumber2;
        }

        // --- PROBLEM 11 ---
        public static IEnumerable<Student> FindStudentsWithEmail(this IList<Student> studentsList, string email)
        {
            var studentsWithGroupNumber2 = studentsList.Where(s => s.Email.Contains("abv.bg"));
            return studentsWithGroupNumber2;
        }

        // --- PROBLEM 12 ---
        public static IEnumerable<Student> FindStudentsWithSofiaTel(this IList<Student> studentsList)
        {
            var studentsWithGroupNumber2 = studentsList.Where(s => s.Tel[0] == '0' && s.Tel[1] == '2');
            return studentsWithGroupNumber2;
        }
    }
}
