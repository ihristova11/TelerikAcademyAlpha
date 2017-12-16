using System;
using System.Collections.Generic;

namespace Academy.Models
{
    using Academy.Models.Contracts;

    public class Course : ICourse
    {
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
                if (value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentException("The name of the course must be between 3 and 45 symbols!");
                }

                this.name = value;
            }
        }

        public int LecturesPerWeek { get { return this.lecturesPerWeek; }

            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentException("The number of lectures per week must be between 1 and 7!");
                }

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
            string msg = "  * There are no lectures in this course!";
            return $"* Course\n - Name: {this.Name}\n - Lectures per week: {this.LecturesPerWeek}\n - Starting date: {this.StartingDate}\n - Ending date: {this.EndingDate}\n - Lectures: " + msg;
        }
    }
}
