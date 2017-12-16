using Academy.Models.Contracts;
using Academy.Models.Utilities;

namespace Academy.Models
{
    public class PresentationResource : ILectureResource
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.CorrectName(value, Constants.MinResourceName, Constants.MaxResourceName, Constants.InvalidResourceName);

                this.name = value;
            }
        }
        public string Url { get; set; }
    }
}
