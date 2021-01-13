using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        [Column("Namn")]
        public string Name { get; set; }

        [Column("Adress")]
        public string Address { get; set; }

        [Column("Postnummer")]
        public string ZipCode { get; set; }

        [Column("Postort")]
        public string PostalAddress { get; set; }

        [Column("Land")]
        public string Country { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}