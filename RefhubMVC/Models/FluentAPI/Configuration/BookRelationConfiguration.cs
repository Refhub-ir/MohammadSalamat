using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefhubMVC.Models.Entities;

namespace RefhubMVC.Models.FluentAPI.Configuration
{
    public class BookRelationConfiguration:IEntityTypeConfiguration<BookRelation>
    {
        public void Configure(EntityTypeBuilder<BookRelation> builder)
        {

            builder.HasKey(x => new { x.RelatedBookId, x.BookId });


            builder.HasOne(x => x.Book).WithMany(ba => ba.RelatedTo).HasForeignKey(x => x.BookId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.RelatedBook).WithMany(ba => ba.RelatedFrom).HasForeignKey(x => x.RelatedBookId).OnDelete(DeleteBehavior.NoAction);


        }
    }
}
