using System;
using System.Collections.Generic;
using Academy.Models.Contracts;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private string username;

        public string Username {
            get { return this.username; }
            set
            {
                if (value.Length < 3 || value.Length > 16 || value == null || value == string.Empty)
                {
                    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                }

                this.username = value;
            }
        }

        public IList<string> Technologies { get; set; }

        public override string ToString()
        {
            string technologies = string.Join("; ", this.Technologies);
            return $"* Trainer:\n - Username: {this.Username}\n - Technologies: " + technologies;
        }
    }
}
