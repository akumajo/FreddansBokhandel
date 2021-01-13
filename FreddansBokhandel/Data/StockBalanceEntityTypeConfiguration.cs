using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class StockBalanceEntityTypeConfiguration : IEntityTypeConfiguration<StockBalance>
        {
            public void Configure(EntityTypeBuilder<StockBalance> builder)
            {
                builder.HasKey(e => new { e.StoreID, e.Isbn });

                builder.ToTable("LagerSaldo");

                builder.Property(e => e.StoreID).HasColumnName("ButikID");

                builder.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                builder.HasOne(d => d.Store)
                    .WithMany(p => p.StockBalance)
                    .HasForeignKey(d => d.StoreID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LagerSaldo_Butiker");

                builder.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.StockBalance)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LagerSaldo_Böcker");
            }
        }
    }
}
