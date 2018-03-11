using System;

namespace ArtistsSystem.Models
{
    public class Album
    {
        public Album()
        {
            this.Id = Guid.NewGuid();
        }

        public string Title { get; set; }

        public Guid Id { get; set; }

        public DateTime? ReleasedOn { get; set; }
    }
}
