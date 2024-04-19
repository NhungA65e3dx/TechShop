using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TechShop1.Models
{
    public partial class CuaHang : DbContext
    {
        public CuaHang()
            : base("name=CuaHang")
        {
        }

        public virtual DbSet<product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);
        }
    }
}
