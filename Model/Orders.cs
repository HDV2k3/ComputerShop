namespace Computer_Shop_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        [Key]
        [StringLength(32)]
        public string Orders_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Users_Id { get; set; }

        public DateTime? Order_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer_Number { get; set; }

        public int Total_Amout { get; set; }

        public int Paid_Amout { get; set; }

        public int Due_Amout { get; set; }

        [Required]
        [StringLength(50)]
        public string Discounts_Id { get; set; }

        public int Grand_Total { get; set; }
        public string Payment_Methods { get; set; }

        [StringLength(128)]
        public string StatusPayment { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual DisCount DisCount { get; set; }
 

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual User User { get; set; }
    }
}
