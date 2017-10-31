namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderBillFat")]
    public partial class OrderBillFat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderBillFat()
        {
            OrderBillChi = new HashSet<OrderBillChi>();
        }

        [Key]
        [StringLength(50)]
        public string OFID { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Prices { get; set; }

        [Required]
        [StringLength(50)]
        public string CID { get; set; }

        [StringLength(50)]
        public string Paymethod { get; set; }

        [StringLength(50)]
        public string FTime { get; set; }

        [StringLength(50)]
        public string STime { get; set; }

        [StringLength(50)]
        public string ZTime { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderBillChi> OrderBillChi { get; set; }
    }
}
