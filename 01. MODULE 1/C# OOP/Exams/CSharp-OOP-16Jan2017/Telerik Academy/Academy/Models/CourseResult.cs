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

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.ExamPoints = float.Parse(examPoints);
            this.CoursePoints = float.Parse(coursePoints);
        }

        public ICourse Course { get; set; }

        public float ExamPoints
        {
            get { return this.examPoints; }
            private set
            {
                Validator.ValidatePoints(value,Constants.MinExamPoints, Constants.MaxExamPoints, Constants.InvalidExamPoints);
                SetGrade(value);
                this.examPoints = value;
            }
        }

        public float CoursePoints
        {
            get { return this.coursePoints; }
            private set
            {
                Validator.ValidatePoints(value, Constants.MinCoursePoints, Constants.MaxCoursePoints, Constants.InvalidCoursePoints);
                SetGrade(value);
                this.coursePoints = value;
            }
            
        }
        public Grade Grade { get; set; }

        private void SetGrade(float point)
        {
            this.Grade = Grade.Failed;
            if (point >= 30 || CoursePoints >= 45) { this.Grade = Grade.Passed; };
            if (point >= 65 || CoursePoints >= 75) { this.Grade = Grade.Excellent; };

        }

        public override string ToString()
        {
            return string.Format(PatternToPrint,this.Course.Name, this.CoursePoints, this.Grade);
        }
    }
}
