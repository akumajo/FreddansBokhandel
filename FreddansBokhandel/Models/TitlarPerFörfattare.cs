using System;
using System.Collections.Generic;

#nullable disable

namespace FreddansBokhandel
{
    public partial class TitlarPerFörfattare
    {
        public string Namn { get; set; }
        public int? Ålder { get; set; }
        public int? AntalBöcker { get; set; }
        public int? Lagervärde { get; set; }
    }
}
