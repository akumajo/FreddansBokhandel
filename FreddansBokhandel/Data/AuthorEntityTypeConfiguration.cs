using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
        {
            public void Configure(EntityTypeBuilder<Author> builder)
            {
                builder.ToTable("Författare");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                builder.Property(e => e.LastName).HasMaxLength(50);

                builder.Property(e => e.DateOfBirth).HasColumnType("date");

                builder.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            }
        }
    }
}
