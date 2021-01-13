using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
        {
            public void Configure(EntityTypeBuilder<Book> builder)
            {
                builder.HasKey(e => e.Isbn);

                builder.ToTable("Böcker");

                builder.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                builder.Property(e => e.Pages).HasColumnName("Antal sidor");

                builder.Property(e => e.Format)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.PublisherId).HasColumnName("FörlagID");

                builder.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(e => e.ReleaseDate).HasColumnType("date");

                builder.HasOne(d => d.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK_Böcker_Förlag");
            }
        }
    }
}
