
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Model
{
    public class PlutoContext: DbContext
    {
        public PlutoContext(DbContextOptions<PlutoContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set;}
        public DbSet<Tag> Tags { get; set;}
        public DbSet<Author> Authors { get; set; }

    }

}
