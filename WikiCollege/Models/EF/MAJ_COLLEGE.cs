namespace WikiCollege.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAJ_COLLEGE
    {
        public int ID { get; set; }

        [Required]
        [StringLength(5)]
        public string college_code { get; set; }

        [StringLength(5)]
        public string major_code { get; set; }

        public int? year { get; set; }

        public double? prev_mark { get; set; }

        public DateTime? created_date { get; set; }

        public virtual COLLEGE COLLEGE { get; set; }

        public virtual MAJOR MAJOR { get; set; }
    }
}
