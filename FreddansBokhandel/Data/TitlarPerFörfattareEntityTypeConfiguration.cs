using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class TitlarPerFörfattareEntityTypeConfiguration : IEntityTypeConfiguration<TitlarPerFörfattare>
        {
            public void Configure(EntityTypeBuilder<TitlarPerFörfattare> builder)
            {
                builder.HasNoKey();

                builder.ToView("TitlarPerFörfattare");

                builder.Property(e => e.AntalBöcker).HasColumnName("Antal böcker");

                builder.Property(e => e.Namn).HasMaxLength(101);
            }
        }
    }
}
