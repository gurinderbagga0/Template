//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wempe
{
    using System;
    using System.Collections.Generic;
    
    public partial class wmpFileAttachment
    {
        public long fileNumber { get; set; }
        public Nullable<int> repairNumber { get; set; }
        public string dateStamp { get; set; }
        public string fileName { get; set; }
        public string fullPath { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<long> UpdateBy { get; set; }
        public Nullable<long> OwnerID { get; set; }
    }
}
