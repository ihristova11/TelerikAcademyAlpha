using System;
using System.Collections;
using System.Linq;
namespace FirstBeforeLast
{
    public class Problem3
    {
        static void Main()
        {
            Student[] classOfStudents = new Student[3];
            classOfStudents[0] = new Student("Ivan", "Ivanov");
            classOfStudents[1] = new Student("Irina", "Hristova");
            classOfStudents[2] = new Student("Pesho", "Peshov");
            FindStudents(classOfStudents);
        }

        public static void FindStudents(Student[] collection)
        {
            var result =
                from student in collection
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            foreach (var student in result)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
