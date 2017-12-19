using System;

namespace WarMachines.Machines
{
    public static class Validator
    {
        public static void ValidateName(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 3 || input.Length > 15)
            {
                throw new ArgumentException("Name must be between...");
            }
        }
    }
}
