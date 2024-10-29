using BlazorBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorBooks.Data
{
    public class BlazorBooksContext : DbContext
    {
        public BlazorBooksContext(DbContextOptions<BlazorBooksContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorBooks.Models.Book> Book { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "リーダブルコード", Author = "Dustin Boswell, Trevor Foucher", Publisher = "オライリージャパン", PublishedYear = 2012 },
                new Book { Id = 2, Title = "ハリー・ポッターと賢者の石", Author = "J.K.ローリング", Publisher = "静山社", PublishedYear = 1999 },
                new Book { Id = 3, Title = "坂の上の雲", Author = "司馬遼太郎", Publisher = "文藝春秋", PublishedYear = 1999 }
                );
    }
}
