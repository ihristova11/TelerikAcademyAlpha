using System.Collections.Generic;

namespace ArtistsSystem.Models
{
    public class Artist
    {
        private ICollection<Album> albums;

        public Artist()
        {
            this.Members = 1;
            this.albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public GenderType Gender { get; set; }

        public int Members { get; set; }

        public virtual ICollection<Album> Albums
        {
            get { return this.albums; }
            set { this.albums = value; }
        }
    }
}
