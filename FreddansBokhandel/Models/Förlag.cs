using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Förlag
    {
        public Förlag()
        {
            Böcker = new HashSet<Böcker>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Postnummer { get; set; }
        public string Postort { get; set; }
        public string Land { get; set; }

        public virtual ICollection<Böcker> Böcker { get; set; }

        public override string ToString()
        {
            return Namn;
        }
    }
}
