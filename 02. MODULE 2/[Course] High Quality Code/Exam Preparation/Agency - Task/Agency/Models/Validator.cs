using System;

namespace Agency.Models
{
    public static class Validator
    {
        public static void ValidateInetegerValues(int input, int min, int max, string msg)
        {
            if(input < min || input > max)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidatePrice(decimal input, decimal min, decimal max, string msg)
        {
            if (input < min || input > max)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidateLength(string input, int min, int max, string msg)
        {
            if (string.IsNullOrEmpty(input) || input.Length < min || input.Length > max)
            {
                throw new ArgumentException(msg);
            }
        }
    }
}
