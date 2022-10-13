using Catalog.DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace Catalog.DataAccessLayer
{
    public class CatalogContext : DbContext
    {

        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}