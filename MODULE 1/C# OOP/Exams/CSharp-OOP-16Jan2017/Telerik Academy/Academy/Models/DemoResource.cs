using Academy.Models.Contracts;

namespace Academy.Models
{
    public class DemoResource : IResource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
