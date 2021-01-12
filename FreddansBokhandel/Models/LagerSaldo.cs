using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class LagerSaldo
    {
        public int ButikId { get; set; }
        public string Isbn { get; set; }
        public int Antal { get; set; }

        public virtual Butiker Butik { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
