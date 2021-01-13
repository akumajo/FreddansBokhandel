using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Store
    {
        public Store()
        {
            Employees = new HashSet<Employee>();
            StockBalance = new HashSet<StockBalance>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Column("Namn")]
        public string Name { get; set; }

        [Column("Adress")]
        public string Address { get; set; }

        [Column("Postnr")]
        public string ZipCode { get; set; }

        [Column("Postadress")]
        public string PostalAddress { get; set; }

        [Column("Land")]
        public string Country { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<StockBalance> StockBalance { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}