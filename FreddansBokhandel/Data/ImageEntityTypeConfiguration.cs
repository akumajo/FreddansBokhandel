using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class ImageEntityTypeConfiguration : IEntityTypeConfiguration<Image>
        {
            public void Configure(EntityTypeBuilder<Image> builder)
            {
                builder.ToTable("Bilder");

                builder.Property(e => e.Id)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                builder.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Image)
                    .HasForeignKey<Image>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bilder_Böcker");
            }
        }
    }
}
