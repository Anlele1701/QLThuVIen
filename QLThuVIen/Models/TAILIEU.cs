//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuVIen.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAILIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAILIEU()
        {
            this.PHIEUMUONs = new HashSet<PHIEUMUON>();
        }
    
        public string ID_TAILIEU { get; set; }
        public string TENTAILIEU { get; set; }
        public string TACGIA { get; set; }
        public string HINHANH { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<int> SOTRANG { get; set; }
        public string IDTL { get; set; }
        public string IDNHAXB { get; set; }
    
        public virtual NHAXB NHAXB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUON> PHIEUMUONs { get; set; }
        public virtual THELOAI THELOAI { get; set; }
    }
}
