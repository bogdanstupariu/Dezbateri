//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Content
    {
        public int debate_id { get; set; }
        public string round_1 { get; set; }
        public string round_2 { get; set; }
        public string round_3 { get; set; }
        public string round_4 { get; set; }
        public string round_5 { get; set; }
        public string round_6 { get; set; }
    
        public virtual DebateInfo DebateInfo { get; set; }
    }
}
