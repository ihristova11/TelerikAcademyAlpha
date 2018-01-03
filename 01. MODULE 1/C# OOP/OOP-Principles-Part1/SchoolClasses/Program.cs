namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Irina"));
            students.Add(new Student("Gosho"));
            students.Add(new Student("Ivan"));
            students.Add(new Student("Mariika"));
            students.Add(new Student("Pesho"));

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
