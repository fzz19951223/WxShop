namespace Shop.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notice")]
    public partial class Notice
    {
        public int NoticeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string Text { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [StringLength(50)]
        public string PostUid { get; set; }
    }
}
