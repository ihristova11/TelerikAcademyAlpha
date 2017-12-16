using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public abstract class Resource : ILectureResource
    {
        private const string PatternToPrint = "\n* Resource: \n - Name: {0}\n - Url: {1}\n - Type: {2}";

        private string name;
        private string url;

        public Resource(string type, string name, string url)
        {
            this.Type = type;
            this.Name = name;
            this.Url = url;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CorrectName(value, Constants.MinResourceName, Constants.MaxResourceName, Constants.InvalidResourceName);

                this.name = value;
            }
        }
        public string Url
        {
            get { return this.url; }
            set
            {
                Validator.CorrectName(value, Constants.MinUrl, Constants.MaxUrl, Constants.InvalidResourceURL);

                this.url = value;
            }
        }

        public string Type { get; protected set; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, this.Name, this.Url, this.Type);
        }
    }
}
