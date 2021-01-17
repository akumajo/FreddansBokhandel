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

        public virtual DbSet<Employee> Anställda { get; set; }
        public virtual DbSet<Store> Butiker { get; set; }
        public virtual DbSet<Book> Böcker { get; set; }
        public virtual DbSet<BooksAuthors> BöckerFörfattare { get; set; }
        public virtual DbSet<Author> Författare { get; set; }
        public virtual DbSet<Publisher> Förlag { get; set; }
        public virtual DbSet<StockBalance> LagerSaldo { get; set; }
        public virtual DbSet<OrderDetail> Orderdetaljer { get; set; }
        public virtual DbSet<Order> Ordrar { get; set; }
        public virtual DbSet<Image> Bilder { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=FreddansBokhandel;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new EmployeeEntityTypeConfiguration().Configure(modelBuilder.Entity<Employee>());
            new BookEntityTypeConfiguration().Configure(modelBuilder.Entity<Book>());
            new StoreEntityTypeConfiguration().Configure(modelBuilder.Entity<Store>());
            new BooksAuthorsEntityTypeConfiguration().Configure(modelBuilder.Entity<BooksAuthors>());
            new AuthorEntityTypeConfiguration().Configure(modelBuilder.Entity<Author>());
            new PublisherEntityTypeConfiguration().Configure(modelBuilder.Entity<Publisher>());
            new StockBalanceEntityTypeConfiguration().Configure(modelBuilder.Entity<StockBalance>());
            new OrderEntityTypeConfiguration().Configure(modelBuilder.Entity<Order>());
            new OrderDetailEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderDetail>());
            new ImageEntityTypeConfiguration().Configure(modelBuilder.Entity<Image>());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
