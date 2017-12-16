using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public class Trainer : ITrainer
    {
        private string username;

        private const string PatternToPrint = "* Trainer:\n - Username: {0}\n - Technologies: {1}";

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
                Validator.CorrectName(value, Constants.MinUserNameLength , Constants.MaxUserNameLength, Constants.UserCorrectName);
                this.username = value;
            }
        }

        public IList<string> Technologies { get; set; }

        public override string ToString()
        {
            var techno = string.Join("; ", this.Technologies);

            return string.Format(PatternToPrint, Username, techno);
        }
    }
}
