using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class MånadsFörsäljningEntityTypeConfiguration : IEntityTypeConfiguration<MånadsFörsäljning>
        {
            public void Configure(EntityTypeBuilder<MånadsFörsäljning> builder)
            {
                builder.HasNoKey();

                builder.ToView("TotalFörsäljningPerMånad");

                builder.Property(e => e.FörsäljningPerMånad)
                    .HasMaxLength(4000)
                    .HasColumnName("Försäljning per månad");

                builder.Property(e => e.TotalSumma)
                    .HasMaxLength(4000)
                    .HasColumnName("Total summa");
            }
        }
    }
}
