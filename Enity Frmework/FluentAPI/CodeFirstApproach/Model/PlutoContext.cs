
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Model
{
    public class PlutoContext: DbContext
    {
        public PlutoContext(DbContextOptions<PlutoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //modelBuilder.Entity<Course>()
            //            .Property(c => c.Name)
            //            .IsRequired()
            //            .HasMaxLength(255);

            //modelBuilder.Entity<Course>()
            //            .Property(c => c.Description)
            //            .IsRequired()
            //            .HasMaxLength(2000);

            //// one to many
            //modelBuilder.Entity<Course>()
            //            .HasOne(c => c.Author) //each course has one author
            //            .WithMany(a => a.Courses) // but one author may have many courses
            //            .HasForeignKey(fk => fk.AuthorId); // Course Table e konta foreign key hobe

            ////congifure many to many
            //modelBuilder.Entity<Course>() // it doesnt matter we choose course or tag 
            //            .HasMany(c => c.Tags) // a course have many tags
            //            .WithMany(t => t.Courses); // each tag has many courses


            
        }

        public DbSet<Course> Courses { get; set;}
        public DbSet<Tag> Tags { get; set;}
        public DbSet<Author> Authors { get; set; }

    }

}
