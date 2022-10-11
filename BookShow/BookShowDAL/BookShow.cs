using Microsoft.EntityFrameworkCore;
using System;
using BookShowEntity;

namespace BookShowDAL
{
    public class BookShowDbContext:DbContext
    {
        public BookShowDbContext(DbContextOptions<BookShowDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Theatre> theatre { get; set; }
        public DbSet<ShowTiming> showTiming { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2164; Initial Catalog = BookShow; Integrated Security=True;");
        }
    }
}
