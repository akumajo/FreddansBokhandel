using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class AnställdaEntityTypeConfiguration : IEntityTypeConfiguration<Anställda>
        {
            public void Configure(EntityTypeBuilder<Anställda> builder)
            {
                builder.Property(e => e.Id)
                   .ValueGeneratedNever()
                   .HasColumnName("ID");

                builder.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.Anställningsdatum).HasColumnType("date");

                builder.Property(e => e.Efternamn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.Email).HasMaxLength(100);

                builder.Property(e => e.Födelsedatum).HasColumnType("date");

                builder.Property(e => e.Förnamn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.Postnummer)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.Postort)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Roll)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.Telefon)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.HasOne(d => d.Butiker)
                    .WithMany(p => p.Anställda)
                    .HasForeignKey(d => d.Butik)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Anställda_Butiker");
            }

        }
    }
}
