using BookStore.Domain;
using BookStore.Mapper;
using System.Data.Entity;

namespace BookStore.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ConnectionString")
        {

        }

        public DbSet<Author> Authores { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}