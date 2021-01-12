using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class SåldaBöckerButikEntityTypeConfiguration : IEntityTypeConfiguration<SåldaBöckerButik>
        {
            public void Configure(EntityTypeBuilder<SåldaBöckerButik> builder)
            {
                builder.HasNoKey();

                builder.ToView("AntalSåldaBöckerPerButik");

                builder.Property(e => e.AntalSåldaEx).HasColumnName("Antal sålda ex");

                builder.Property(e => e.Butik)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(e => e.TotalSumma)
                    .HasMaxLength(4000)
                    .HasColumnName("Total summa");
            }
        }
    }
}
