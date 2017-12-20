using System.Text;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("    ----------");
            sb.AppendLine($"    {this.Content}");
            sb.AppendLine($"      User: {this.Author}");
            sb.AppendLine("    ----------");

            return sb.ToString();
        }
    }
}
