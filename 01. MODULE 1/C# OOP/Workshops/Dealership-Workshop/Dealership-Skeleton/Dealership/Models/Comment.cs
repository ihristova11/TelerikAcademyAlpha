﻿using System;

namespace Dealership.Models
{
    using Dealership.Contracts;

    public class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Content
        {
            get { return this.content; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Content must be between 3 and 200 characters long!");
                }
                if (value.Length < 3 || value.Length > 200)
                {
                    throw new ArgumentException("Content must be between 3 and 200 characters long!");
                }

                this.content = value;
            }
        }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"  {this.Content}  \n    User: {this.Author}";
        }
    }
}
