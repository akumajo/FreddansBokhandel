using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class StockBalance
    {
        [Column("ButikId")]
        public int StoreID { get; set; }
        public string Isbn { get; set; }

        [Column("Antal")]
        public int Balance { get; set; }

        public virtual Store Store { get; set; }
        public virtual Book IsbnNavigation { get; set; }
    }
}