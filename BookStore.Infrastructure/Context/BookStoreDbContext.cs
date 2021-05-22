using System.Linq;
using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Context
{
  public class BookStoreDbContext : DbContext
  {
    public BookStoreDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      // it sets the size of the column to 150, if we forgot to define the size of any property of type string, it will be created as nvarchar(max)
      foreach (var property in modelBuilder.Model.GetEntityTypes()
          .SelectMany(e => e.GetProperties()
              .Where(p => p.ClrType == typeof(string))))
        property.SetColumnType("varchar(150)");

      modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookStoreDbContext).Assembly);

      // Disables the cascade deletion, there is already validation in the project for this scenario
      foreach (var relationship in modelBuilder.Model.GetEntityTypes()
          .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

      base.OnModelCreating(modelBuilder);
    }
  }
}