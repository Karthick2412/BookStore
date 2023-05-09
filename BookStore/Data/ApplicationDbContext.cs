using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
            
        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, BookName = "Book_1", AuthorName = "Author_1" },
                new Book { Id = 2, BookName = "Book_2", AuthorName = "Author_2" },
                new Book { Id = 3, BookName = "Book_3", AuthorName = "Author_3" }
                );
        }
    }
}
