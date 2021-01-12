using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class OrdrarEntityTypeConfiguration : IEntityTypeConfiguration<Ordrar>
        {
            public void Configure(EntityTypeBuilder<Ordrar> builder)
            {
                builder.ToTable("Ordrar");

                builder.Property(e => e.Id).HasColumnName("ID");

                builder.Property(e => e.AnställningsId).HasColumnName("AnställningsID");

                builder.Property(e => e.Beställningsdatum).HasColumnType("date");

                builder.Property(e => e.ButikId).HasColumnName("ButikID");

                builder.Property(e => e.MottagareAdress)
                    .HasMaxLength(50)
                    .HasColumnName("Mottagare_Adress");

                builder.Property(e => e.MottagareEfternamn)
                    .HasMaxLength(50)
                    .HasColumnName("Mottagare_Efternamn");

                builder.Property(e => e.MottagareFörnamn)
                    .HasMaxLength(50)
                    .HasColumnName("Mottagare_Förnamn");

                builder.Property(e => e.MottagareLand)
                    .HasMaxLength(20)
                    .HasColumnName("Mottagare_Land");

                builder.Property(e => e.MottagarePostnummer)
                    .HasMaxLength(20)
                    .HasColumnName("Mottagare_Postnummer");

                builder.Property(e => e.MottagarePostort)
                    .HasMaxLength(50)
                    .HasColumnName("Mottagare_Postort");

                builder.Property(e => e.SkickatDatum)
                    .HasColumnType("date")
                    .HasColumnName("Skickat_Datum");

                builder.HasOne(d => d.AnställningsID)
                    .WithMany(p => p.Ordrar)
                    .HasForeignKey(d => d.AnställningsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ordrar_Anställda");

                builder.HasOne(d => d.Butik)
                    .WithMany(p => p.Ordrar)
                    .HasForeignKey(d => d.ButikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ordrar_Butiker");
            }
        }
    }
}
