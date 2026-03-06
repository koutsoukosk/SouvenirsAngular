using Microsoft.EntityFrameworkCore;
using SouvenirsWithAngular.Models.Domain;

namespace SouvenirsWithAngular.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Souvenir> Souvenirs => Set<Souvenir>();
        public DbSet<Friend> Friends => Set<Friend>();
    }
}
