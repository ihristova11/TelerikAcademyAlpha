using System.Collections.Generic;
using StudentGroupsExtensions;

namespace StudentGroups
{
    public class Student
    {
        public Student(string firstName, string lastName, uint fn, string tel, string email, IList<int> marks, uint groupNumber, string groupDepartment)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = new List<int>(marks);
            this.Group = new Group(groupNumber, groupDepartment);
        }
        public Group Group { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        //public uint GroupNumber { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }  
    }
}
