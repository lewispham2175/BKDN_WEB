namespace WikiCollege.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOTIFICATION")]
    public partial class NOTIFICATION
    {
        [Key]
        public int notif_ID { get; set; }

        public int? content_ID { get; set; }

        public bool? status { get; set; }

        public DateTime? created_date { get; set; }

        public virtual CONTENT CONTENT { get; set; }
    }
}
