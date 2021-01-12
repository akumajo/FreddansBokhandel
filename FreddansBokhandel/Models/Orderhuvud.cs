using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Orderhuvud
    {
        public string Id { get; set; }
        public int OrderId { get; set; }
        public string Isbn { get; set; }
        public int Pris { get; set; }
        public int Kvantitet { get; set; }

        public virtual Böcker IsbnNavigation { get; set; }
        public virtual Ordrar Order { get; set; }
    }
}
