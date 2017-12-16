using System;

namespace Academy.Models.Utilities
{
    public class Validator
    {
        public static void CorrectName(string name, int min, int max, string message)
        {
            if (string.IsNullOrEmpty(name) || name.Length < min || name.Length > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static int CorrectLecturePerWeek(string lecturePerWeek)
        {
            int res;
            try
            {
                res = int.Parse(lecturePerWeek);
            }
            catch (Exception e)
            {
                throw new ArgumentException(Constants.InvalidLecturesPerWeek);
            };

            if (res < Constants.MinLecturesPerWeek || res > Constants.MaxLecturesPerWeek)
            {
                throw new ArgumentException(Constants.InvalidLecturesPerWeek);
            }

            return res;
        }

        public static object ParsEnum(Type type, string text)
        {
            object result = null;

            try
            {
                result = Enum.Parse(type, text);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException(Constants.NotValidTrack); //0 always mean - unknown type
            }

            return result;
        }
    }
}
