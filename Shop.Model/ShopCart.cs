namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShopCart")]
    public partial class ShopCart
    {
        public int ShopCartID { get; set; }

        public int PID { get; set; }

        public int? Num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }

        [StringLength(50)]
        public string CID { get; set; }

        public int? ischeck { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ProductInfo ProductInfo { get; set; }
    }
}
