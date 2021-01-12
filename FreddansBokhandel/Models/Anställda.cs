using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Anställda
    {
        public Anställda()
        {
            Ordrar = new HashSet<Ordrar>();
        }

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Butik { get; set; }
        public DateTime Födelsedatum { get; set; }
        public DateTime Anställningsdatum { get; set; }
        public string Adress { get; set; }
        public string Postnummer { get; set; }
        public string Postort { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Roll { get; set; }

        public virtual Butiker Butiker { get; set; }
        public virtual ICollection<Ordrar> Ordrar { get; set; }

        public override string ToString()
        {
            return $"{Förnamn} {Efternamn}";
        }
    }
}
