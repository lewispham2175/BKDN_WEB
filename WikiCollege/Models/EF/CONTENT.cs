namespace WikiCollege.Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONTENT")]
    public partial class CONTENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTENT()
        {
            COMMENTs = new HashSet<COMMENT>();
            CONTENT_SAVED = new HashSet<CONTENT_SAVED>();
            NOTIFICATIONs = new HashSet<NOTIFICATION>();
        }

        [Key]
        public int content_ID { get; set; }

        public int? author_ID { get; set; }

        [StringLength(250)]
        public string meta_title { get; set; }

        [StringLength(250)]
        public string title { get; set; }

        [StringLength(500)]
        public string desciption { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        [Column(TypeName = "ntext")]
        public string detail { get; set; }

        public DateTime? created_date { get; set; }

        public bool? status { get; set; }

        public DateTime? top_hot { get; set; }

        public int? view_count { get; set; }

        [StringLength(500)]
        public string tags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTENT_SAVED> CONTENT_SAVED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONs { get; set; }
    }
}
