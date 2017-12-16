using System;
using System.Collections.Generic;
using System.Threading;
using Academy.Models.Contracts;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private string name;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.Parse(date);
            this.Trainer = trainer;
            this.Resources = new List<ILectureResource>();
        }

        public string Name {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5 || value.Length > 30)
                {
                    throw new ArgumentException("Lecture's name should be between 5 and 30 symbols long!");
                }

                this.name = value;
            }
        }
        public DateTime Date { get; set; }
        public ITrainer Trainer { get; set; }
        public IList<ILectureResource> Resources { get; }

        public override string ToString()
        {
            return $"* Lecture:\n - Name: {this.Name}\n - Date: {this.Date}\n - Trainer username: {this.Trainer.Username}\n - Resourses: ";
        }
    }
}
