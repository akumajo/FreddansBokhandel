using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class BooksAuthors
    {
        public string Isbn { get; set; }

        [Column("FörfattarId")]
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book IsbnNavigation { get; set; }
    }
}