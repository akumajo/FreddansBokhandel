using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class BöckerFörfattareEntityTypeConfiguration : IEntityTypeConfiguration<BöckerFörfattare>
        {
            public void Configure(EntityTypeBuilder<BöckerFörfattare> builder)
            {
                builder.HasKey(e => new { e.Isbn, e.FörfattarId });

                builder.ToTable("BöckerFörfattare");

                builder.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                builder.Property(e => e.FörfattarId).HasColumnName("FörfattarID");

                builder.HasOne(d => d.Författare)
                    .WithMany(p => p.BöckerFörfattare)
                    .HasForeignKey(d => d.FörfattarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BöckerFörfattare_Författare");

                builder.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.BöckerFörfattare)
                    .HasForeignKey(d => d.Isbn)
                    .HasConstraintName("FK_BöckerFörfattare_Böcker");
            }
        }
    }
}
