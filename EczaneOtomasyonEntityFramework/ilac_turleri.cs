//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EczaneOtomasyonEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class ilac_turleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ilac_turleri()
        {
            this.ilaclar = new HashSet<ilaclar>();
        }
    
        public int tur_id { get; set; }
        public string tur_ismi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ilaclar> ilaclar { get; set; }
    }
}