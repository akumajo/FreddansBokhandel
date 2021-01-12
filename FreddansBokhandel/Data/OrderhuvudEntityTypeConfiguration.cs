using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class OrderhuvudEntityTypeConfiguration : IEntityTypeConfiguration<Orderhuvud>
        {
            public void Configure(EntityTypeBuilder<Orderhuvud> builder)
            {
                builder.ToTable("Orderhuvud");

                builder.Property(e => e.Id)
                    .HasMaxLength(40)
                    .HasColumnName("ID");

                builder.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                builder.Property(e => e.OrderId).HasColumnName("OrderID");

                builder.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.Orderhuvud)
                    .HasForeignKey(d => d.Isbn)
                    .HasConstraintName("FK_Orderhuvud_Böcker");

                builder.HasOne(d => d.Order)
                    .WithMany(p => p.Orderhuvud)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Orderhuvud_Ordrar");
            }
        }
    }
}
