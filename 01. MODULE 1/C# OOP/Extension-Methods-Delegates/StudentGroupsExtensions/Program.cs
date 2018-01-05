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
            
            PrintStudents(list.FindStudentsWithGroupNumber());
            PrintStudents(list.FindStudentsWithEmail("abv.bg"));
            PrintStudents(list.FindStudentsWithSofiaTel());
            PrintStudents(list.FindStrudentsWithExcellentMark());

        }

        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.ToString()}");
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
            var studentsWithEmail = studentsList.Where(s => s.Email.Contains("abv.bg"));
            return studentsWithEmail;
        }

        // --- PROBLEM 12 ---
        public static IEnumerable<Student> FindStudentsWithSofiaTel(this IList<Student> studentsList)
        {
            var studentsWithSofiaTel = studentsList.Where(s => s.Tel[0] == '0' && s.Tel[1] == '2');
            return studentsWithSofiaTel;
        }

        // --- PROBLEM 13 ---
        public static IEnumerable<Student> FindStrudentsWithExcellentMark(this IList<Student> studentsList)
        {
            var studentsWithExcellentMarks = studentsList.Where(s => s.Marks.Any(m => m == 6));
            return studentsWithExcellentMarks; ;
        }
    }
}
