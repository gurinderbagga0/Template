//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EEONow.Context.EntityContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class USCensus_PUMAResidenceCodes
    {
        public int USCensus_PUMAResidenceCodeID { get; set; }
        public string PUMACode { get; set; }
        public string PUMADescription { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual State State { get; set; }
        public virtual USCensus_DataVersion USCensus_DataVersion { get; set; }
    }
}
