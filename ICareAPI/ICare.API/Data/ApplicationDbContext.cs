using ICare.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ICare.API.Data;

using Microsoft.EntityFrameworkCore;
using ICare.API.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "Alice",
                LastName = "Smith",
                Email = "alice@example.com",
                DateOfBirth = new DateTime(1990, 5, 12)
            },
            new User
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Johnson",
                Email = "bob@example.com",
                DateOfBirth = new DateTime(1988, 10, 1)
            }
        );
    }
}
