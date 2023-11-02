namespace Computer_Shop_Management_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetails
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string Orders_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Amout { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_Rate { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Total { get; set; }
 
        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Payment_Methods { get; set; }

        public int Discounts_Percent { get; set; }
        public int Produtc_Rate_Ori { get; set; }
        public virtual Orders Orders { get; set; }

        public virtual Product Product { get; set; }
    }
}
