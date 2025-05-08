using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefhubMVC.Models.Entities;

namespace RefhubMVC.Models.FluentAPI.Configuration
{
    public class BookKeywordConfiguration : IEntityTypeConfiguration<BookKeyword>
    {
        public void Configure(EntityTypeBuilder<BookKeyword> builder)
        {

            builder.HasKey(x => new { x.KeywordId, x.BookId });


            builder.HasOne(x => x.Book).WithMany(ba => ba.BookKeywords).HasForeignKey(x => x.BookId);
            builder.HasOne(x => x.Keyword).WithMany(ba => ba.BookKeywords).HasForeignKey(x => x.KeywordId);


        }
    }
}
