using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefhubMVC.Models.Entities;

namespace RefhubMVC.Models.FluentAPI.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasKey(m => m.Id);
            builder.Property(m=>m.Title).IsRequired().IsUnicode(false);
            builder.Property(m => m.Slug).IsRequired().IsUnicode(false);

            //Relation Category & Book
            
            builder.HasMany(m=>m.Books)
                .WithOne(x=>x.Category).HasForeignKey(x=>x.CategoryId);

        }
    }
}
