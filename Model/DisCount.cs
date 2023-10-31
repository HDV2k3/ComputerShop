namespace Computer_Shop_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DisCount")]
    public partial class DisCount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DisCount(string text, string v)
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        [StringLength(50)]
        public string Discounts_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Discounts_Name { get; set; }

        public int Discounts_Percent { get; set; }
        public string Discounts_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public DisCount()
        { }
        public DisCount(string discounts_Id, string discounts_Name, int discounts_Percent,string discounts_Status)
        {
            Discounts_Id = discounts_Id;
            Discounts_Name = discounts_Name;
            Discounts_Percent = discounts_Percent;
            Discounts_Status = discounts_Status;
           
        }
        
    }
}
