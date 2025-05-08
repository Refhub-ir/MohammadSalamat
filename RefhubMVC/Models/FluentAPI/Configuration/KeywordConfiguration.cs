using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefhubMVC.Models.Entities;

namespace RefhubMVC.Models.FluentAPI.Configuration
{
    public class KeywordConfiguration : IEntityTypeConfiguration<Keyword>

    {
        public void Configure(EntityTypeBuilder<Keyword> builder)
        {

            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Word).IsRequired().IsUnicode(false);

            // Relation Keyword & BookKeyword
            builder.HasMany(x => x.BookKeywords)
                .WithOne(y => y.Keyword).HasForeignKey(y => y.KeywordId);
        }
    }
}
