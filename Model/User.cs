namespace Computer_Shop_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Orders = new HashSet<Orders>();
            ReturnProduct = new HashSet<ReturnProduct>();
        }

        [Key]
        [StringLength(50)]
        public string Users_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Category_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnProduct> ReturnProduct { get; set; }

        public virtual UsersCategory UsersCategory { get; set; }
        public User(string maloainguoidung, string loainguoidung, string tennguoidung, string matkhau, string email)
        {
            this.Users_Id = maloainguoidung;
            this.Users_Category_Id = loainguoidung;
            this.Users_Name = tennguoidung;
            this.Users_Password = matkhau;
            this.Users_Email = email;

        }
    }
}
