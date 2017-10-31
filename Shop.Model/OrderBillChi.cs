namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderBillChi")]
    public partial class OrderBillChi
    {
        [Key]
        public int OCID { get; set; }

        public int? PID { get; set; }

        [StringLength(10)]
        public string Num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }

        public int? isReview { get; set; }

        [StringLength(50)]
        public string FID { get; set; }

        [StringLength(50)]
        public string CID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual OrderBillFat OrderBillFat { get; set; }

        public virtual ProductInfo ProductInfo { get; set; }
    }
}
