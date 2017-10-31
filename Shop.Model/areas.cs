namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class areas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string areaid { get; set; }

        [Required]
        [StringLength(50)]
        public string area { get; set; }

        [Required]
        [StringLength(20)]
        public string cityid { get; set; }
    }
}
