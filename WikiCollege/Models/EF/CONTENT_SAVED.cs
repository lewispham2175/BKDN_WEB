namespace WikiCollege.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTENT_SAVED
    {
        [Key]
        public int save_ID { get; set; }

        public int? content_ID { get; set; }

        public int? acc_ID { get; set; }

        public DateTime? created_date { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual CONTENT CONTENT { get; set; }
    }
}
