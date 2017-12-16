using System;
using System.Collections.Generic;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utilities;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
    public class Student : IStudent
    {
        private string username;

        private const string PatternToPrint = "* Student:\n - Username: {0}\n - Track: {1}\n - Course results:\n  {2}";
        private const string NoCourseResult = "* User has no course results!";

        public Student(string username, string track)
        {
            this.Username = username;
            this.Track = (Track)Enum.Parse(typeof(Track), track);
            this.CourseResults = new List<ICourseResult>();
        }

        public string Username
        {
            get { return this.username; }
            set
            {
                Validator.CorrectName(value, Constants.MinUserNameLength, Constants.MaxUserNameLength, Constants.InvalidUserName);

                this.username = value;
            }
        }
        public Track Track { get; set; }

        public IList<ICourseResult> CourseResults { get; set; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, this.Username, this.CourseResults);
        }
    }
}
