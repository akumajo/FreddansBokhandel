using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class FörlagEntityTypeConfiguration : IEntityTypeConfiguration<Förlag>
        {
            public void Configure(EntityTypeBuilder<Förlag> builder)
            {
                builder.ToTable("Förlag");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                builder.Property(e => e.Adress).HasMaxLength(100);

                builder.Property(e => e.Land).HasMaxLength(20);

                builder.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Postnummer).HasMaxLength(20);

                builder.Property(e => e.Postort).HasMaxLength(50);
            }
        }
    }
}
