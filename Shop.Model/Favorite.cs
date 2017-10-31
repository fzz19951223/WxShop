namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Favorite")]
    public partial class Favorite
    {
        [Key]
        public int FID { get; set; }

        public int? PID { get; set; }

        [StringLength(50)]
        public string CID { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ProductInfo ProductInfo { get; set; }
    }
}
