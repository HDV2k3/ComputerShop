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
        public string users_Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        public virtual UsersCategory UsersCategory { get; set; }
       
        public User(string Usercategoryid, string Username, string password, string email)
        {
            this.Users_Category_Id = Usercategoryid;
            this.Users_Name = Username;
            this.users_Password = password;
            this.Users_Email = email;

        }

    }
}
