using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }

        [Column("AnställningsId")]
        public int EmployeeID { get; set; }

        [Column("ButikId")]
        public int StoreID { get; set; }

        [Column("Beställningsdatum")]
        public DateTime OrderDate { get; set; }

        [Column("SkickatDatum")]
        public DateTime SentDate { get; set; }

        [Column("MottagareFörnamn")]
        public string RecipientFirstName { get; set; }

        [Column("MottagareEfternamn")]
        public string RecipientLastName { get; set; }

        [Column("MottagareAdress")]
        public string RecipientAddress { get; set; }

        [Column("MottagarePostnummer")]
        public string RecipientZipCode { get; set; }

        [Column("MottagarePostort")]
        public string RecipientPostalAddress { get; set; }

        [Column("MottagareLand")]
        public string RecipientCountry { get; set; }

        public virtual Employee EmployeeIDs { get; set; }
        public virtual Store Stores { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}