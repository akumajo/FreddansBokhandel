using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class BooksAuthorsEntityTypeConfiguration : IEntityTypeConfiguration<BooksAuthors>
        {
            public void Configure(EntityTypeBuilder<BooksAuthors> builder)
            {
                builder.HasKey(e => new { e.Isbn, e.AuthorId });

                builder.ToTable("BöckerFörfattare");

                builder.Property(e => e.Isbn)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                builder.Property(e => e.AuthorId).HasColumnName("FörfattarID");

                builder.HasOne(d => d.Author)
                    .WithMany(p => p.BooksAuthors)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BöckerFörfattare_Författare");

                builder.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.BooksAuthors)
                    .HasForeignKey(d => d.Isbn)
                    .HasConstraintName("FK_BöckerFörfattare_Böcker");
            }
        }
    }
}
