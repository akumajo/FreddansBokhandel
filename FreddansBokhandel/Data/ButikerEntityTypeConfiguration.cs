using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class ButikerEntityTypeConfiguration : IEntityTypeConfiguration<Butiker>
        {
            public void Configure(EntityTypeBuilder<Butiker> builder)
            {
                builder.ToTable("Butiker");

                builder.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                builder.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(e => e.Land).HasMaxLength(20);

                builder.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Postadress).HasMaxLength(50);

                builder.Property(e => e.Postnr).HasMaxLength(20);
            }
        }
    }
}
