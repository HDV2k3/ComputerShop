namespace Computer_Shop_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReturnProduct")]
    public partial class ReturnProduct
    {
        [Key]
        [StringLength(30)]
        public string Return_Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Phone_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Name { get; set; }

        public DateTime Return_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Product_Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Cause_Return { get; set; }

        public virtual User User { get; set; }
    }
}
