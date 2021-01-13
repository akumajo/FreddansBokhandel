using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class OrderDetailEntityTypeConfiguration : IEntityTypeConfiguration<OrderDetail>
        {
            public void Configure(EntityTypeBuilder<OrderDetail> builder)
            {
                builder.ToTable("Orderdetaljer");

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
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Isbn)
                    .HasConstraintName("FK_Orderdetaljer_Böcker");

                builder.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Orderdetaljer_Ordrar");
            }
        }
    }
}
