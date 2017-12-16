using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public class HomeworkResource : Resource, ILectureResource
    {
        public HomeworkResource(string type, string name, string url) : base(type, name, url)
        {
        }
    }
}