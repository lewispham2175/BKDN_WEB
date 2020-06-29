using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace WikiCollege.Models.EF
{
    [Table("ACCOUNTS")]
    public partial class ACCOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACCOUNT()
        {
            COLLEGE_SAVED = new HashSet<COLLEGE_SAVED>();
            COMMENTs = new HashSet<COMMENT>();
            CONTENT_SAVED = new HashSet<CONTENT_SAVED>();
            MAJOR_SAVED = new HashSet<MAJOR_SAVED>();
        }


        [Key]
        public int acc_ID { get; set; }

        [StringLength(10)]
        [Display(Name = "Phân quyền")]
        public string acc_type { get; set; }

        [StringLength(20)]
        [Display(Name ="Tên truy cập")]
        public string user_name { get; set; }

        [StringLength(100)]
        [Display(Name = "Mật khẩu")]
        public string pass_word { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ và tên")]
        public string full_name { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ email")]
        public string email { get; set; }

        [StringLength(50)]
        [Display(Name = "Nơi ở hiện tại")]
        public string address { get; set; }

        [StringLength(20)]
        [Display(Name = "Số điện thoại")]
        public string phone { get; set; }

        [Display(Name = "Trạng thái")]
        public bool? status { get; set; }

        public DateTime? created_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLLEGE_SAVED> COLLEGE_SAVED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTENT_SAVED> CONTENT_SAVED { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAJOR_SAVED> MAJOR_SAVED { get; set; }
    }
}

