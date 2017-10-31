namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SearchHistory")]
    public partial class SearchHistory
    {
        [Key]
        public int SHID { get; set; }

        [StringLength(50)]
        public string CID { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
