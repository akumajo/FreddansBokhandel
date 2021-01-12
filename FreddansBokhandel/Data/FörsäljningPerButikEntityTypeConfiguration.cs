using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class FörsäljningPerButikEntityTypeConfiguration : IEntityTypeConfiguration<FörsäljningPerButik>
        {
            public void Configure(EntityTypeBuilder<FörsäljningPerButik> builder)
            {
                builder.HasNoKey();

                builder.ToView("TotalFörsäljningPerButik");

                builder.Property(e => e.Butik)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.TotalSumma)
                    .HasMaxLength(4000)
                    .HasColumnName("Total summa");
            }
        }
    }
}
