using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Author
    {
        public Author()
        {
            BooksAuthors = new HashSet<BooksAuthors>();
        }
        
        public int Id { get; set; }
        [Column("Förnamn")]
        public string FirstName { get; set; }

        [Column("Efternamn")]
        public string LastName { get; set; }

        [Column("Födelsedatum")]
        public DateTime? DateOfBirth { get; set; }

        [Column("Land")]
        public string Country { get; set; }

        public virtual ICollection<BooksAuthors> BooksAuthors { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
