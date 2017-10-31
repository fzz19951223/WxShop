namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cities
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string cityid { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }

        [Required]
        [StringLength(20)]
        public string provinceid { get; set; }
    }
}
