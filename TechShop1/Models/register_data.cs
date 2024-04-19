namespace TechShop1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class register_data
    {
        public int id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(15)]
        public string customer_code { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string confirm_password { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(20)]
        public string phone_number { get; set; }
    }
}
