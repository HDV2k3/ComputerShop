namespace Computer_Shop_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [Key]
        [StringLength(50)]
        public string Category_Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Category_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Category_Status { get; set; }
        public Category(string idca, string nameca, string statusca)
        {
            this.Category_Id = idca;
            this.Category_Name = nameca;
            this.Category_Status = statusca;
        }
    }
}
