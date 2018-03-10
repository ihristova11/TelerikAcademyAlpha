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
                var project = db.Projects
                    .FirstOrDefault(pr => pr.ProjectID == 1);
                Console.WriteLine(project.Name);
            }
        }
    }
}
