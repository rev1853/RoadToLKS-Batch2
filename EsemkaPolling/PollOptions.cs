//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EsemkaPolling
{
    using System;
    using System.Collections.Generic;
    
    public partial class PollOptions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PollOptions()
        {
            this.PollResponses = new HashSet<PollResponses>();
        }
    
        public int OptionID { get; set; }
        public Nullable<int> PollID { get; set; }
        public string OptionText { get; set; }
    
        public virtual Polls Polls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PollResponses> PollResponses { get; set; }
    }
}