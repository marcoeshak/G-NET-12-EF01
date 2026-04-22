using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF01
{
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.;Database=BookStoreDb;Trusted_Connection=True;");
        }
    }
}
