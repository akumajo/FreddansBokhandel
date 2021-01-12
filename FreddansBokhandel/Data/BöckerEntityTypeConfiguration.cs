using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class BöckerEntityTypeConfiguration : IEntityTypeConfiguration<Böcker>
        {
            public void Configure(EntityTypeBuilder<Böcker> builder)
            {
                builder.HasKey(e => e.Isbn);

                builder.ToTable("Böcker");

                builder.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                builder.Property(e => e.AntalSidor).HasColumnName("Antal sidor");

                builder.Property(e => e.Format)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.FörlagId).HasColumnName("FörlagID");

                builder.Property(e => e.Språk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.Titel)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(e => e.Utgivningsdatum).HasColumnType("date");

                builder.HasOne(d => d.Förlag)
                    .WithMany(p => p.Böcker)
                    .HasForeignKey(d => d.FörlagId)
                    .HasConstraintName("FK_Böcker_Förlag");
            }
        }
    }
}
