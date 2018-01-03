using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public class PresentationResource : Resource, ILectureResource
    {
        public PresentationResource(string name, string url) : base(name, url)
        {
            base.Type = "Presentation";
        }
    }
}
