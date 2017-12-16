using System;
using System.Collections.Generic;
using Academy.Models.Contracts;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private string username;

        public string Username {
            get { return this.username; }
            set
            {
                if (value == string.Empty || value == null || value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }
        }
        }
        public Track Track { get; set; }
        public IList<ICourseResult> CourseResults { get; set; }
    }
}
