namespace WikiCollege.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COLLEGE")]
    public partial class COLLEGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COLLEGE()
        {
            COLLEGE_SAVED = new HashSet<COLLEGE_SAVED>();
            MAJ_COLLEGE = new HashSet<MAJ_COLLEGE>();
        }

        [Key]
        [StringLength(5)]
        public string college_code { get; set; }

        public int? college_type { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public int? area { get; set; }

        [StringLength(100)]
        public string display_name { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(200)]
        public string website { get; set; }

        public DateTime? created_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLLEGE_SAVED> COLLEGE_SAVED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAJ_COLLEGE> MAJ_COLLEGE { get; set; }
    }
}
