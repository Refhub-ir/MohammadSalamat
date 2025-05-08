using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefhubMVC.Models.Entities;

namespace RefhubMVC.Models.FluentAPI.Configuration
{
    public class BookConfiguration:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.Slug)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(x => x.PageCount)
                  .IsRequired();

            builder.Property(x => x.FilePath)
                  .IsRequired()
                  .IsUnicode (false);


             // Configure Relation 
            // Ralation Book & Category
            builder.HasOne(x=>x.Category)
                .WithMany(y=>y.Books)
                .HasForeignKey(x=>x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Ralation Book & BookKeyword
            builder.HasMany(x => x.BookKeywords)
                 .WithOne(z => z.Book)
                 .HasForeignKey(z => z.BookId);

            // Ralation Book & BookAuthor

            builder.HasMany(x => x.BookAuthors)
                .WithOne(t => t.Book)
                .HasForeignKey(t => t.BookId);

            // Ralation Book & Related to
            builder.HasMany(x => x.RelatedTo)
                .WithOne(ta => ta.Book)
                .HasForeignKey(ta => ta.BookId).OnDelete(DeleteBehavior.NoAction);


            // Ralation Book & From to
            builder.HasMany(x => x.RelatedFrom)
                .WithOne(ba => ba.RelatedBook)
                .HasForeignKey(ba => ba.RelatedBookId);




        }
    }
}
