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
        [Key]
        public int Users_Id { get; set; }

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

        public virtual UsersCategory UsersCategory { get; set; }
    }
}
