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
    
    public partial class MediaPlayers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediaPlayers()
        {
            this.MediaPlayerStatus = new HashSet<MediaPlayerStatus>();
            this.MediaPlayerStatus1 = new HashSet<MediaPlayerStatus>();
        }
    
        public System.Guid ID { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public int CurrentState { get; set; }
        public int CurrentIPState { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MediaPlayerStatus> MediaPlayerStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MediaPlayerStatus> MediaPlayerStatus1 { get; set; }
    }
}
