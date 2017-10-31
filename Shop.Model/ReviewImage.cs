namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReviewImage")]
    public partial class ReviewImage
    {
        [Key]
        public int RImgID { get; set; }

        public int? PRID { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        public virtual ProductReview ProductReview { get; set; }
    }
}
