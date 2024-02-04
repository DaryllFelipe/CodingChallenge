using Coding.Challenge.Repositories.Models;
using Microsoft.EntityFrameworkCore;


namespace Coding.Challenge.Repositories;
internal class Context : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"Server=(localdb)\\MSSQLLocalDB;Database=CodingChallenge;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, CategoryId = 1, Description = "First Book", Title = "Book #1", PublishDateUtc = DateTimeOffset.UtcNow },
            new Book { Id = 2, CategoryId = 1, Description = "Second Book", Title = "Book #2", PublishDateUtc = DateTimeOffset.UtcNow },
            new Book { Id = 3, CategoryId = 2, Description = "Third Book", Title = "Book #3", PublishDateUtc = DateTimeOffset.UtcNow },
            new Book { Id = 4, CategoryId = 2, Description = "Fourth Book", Title = "Book #4", PublishDateUtc = DateTimeOffset.UtcNow },
            new Book { Id = 5, CategoryId = 3, Description = "Fifth Book", Title = "Book #5", PublishDateUtc = DateTimeOffset.UtcNow }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "First Category" },
            new Category { Id = 2, Name = "Second Category" },
            new Category { Id = 3, Name = "Third Category" }
        );
    }
}
