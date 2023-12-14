using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookMania.Models;

namespace BookMania.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BookMania.Models.Book> Book { get; set; } = default!;
        public DbSet<BookMania.Models.Inquiry> Inquiry { get; set; } = default!;
    }
}
