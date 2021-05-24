using BookStore.Domain.Interfaces;
using BookStore.Domain.Models;
using BookStore.Infrastructure.Context;

namespace BookStore.Infrastructure.Repositories
{
  // Inherits from Repository<Category> and implements ICategoryRepository
  public class CategoryRepository : Repository<Category>, ICategoryRepository
  {
    public CategoryRepository(BookStoreDbContext context) : base(context) { }
  }
}