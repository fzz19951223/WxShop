namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        [Key]
        public int UID { get; set; }

        [StringLength(50)]
        public string Uname { get; set; }

        public int? Pwd { get; set; }

        public int? Power { get; set; }
    }
}
