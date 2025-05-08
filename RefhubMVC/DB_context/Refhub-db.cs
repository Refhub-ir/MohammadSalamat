using Microsoft.EntityFrameworkCore;
using RefhubMVC.Models.Entities;
using RefhubMVC.Models.FluentAPI.Configuration;

namespace RefhubMVC.DB_context
{
    public class Refhub_db : DbContext
    {

            public DbSet<Category> Categories { get; set; }
            public DbSet<Author> Authors { get; set; }
            public DbSet<Book> Books { get; set; }
            public DbSet<Keyword> Keywords { get; set; }
            public DbSet<BookAuthor> BookAuthors { get; set; }
            public DbSet<BookKeyword> BookKeywords { get; set; }
            public DbSet<BookRelation> BookRelations { get; set; }

            public Refhub_db(DbContextOptions<Refhub_db> options) : base(options) { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookRelationConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new KeywordConfiguration());
            modelBuilder.ApplyConfiguration(new BookKeywordConfiguration());
            base.OnModelCreating(modelBuilder);
            }
    }
}
