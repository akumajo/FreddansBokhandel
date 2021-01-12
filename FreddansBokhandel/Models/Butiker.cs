using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Butiker
    {
        public Butiker()
        {
            Anställda = new HashSet<Anställda>();
            LagerSaldo = new HashSet<LagerSaldo>();
            Ordrar = new HashSet<Ordrar>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Postnr { get; set; }
        public string Postadress { get; set; }
        public string Land { get; set; }

        public virtual ICollection<Anställda> Anställda { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldo { get; set; }
        public virtual ICollection<Ordrar> Ordrar { get; set; }

        public override string ToString()
        {
            return Namn;
        }
    }
}
