using System.Data.Entity;
using ArtistsSystem.Models;

namespace ArtistsSystem.Data
{
    public class ArtistsDbContext : DbContext
    {
        public virtual IDbSet<Album> Albums { get; set; }

        public virtual IDbSet<Song> Songs { get; set; }

        public virtual IDbSet<Artist> Artists { get; set; }

        public virtual IDbSet<Image> Images { get; set; }
    }
}
