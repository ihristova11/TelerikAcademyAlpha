using Dealership.Contracts;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        private readonly string content;

        public Comment(string content)
        {
            //validation
            this.content = content;
        }

        public string Content { get { return this.content; } }

        public string Author { get; set; }
    }
}
