using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
        {
            public void Configure(EntityTypeBuilder<Order> builder)
            {
                builder.ToTable("Ordrar");

                builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.EmployeeID).HasColumnName("AnställningsID");

                builder.Property(e => e.OrderDate).HasColumnType("date");

                builder.Property(e => e.StoreID).HasColumnName("ButikID");

                builder.Property(e => e.RecipientAddress)
                    .HasMaxLength(50)
                    .HasColumnName("Mottagare_Adress");

                builder.Property(e => e.RecipientLastName)
                    .HasMaxLength(50)
                    .HasColumnName("Mottagare_Efternamn");

                builder.Property(e => e.RecipientFirstName)
                    .HasMaxLength(50)
                    .HasColumnName("Mottagare_Förnamn");

                builder.Property(e => e.RecipientCountry)
                    .HasMaxLength(20)
                    .HasColumnName("Mottagare_Land");

                builder.Property(e => e.RecipientZipCode)
                    .HasMaxLength(20)
                    .HasColumnName("Mottagare_Postnummer");

                builder.Property(e => e.RecipientPostalAddress)
                    .HasMaxLength(50)
                    .HasColumnName("Mottagare_Postort");

                builder.Property(e => e.SentDate)
                    .HasColumnType("date")
                    .HasColumnName("Skickat_Datum");

                builder.HasOne(d => d.EmployeeIDs)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ordrar_Anställda");

                builder.HasOne(d => d.Stores)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ordrar_Butiker");
            }
        }
    }
}
