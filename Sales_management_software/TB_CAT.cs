//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sales_management_software
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_CAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CAT()
        {
            this.TB_Pur = new HashSet<TB_Pur>();
        }
    
        public int ID { get; set; }
        public string CAT_Name { get; set; }
        public byte[] CAT_Cover { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pur> TB_Pur { get; set; }
    }
}
