using System;

namespace ArtistsSystem.Models
{
    public class Song
    {
        public int Id { get; set; }

        public int Duration { get; set; }

        public Guid AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
