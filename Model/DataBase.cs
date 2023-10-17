using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Computer_Shop_Management_System.Model
{
    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase1")
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.Brand_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Category_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Orders_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Customer_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Users_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Users_Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Users_Email)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.Orders_Id)
                .IsUnicode(false);
        }
    }
}