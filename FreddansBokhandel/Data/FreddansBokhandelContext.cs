using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FreddansBokhandel
{
    public partial class FreddansBokhandelContext : DbContext
    {
        public FreddansBokhandelContext()
        {
        }

        public FreddansBokhandelContext(DbContextOptions<FreddansBokhandelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anställda> Anställda { get; set; }
        public virtual DbSet<Butiker> Butiker { get; set; }
        public virtual DbSet<Böcker> Böcker { get; set; }
        public virtual DbSet<BöckerFörfattare> BöckerFörfattare { get; set; }
        public virtual DbSet<Författare> Författare { get; set; }
        public virtual DbSet<Förlag> Förlag { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldo { get; set; }
        public virtual DbSet<Orderhuvud> Orderhuvud { get; set; }
        public virtual DbSet<Ordrar> Ordrar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=FreddansBokhandel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new AnställdaEntityTypeConfiguration().Configure(modelBuilder.Entity<Anställda>());
            new BöckerEntityTypeConfiguration().Configure(modelBuilder.Entity<Böcker>());
            new ButikerEntityTypeConfiguration().Configure(modelBuilder.Entity<Butiker>());
            new BöckerFörfattareEntityTypeConfiguration().Configure(modelBuilder.Entity<BöckerFörfattare>());
            new FörfattareEntityTypeConfiguration().Configure(modelBuilder.Entity<Författare>());
            new FörlagEntityTypeConfiguration().Configure(modelBuilder.Entity<Förlag>());
            new LagerSaldoEntityTypeConfiguration().Configure(modelBuilder.Entity<LagerSaldo>());
            new OrdrarEntityTypeConfiguration().Configure(modelBuilder.Entity<Ordrar>());
            new OrderhuvudEntityTypeConfiguration().Configure(modelBuilder.Entity<Orderhuvud>());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
