using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public class PresentationResource : Resource, ILectureResource
    {
        public PresentationResource(string type, string name, string url) : base(type, name, url)
        {
            this.Type = type;
        }
    }
}
