using Academy.Models.Contracts;

namespace Academy.Models
{
    public class PresentationResource : IResource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
