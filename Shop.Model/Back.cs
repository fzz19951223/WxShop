namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Back")]
    public partial class Back
    {
        [Key]
        public int BID { get; set; }

        [StringLength(50)]
        public string CID { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [StringLength(10)]
        public string Tel { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
