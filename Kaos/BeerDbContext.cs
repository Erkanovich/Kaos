using Kaos.Models;
using Microsoft.EntityFrameworkCore;

namespace Kaos
{
    public class BeerDbContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BeerDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Beer>()
                .HasKey(x => x.Id);

            modelBuilder
                .Entity<Beer>()
                .Property(x => x.Id)
                .IsRequired();

            modelBuilder
                .Entity<Beer>()
                .Property(x => x.Description)
                .IsRequired(false);

            modelBuilder
                .Entity<Beer>()
                .Property(x => x.AlcoholPercentage)
                .IsRequired(false);

            modelBuilder
                .Entity<Beer>()
                .HasOne(b => b.Brand)
                .WithMany(br => br.Beers);

            modelBuilder
                .Entity<Brand>()
                .HasKey(x => x.Id);

            modelBuilder
                .Entity<Brand>()
                .Property(x => x.Id)
                .UseIdentityColumn(10,10)
                .IsRequired();

            modelBuilder
                .Entity<Brand>()
                .HasMany(br => br.Beers)
                .WithOne(b => b.Brand);
        }
    }
}
