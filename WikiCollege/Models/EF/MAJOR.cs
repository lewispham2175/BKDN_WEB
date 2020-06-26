namespace WikiCollege.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAJOR")]
    public partial class MAJOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAJOR()
        {
            MAJ_COLLEGE = new HashSet<MAJ_COLLEGE>();
            MAJOR_SAVED = new HashSet<MAJOR_SAVED>();
        }

        [Key]
        [StringLength(5)]
        public string major_code { get; set; }

        [StringLength(100)]
        public string display_name { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(5)]
        public string group { get; set; }

        public DateTime? created_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAJ_COLLEGE> MAJ_COLLEGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAJOR_SAVED> MAJOR_SAVED { get; set; }
    }
}
