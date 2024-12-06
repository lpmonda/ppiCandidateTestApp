using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ppiCandidateTestApp.Models;

namespace ppiCandidateTestApp.Data
{
    public class ppiCandidateTestAppContext : DbContext
    {
        public ppiCandidateTestAppContext (DbContextOptions<ppiCandidateTestAppContext> options)
            : base(options)
        {
        }

        public DbSet<ppiCandidateTestApp.Models.Candidate> Candidate { get; set; } = default!;
    }
}
