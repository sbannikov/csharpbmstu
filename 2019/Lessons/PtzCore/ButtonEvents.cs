//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bmstu.IU6.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class ButtonEvents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ButtonEvents()
        {
            this.Accidents = new HashSet<Accidents>();
        }
    
        public System.Guid ID { get; set; }
        public int BType { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int Number { get; set; }
        public int Counter1 { get; set; }
        public int Counter2 { get; set; }
        public int Counter3 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accidents> Accidents { get; set; }
    }
}
