namespace Computer_Shop_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Brand")]
    public partial class Brand
    {
        [Key]
        [StringLength(50)]
        public string Brand_Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Brand_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand_Status { get; set; }
    }
}
