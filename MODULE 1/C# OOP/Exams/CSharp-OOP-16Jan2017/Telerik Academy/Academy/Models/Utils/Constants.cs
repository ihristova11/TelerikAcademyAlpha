namespace Academy.Models.Utilities
{
    public class Constants
    {
        public const string InvalidCourseName = "The name of the course must be between 3 and 45 symbols!";
        public const string InvalidLecturesPerWeek = "The number of lectures per week must be between 1 and 7!";
        public const string InvalidUserName = "User's username should be between 3 and 16 symbols long!";
        public const string NotValidTrack = "The provided track is not valid!";
        public const string ExamPointFalseMessage = "Course result's exam points should be between 0 and 1000!";
        public const string InvalidLectureName = "Lecture's name should be between 5 and 30 symbols long!";
        public const string InvalidResourceName = "Resource name should be between 3 and 15 symbols long!";
        public const string InvalidResourceURL = "Resource url should be between 5 and 150 symbols long!";
        public const string InvalidExamPoints = "Course result's exam points should be between 0 and 1000!";
        public const string InvalidCoursePoints = "Course result's course points should be between 0 and 125!";

        public const int MinUserNameLength = 3;
        public const int MaxUserNameLength = 16;
        public const int MinCourseNameLength = 3;
        public const int MaxCourseNameLength = 45;
        public const int MinLecturesPerWeek = 1;
        public const int MaxLecturesPerWeek = 7;
        public const int MinExamPoints = 0;
        public const int MaxExamPoints = 1000;
        public const int MinCoursePoints = 0;
        public const int MaxCoursePoints = 125;
        public const int MinResourceName = 3;
        public const int MaxResourceName = 15;
        public const int MinUrl = 5;
        public const int MaxUrl = 150;

        public const int MinExamPassedPoints = 30;
        public const int MinCoursePassedPoints = 45;
        public const int MinExamExcellentPoints = 65;
        public const int MinCourseExcellentPoints = 75;
    }
}
