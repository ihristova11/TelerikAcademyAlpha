using System;
using System.Collections.Generic;
using Academy.Models.Utilities;

namespace Academy.Models
{
    using Academy.Models.Contracts;

    public class Course : ICourse
    {
        private const string PatternToPrint = "* Course:\n - Name: {0}\n - Lectures per week: {1}\n - Starting date: {2}\n - Ending date: {3}\n - Onsite students: {5}\n - Online students: {6}\n - Lectures:\n{4}";
        private const string NoLecture = "  * There are no lectures in this course!";

        private string name;
        private int lecturesPerWeek;
        private DateTime endingDate;

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = DateTime.Parse(startingDate);
            this.OnsiteStudents = new List<IStudent>();
            this.OnlineStudents = new List<IStudent>();
            this.Lectures = new List<ILecture>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CorrectName(value, Constants.MinCourseNameLength, Constants.MaxCourseNameLength, Constants.InvalidCourseName);

                this.name = value;
            }
        }

        public int LecturesPerWeek { get { return this.lecturesPerWeek; }

            set
            {
                Validator.CorrectLecturePerWeek(value.ToString());

                this.lecturesPerWeek = value;
            }
        }
        public DateTime StartingDate { get; set; }

        public DateTime EndingDate
        {
            get
            {
                return this.StartingDate.AddDays(30);
            }
            set { this.endingDate = value; }
        }

        public IList<IStudent> OnsiteStudents { get; }
        public IList<IStudent> OnlineStudents { get; }
        public IList<ILecture> Lectures { get; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, this.Name, this.LecturesPerWeek, this.StartingDate, this.EndingDate,
                this.OnsiteStudents, this.OnlineStudents, this.Lectures);
        }
    }
}
