using Academy.Models.Contracts;

namespace Academy.Models
{
    public class DemoResource : Resource, ILectureResource
    {
        public DemoResource(string name, string url) : base(name, url)
        {
            base.Type = "Demo";
        }
    }
}
