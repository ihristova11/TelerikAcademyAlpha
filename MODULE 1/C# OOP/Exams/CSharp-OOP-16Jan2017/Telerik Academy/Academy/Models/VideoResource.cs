using System;
using System.Runtime.CompilerServices;
using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public class VideoResource : Resource, ILectureResource
    {
        private const string PatternToPrint = "\n{0}\n     - Uploaded on: {1}";

        public VideoResource(string name, string url, DateTime uplodedOn) : base(name, url)
        {
            base.Type = "Video";
            UploadedOn = uplodedOn;
        }

        public DateTime UploadedOn { get; private set; }

        public override string ToString()
        {
            return string.Format(PatternToPrint, base.ToString(), UploadedOn);
        }
    }
}
