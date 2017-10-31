namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductReview")]
    public partial class ProductReview
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductReview()
        {
            ReviewImage = new HashSet<ReviewImage>();
        }

        [Key]
        public int PRID { get; set; }

        [StringLength(50)]
        public string CID { get; set; }

        public int? PID { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public int? Start { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ProductInfo ProductInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReviewImage> ReviewImage { get; set; }
    }
}
