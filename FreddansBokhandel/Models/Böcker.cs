using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Böcker
    {
        public Böcker()
        {
            BöckerFörfattare = new HashSet<BöckerFörfattare>();
            Lagersaldo = new HashSet<LagerSaldo>();
            Orderhuvud = new HashSet<Orderhuvud>();
        }

        public string Isbn { get; set; }
        public string Titel { get; set; }
        public string Språk { get; set; }
        public int Pris { get; set; }
        public DateTime Utgivningsdatum { get; set; }
        public int AntalSidor { get; set; }
        public string Format { get; set; }
        public int FörlagId { get; set; }

        public virtual Förlag Förlag { get; set; }
        public virtual ICollection<BöckerFörfattare> BöckerFörfattare { get; set; }
        public virtual ICollection<LagerSaldo> Lagersaldo { get; set; }
        public virtual ICollection<Orderhuvud> Orderhuvud { get; set; }

        public override string ToString()
        {
            return Titel;
        }
    }
}
