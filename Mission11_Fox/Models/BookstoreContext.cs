﻿using Microsoft.EntityFrameworkCore;

namespace Mission11_Fox.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext (DbContextOptions<BookstoreContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
