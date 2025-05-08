using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefhubMVC.Models.Entities;
namespace RefhubMVC.Models.FluentAPI.Configuration
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(x =>new { x.AuthorId,x.BookId});


            builder.HasOne(x=>x.Book).WithMany(ba=>ba.BookAuthors).HasForeignKey(x=>x.BookId);
            builder.HasOne(x => x.Author).WithMany(ba => ba.BookAuthors).HasForeignKey(x => x.AuthorId);

        }
    }
}
