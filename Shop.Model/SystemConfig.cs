namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemConfig")]
    public partial class SystemConfig
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Parmname { get; set; }

        [StringLength(50)]
        public string Parmvalue { get; set; }
    }
}
