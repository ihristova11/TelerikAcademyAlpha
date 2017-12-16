using System;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utilities;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
    public class CourseResult : ICourseResult
    {
        private const string PatternToPrint = "* {0}: Points - {1}, Grade - {2}";

        private float examPoints;
        private float coursePoints;

        public ICourse Course { get; }

        public float ExamPoints
        {
            get { return this.examPoints; }
            private set
            {
                Validator.ValidatePoints(value,Constants.MinExamPoints, Constants.MaxExamPoints, Constants.InvalidExamPoints);
                
                this.examPoints = value;
            }

        }

        public float CoursePoints
        {
            get { return this.coursePoints; }
            private set
            {
                Validator.ValidatePoints(value, Constants.MinCoursePoints, Constants.MaxCoursePoints, Constants.InvalidCoursePoints);

                this.coursePoints = value;
            }
            
        }
        public Grade Grade { get; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, this.CoursePoints, this.Grade);
        }
    }
}
