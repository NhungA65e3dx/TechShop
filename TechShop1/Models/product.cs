namespace TechShop1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class product
    {
        public int id { get; set; }

        [StringLength(255)]
        public string productname { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        public int? quantity { get; set; }

        public int? promotion { get; set; }
    }
}
