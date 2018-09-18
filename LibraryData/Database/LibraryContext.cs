using LibraryData.Models;

using Microsoft.EntityFrameworkCore;

namespace LibraryData.Database {

    public class LibraryContext : DbContext {

        public LibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Patron> Patrons { get; set; }

    }

}