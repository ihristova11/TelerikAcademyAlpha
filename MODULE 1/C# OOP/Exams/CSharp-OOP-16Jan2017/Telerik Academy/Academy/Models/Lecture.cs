using System;
using System.Collections.Generic;
using System.Threading;
using Academy.Models.Contracts;
using Academy.Models.Utilities;
using Microsoft.SqlServer.Server;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private const string PatternToPrint = "  * Lecture:\n   - Name: {0}\n   - Date: {1}\n   - Trainer username: {2}\n   - Resources:{3}";
        private const string NoResource = "\n    * There are no resources in this lecture.";

        private string name;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Trainer = trainer;
            this.Resources = new List<ILectureResource>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CorrectName(value, Constants.MinCourseNameLength, Constants.MaxCourseNameLength, Constants.InvalidLectureName);

                this.name = value;
            }
        }
        public DateTime Date { get; set; }
        public ITrainer Trainer { get; set; }
        public IList<ILectureResource> Resources { get; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, this.Name, this.Date, this.Trainer.Username, this.Resources);
        }
    }
}
