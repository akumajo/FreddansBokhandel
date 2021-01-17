using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Book
    {
        public Book()
        {
            BooksAuthors = new HashSet<BooksAuthors>();
            StockBalance = new HashSet<StockBalance>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Isbn { get; set; }
        [Column("Titel")]
        public string Title { get; set; }

        [Column("Språk")]
        public string Language { get; set; }

        [Column("Pris")]
        public int Price { get; set; }

        [Column("Utgivningsdatum")]
        public DateTime ReleaseDate { get; set; }

        [Column("AntalSidor")]
        public int Pages { get; set; }
        public string Format { get; set; }

        [Column("FörlagId")]
        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; } // Förlag
        public virtual ICollection<BooksAuthors> BooksAuthors { get; set; } //BöckerFörfattare
        public virtual ICollection<StockBalance> StockBalance { get; set; } //Lagersaldo
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } //Orderhuvud
        public virtual Image Image { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}