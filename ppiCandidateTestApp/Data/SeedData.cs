using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using ppiCandidateTestApp.Models;

namespace ppiCandidateTestApp.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ppiCandidateTestAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ppiCandidateTestAppContext>>());

            if (context == null || context.Candidate == null)
            {
                throw new NullReferenceException(
                    "Null BlazorWebAppMoviesContext or Movie DbSet");
            }

            if (context.Candidate.Any())
            {
                return;
            }

            context.Candidate.AddRange(
                new Candidate
                {
                    Firstname = "Matt",
                    Lastname =  "Romber",
                    Phone = "111-111-1111",
                    zipcode = 45376,
                    email = "test1email@gmail.com",
                },
                new Candidate
                {
                    Firstname = "Jim",
                    Lastname = "Jorden",
                    Phone = "222-222-2222",
                    zipcode = 77045,
                    email = "test2email@gmail.com",
                },
                new Candidate
                {
                    Firstname = "Casey",
                    Lastname = "Convoy",
                    Phone = "333-333-3333",
                    zipcode = 77054,
                    email = "test3email@gmail.com",
                },
                new Candidate
                {
                    Firstname = "Nick",
                    Lastname = "Nathe",
                    Phone = "444-444-4444",
                    zipcode = 77042,
                    email = "test4email@gmail.com",
                },
                new Candidate
                {
                    Firstname = "Liya",
                    Lastname = "Lay",
                    Phone = "666-666-6666",
                    zipcode = 77077,
                    email = "test6email@gmail.com",
                },
                 new Candidate
                 {
                     Firstname = "Maya",
                     Lastname = "Marron",
                     Phone = "777-777-7777",
                     zipcode = 77022,
                     email = "test7email@gmail.com",
                 },
                new Candidate
                {
                    Firstname = "Mary",
                    Lastname = "Moy",
                    Phone = "555-555-5555",
                    zipcode = 77055,
                    email = "test5email@gmail.com",
                });

            context.SaveChanges();
        }
    }
}
