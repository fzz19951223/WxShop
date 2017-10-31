namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [Key]
        public int AdsID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [Column("address")]
        [StringLength(50)]
        public string address1 { get; set; }

        [StringLength(50)]
        public string CID { get; set; }

        public int? state { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
