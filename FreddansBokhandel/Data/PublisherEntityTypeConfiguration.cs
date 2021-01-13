using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class PublisherEntityTypeConfiguration : IEntityTypeConfiguration<Publisher>
        {
            public void Configure(EntityTypeBuilder<Publisher> builder)
            {
                builder.ToTable("Förlag");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                builder.Property(e => e.Address).HasMaxLength(100);

                builder.Property(e => e.Country).HasMaxLength(20);

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ZipCode).HasMaxLength(20);

                builder.Property(e => e.PostalAddress).HasMaxLength(50);
            }
        }
    }
}
