using System;
using System.Runtime.CompilerServices;
using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public class VideoResource : Resource, ILectureResource
    {
        private const string PatternToPrint = "\n* Resource: \n - Name: {0}\n - Url: {1}\n - Type: {2} - Update date: {3}";

        public VideoResource(string type, string name, string url) : base(type, name, url)
        {
        }

        public DateTime UpdatedOn { get; set; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, this.Name, this.Url, this.Type, this.UpdatedOn);
        }
    }
}
