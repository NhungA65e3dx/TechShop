using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TechShop1.Models
{
    public partial class register : DbContext
    {
        public register()
            : base("name=register")
        {
        }

        public virtual DbSet<register_data> register_datas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<register_data>()
                .Property(e => e.customer_code)
                .IsUnicode(false);

            modelBuilder.Entity<register_data>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<register_data>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<register_data>()
                .Property(e => e.confirm_password)
                .IsUnicode(false);

            modelBuilder.Entity<register_data>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<register_data>()
                .Property(e => e.phone_number)
                .IsUnicode(false);
        }
    }
}
