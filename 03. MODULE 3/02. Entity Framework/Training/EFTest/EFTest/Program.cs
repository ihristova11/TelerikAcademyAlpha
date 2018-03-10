using System;
using System.Linq;
using EFTest.Data;

namespace EFTest
{
    public class Program
    {
        static void Main()
        {
            using (var db = new TelerikAcademyEntities())
            {
                var town = new Town
                {
                    Name = "Lovech"
                };

                var address = new Address
                {
                    AddressText = "tsentralna 150",
                    Town = town
                };

                db.Towns.Add(town);
                db.Addresses.Add(address);

                db.SaveChanges();
            }
        }
    }
}
