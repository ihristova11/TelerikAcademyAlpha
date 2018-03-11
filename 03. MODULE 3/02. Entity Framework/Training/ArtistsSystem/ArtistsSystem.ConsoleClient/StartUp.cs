using System;
using System.Linq;
using ArtistsSystem.Data;
using ArtistsSystem.Models;

namespace ArtistsSystem.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            var db = new ArtistsDbContext();

            var artist = new Artist
            {
                Name = "Pesho",
                Gender = GenderType.Female
            };

            db.SaveChanges();

            Console.WriteLine(db.Artists.Count());
        }
    }
}
