using Microsoft.EntityFrameworkCore;
using MoviesGenreWeb.Models;

namespace MoviesGenreWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
