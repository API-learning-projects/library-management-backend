using Microsoft.EntityFrameworkCore;
using LibraryManagement.Data.Models;

namespace LibraryManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<GenreModel> Genres { get; set; }
        
        // public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        // {
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=library;UserId=admin;Password=admin;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}