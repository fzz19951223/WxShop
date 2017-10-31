namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSortm")]
    public partial class ProductSortm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductSortm()
        {
            ProductInfo = new HashSet<ProductInfo>();
        }

        [Key]
        public int SortIDm { get; set; }

        public int FID { get; set; }

        [Required]
        [StringLength(50)]
        public string SortNamem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductInfo> ProductInfo { get; set; }

        public virtual ProductSort ProductSort { get; set; }
    }
}
