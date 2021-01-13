using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        [Column("Förnamn")]
        public string FirstName { get; set; }

        [Column("Efternamn")]
        public string LastName { get; set; }

        [Column("Butik")]
        public int Store { get; set; }

        [Column("Födelsedatum")]
        public DateTime DateOfBirth { get; set; }

        [Column("Anställningsdatum")]
        public DateTime HireDate { get; set; }

        [Column("Adress")]
        public string Address { get; set; }

        [Column("Postnummer")]
        public string ZipCode { get; set; }

        [Column("Postort")]
        public string PostalAdress { get; set; }

        [Column("Telefon")]
        public string Telephone { get; set; }
        public string Email { get; set; }

        [Column("Roll")]
        public string Role { get; set; }

        public virtual Store Stores { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}