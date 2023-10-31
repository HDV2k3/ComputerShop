using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Computer_Shop_Management_System.Model
{
    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase")
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DisCount> DisCount { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ReturnProduct> ReturnProduct { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UsersCategory> UsersCategory { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.Brand_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Category_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Customer_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DisCount>()
                .Property(e => e.Discounts_Id)
                .IsUnicode(false);

            modelBuilder.Entity<DisCount>()
                .Property(e => e.Discounts_Name)
                .IsUnicode(false);

            modelBuilder.Entity<DisCount>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.DisCount)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Orders_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Users_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Customer_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Discounts_Id)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReturnProduct>()
                .Property(e => e.Return_Id)
                .IsUnicode(false);

            modelBuilder.Entity<ReturnProduct>()
                .Property(e => e.Users_Id)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Users_Id)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Users_Category_Id)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Users_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Users_Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Users_Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ReturnProduct)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UsersCategory>()
                .Property(e => e.Users_Category_Id)
                .IsUnicode(false);

            modelBuilder.Entity<UsersCategory>()
                .HasMany(e => e.User)
                .WithRequired(e => e.UsersCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetails>()
                .Property(e => e.Orders_Id)
                .IsUnicode(false);
        }
    }
}
