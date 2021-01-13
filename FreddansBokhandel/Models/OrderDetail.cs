using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class OrderDetail
    {
        public string Id { get; set; }
        public int OrderId { get; set; }
        public string Isbn { get; set; }
        [Column("Pris")]
        public int Price { get; set; }

        [Column("Kvantitet")]
        public int Quantity { get; set; }

        public virtual Book IsbnNavigation { get; set; }
        public virtual Order Order { get; set; }
    }
}