//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_LOAICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_LOAICA()
        {
            this.tb_TANGCA = new HashSet<tb_TANGCA>();
        }
    
        public int IDLOAICA { get; set; }
        public string TENLOAICA { get; set; }
        public Nullable<double> HESO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TANGCA> tb_TANGCA { get; set; }
    }
}
