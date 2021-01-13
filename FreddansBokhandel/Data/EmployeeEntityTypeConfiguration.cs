using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext
    {
        public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
        {
            public void Configure(EntityTypeBuilder<Employee> builder)
            {
                builder.Property(e => e.Id)
                   .ValueGeneratedNever()
                   .HasColumnName("ID");

                builder.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.HireDate).HasColumnType("date");

                builder.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.Email).HasMaxLength(100);

                builder.Property(e => e.DateOfBirth).HasColumnType("date");

                builder.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                builder.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.PostalAdress)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.Telephone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.HasOne(d => d.Stores)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Store)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Anställda_Butiker");
            }

        }
    }
}
