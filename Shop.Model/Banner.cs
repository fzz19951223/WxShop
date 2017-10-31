namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banner")]
    public partial class Banner
    {
        public int BannerID { get; set; }

        [Required]
        [StringLength(50)]
        public string BannerImage { get; set; }

        [StringLength(50)]
        public string BannerUrl { get; set; }

        [StringLength(50)]
        public string PostUid { get; set; }

        [StringLength(50)]
        public string Time { get; set; }
    }
}
