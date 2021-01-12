using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class BöckerFörfattare
    {
        public string Isbn { get; set; }
        public int FörfattarId { get; set; }

        public virtual Författare Författare { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
