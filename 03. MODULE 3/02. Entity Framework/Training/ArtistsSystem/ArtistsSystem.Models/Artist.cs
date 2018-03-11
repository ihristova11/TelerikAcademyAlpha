namespace ArtistsSystem.Models
{
    public class Artist
    {
        public Artist()
        {
            this.Members = 1;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public int Members { get; set; }
    }
}
