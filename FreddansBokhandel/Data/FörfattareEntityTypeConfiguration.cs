using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class FörfattareEntityTypeConfiguration : IEntityTypeConfiguration<Författare>
        {
            public void Configure(EntityTypeBuilder<Författare> builder)
            {
                builder.ToTable("Författare");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                builder.Property(e => e.Efternamn).HasMaxLength(50);

                builder.Property(e => e.Födelsedatum).HasColumnType("date");

                builder.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Land)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            }
        }
    }
}
