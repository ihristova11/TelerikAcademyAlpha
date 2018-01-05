using System;
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
                new Student("Irina", "Hristova", 123406, "123456", "irina99@abv.bg", new List<int>() {6, 6, 6},2, "Mathematics"),
                new Student("Ivan", "Hristov", 123406, "02813456", "someemail@email.com", new List<int>() {6, 6}, 3, "Physics"),
                new Student("Pesho", "Is Back", 123456, "123406", "someemail@email.com", new List<int>() {2, 3, 4}, 2, "Astronomy")
            };

            PrintStudents(list.FindStudentsWithGroupNumber());
            PrintStudents(list.FindStudentsWithEmail("abv.bg"));
            PrintStudents(list.FindStudentsWithSofiaTel());
            PrintStudents(list.FindStrudentsWithExcellentMark());
            PrintStudents(list.FindStudentsWithTwoMarks());
            PrintStudentWithMarks(list.FindStudentsEnrolledIn2006("06"));
            PrintStudents(list.FindStudentsInMathDepartment("Mathematics"));
            PrintStudents(list.GroupStudentsByGroupNumber());
            PrintStudents(list.GroupStudentsByGroupName());
        }

        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.ToString()}");
            }
            Console.WriteLine();
        }

        public static void PrintStudentWithMarks(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.ToString()} - {string.Join(", ", student.Marks)}");
            }
            Console.WriteLine();
        }


        //extensions methods

        // --- PROBLEM 10 ---
        public static IEnumerable<Student> FindStudentsWithGroupNumber(this IList<Student> studentsList)
        {
            var studentsWithGroupNumber2 = studentsList.Where(s => s.Group.GroupNumber == 2);
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

        // --- PROBLEM 14 ---
        public static IEnumerable<Student> FindStudentsWithTwoMarks(this IList<Student> studentslList)
        {
            var studentsWithTwoMarks = studentslList.Where(s => s.Marks.Count == 2);
            return studentsWithTwoMarks;
        }

        // --- PROBLEM 15 ---
        public static IEnumerable<Student> FindStudentsEnrolledIn2006(this IList<Student> studentslistList, string year)
        {
            var studentsEnrolledIn2006 = studentslistList.Where(s => s.FN.ToString().EndsWith(year));
            return studentsEnrolledIn2006;
        }

        // --- PROBLEM 16* ---
        public static IEnumerable<Student> FindStudentsInMathDepartment(this IList<Student> studentslistList, string department)
        {
            var studentsEnrolledIn2006 = studentslistList.Where(s => s.Group.DepartmentName == department);
            return studentsEnrolledIn2006;
        }

        // --- PROBLEM 18 ---
        public static IEnumerable<Student> GroupStudentsByGroupNumber(this IList<Student> studentslistList)
        {
            var studentsGrouped = studentslistList.OrderBy(s => s.Group.GroupNumber);
            return studentsGrouped;
        }

        // --- PROBLEM 19 ---
        public static IEnumerable<Student> GroupStudentsByGroupName(this IList<Student> studentslistList)
        {
            var studentsGrouped = studentslistList.OrderBy(s => s.Group.DepartmentName);
            return studentsGrouped;
        }
    }
}
