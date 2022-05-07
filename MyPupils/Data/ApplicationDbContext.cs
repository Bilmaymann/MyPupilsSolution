using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyPupils.Models;

namespace MyPupils.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //declaing tables
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<PupilStatus> PupilStatuss{ get; set; }
        public DbSet<Tolovlar> Tolovlar { get; set; }
    }
}