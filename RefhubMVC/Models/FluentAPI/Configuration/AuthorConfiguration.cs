using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefhubMVC.Models.Entities;

namespace RefhubMVC.Models.FluentAPI.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b=>b.FullName).IsRequired();
            builder.Property(b => b.Slug).IsRequired().IsUnicode(false);
            
            builder.HasMany(b=>b.BookAuthors).WithOne(ba=>ba.Author).HasForeignKey(ba=>ba.AuthorId);


        }
    }
}
