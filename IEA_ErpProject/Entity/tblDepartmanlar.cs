//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProject.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDepartmanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDepartmanlar()
        {
            this.tblFirmaDetaylar = new HashSet<tblFirmaDetaylar>();
            this.tblHastaneDetaylar = new HashSet<tblHastaneDetaylar>();
        }
    
        public int Id { get; set; }
        public string DepartmanKodu { get; set; }
        public string Adi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFirmaDetaylar> tblFirmaDetaylar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHastaneDetaylar> tblHastaneDetaylar { get; set; }
    }
}
