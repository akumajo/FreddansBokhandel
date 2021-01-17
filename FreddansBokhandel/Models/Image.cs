using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FreddansBokhandel
{
    public partial class Image
    {
        public string Id { get; set; }

        [Column("Image")]
        public byte[] ImageArray { get; set; }

        public virtual Book IdNavigation { get; set; }
    }
}
