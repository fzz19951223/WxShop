namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stock")]
    public partial class Stock
    {
        [Key]
        public int SID { get; set; }

        public int? Num { get; set; }

        public int PID { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        public int? GID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual GuiGe GuiGe { get; set; }

        public virtual ProductInfo ProductInfo { get; set; }
    }
}
