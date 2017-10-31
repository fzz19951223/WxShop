namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Type")]
    public partial class Type
    {
        [Key]
        public int TID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
