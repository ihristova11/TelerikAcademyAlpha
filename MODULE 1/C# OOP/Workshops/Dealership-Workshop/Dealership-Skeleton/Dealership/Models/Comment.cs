using Dealership.Contracts;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        public Comment(string content)
        {
        }

        public string Content { get; }

        public string Author { get; set; }
    }
}
