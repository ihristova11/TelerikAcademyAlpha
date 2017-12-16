using System;
using System.Collections.Generic;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private string username;

        public Student(string username, string track)
        {
            this.Username = username;
            this.Track = (Track)Enum.Parse(typeof(Track), track);
            this.CourseResults = new List<ICourseResult>();
        }

        public string Username {
            get { return this.username; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }
        }
        }
        public Track Track { get; set; }

        public IList<ICourseResult> CourseResults { get; set; }

        public override string ToString()
        {
            return $"* Student:\n - Username: {this.Username}\n - Track: {this.Track}\n - Course results: {this.CourseResults}";
        }
    }
}
