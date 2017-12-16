using Academy.Models.Contracts;

namespace Academy.Models
{
    public class DemoResource : Resource, ILectureResource
    {
        public DemoResource(string type, string name, string url) : base(type, name, url)
        {
        }
    }
}
