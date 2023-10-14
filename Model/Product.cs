namespace Computer_Shop_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        public int Product_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Product_Name { get; set; }

        [Column(TypeName = "image")]
        public byte[] Product_Image { get; set; }

        public int Product_Rate { get; set; }

        public int Product_Quantity { get; set; }

        [Required]
        [StringLength(150)]
        public string Product_Brand { get; set; }

        [Required]
        [StringLength(150)]
        public string Product_Category { get; set; }

        [Required]
        [StringLength(50)]
        public string Product_Stastus { get; set; }

        public int? ProductOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual ProductOrder ProductOrder1 { get; set; }
    }
}
