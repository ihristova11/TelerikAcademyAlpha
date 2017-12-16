using System;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
    public class CourseResult : ICourseResult
    {
        private float examPoints;
        public ICourse Course { get; }

        public float ExamPoints
        {
            get { return this.examPoints; }
            private set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentException("Course result's exam points should be between 0 and 1000!");
                }

                this.examPoints = value;
            }

        }
        public float CoursePoints { get; }
        public Grade Grade { get; }
    }
}
