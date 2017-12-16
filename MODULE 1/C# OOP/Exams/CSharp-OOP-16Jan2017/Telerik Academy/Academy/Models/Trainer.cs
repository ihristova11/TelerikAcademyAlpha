using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using Academy.Models.Contracts;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private string username;

        public Trainer(string username, string technologies)
        {
            this.Username = username;
            this.Technologies = technologies.Split(',').Select(x => x.Trim()).ToList();
        }

        public string Username
        {
            get { return this.username; }
            set
            {
                //if (value.Length < 3 || value.Length > 16)
                //{
                //    throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
                //}

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
