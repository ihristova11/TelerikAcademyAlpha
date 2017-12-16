using Academy.Models.Contracts;

namespace Academy.Models
{
    public class HomeworkResource : IResource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
