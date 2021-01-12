using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Ordrar
    {
        public Ordrar()
        {
            Orderhuvud = new HashSet<Orderhuvud>();
        }

        public int Id { get; set; }
        public int AnställningsId { get; set; }
        public int ButikId { get; set; }
        public DateTime Beställningsdatum { get; set; }
        public DateTime SkickatDatum { get; set; }
        public string MottagareFörnamn { get; set; }
        public string MottagareEfternamn { get; set; }
        public string MottagareAdress { get; set; }
        public string MottagarePostnummer { get; set; }
        public string MottagarePostort { get; set; }
        public string MottagareLand { get; set; }

        public virtual Anställda AnställningsID { get; set; }
        public virtual Butiker Butik { get; set; }
        public virtual ICollection<Orderhuvud> Orderhuvud { get; set; }
        
    }
}
