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
    
    public partial class PollResponses
    {
        public int ResponseID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> PollID { get; set; }
        public Nullable<int> OptionID { get; set; }
        public Nullable<System.DateTime> RespondedAt { get; set; }
    
        public virtual PollOptions PollOptions { get; set; }
        public virtual Polls Polls { get; set; }
        public virtual Users Users { get; set; }
    }
}
