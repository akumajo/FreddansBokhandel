using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class LagerSaldoEntityTypeConfiguration : IEntityTypeConfiguration<LagerSaldo>
        {
            public void Configure(EntityTypeBuilder<LagerSaldo> builder)
            {
                builder.HasKey(e => new { e.ButikId, e.Isbn });

                builder.ToTable("LagerSaldo");

                builder.Property(e => e.ButikId).HasColumnName("ButikID");

                builder.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                builder.HasOne(d => d.Butik)
                    .WithMany(p => p.LagerSaldo)
                    .HasForeignKey(d => d.ButikId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LagerSaldo_Butiker");

                builder.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.Lagersaldo)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LagerSaldo_Böcker");
            }
        }
    }
}
