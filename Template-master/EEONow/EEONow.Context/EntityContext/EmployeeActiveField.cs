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
    
    public partial class EmployeeActiveField
    {
        public int EmployeeActiveFieldId { get; set; }
        public string DisplayLabelData { get; set; }
        public bool Active { get; set; }
        public Nullable<int> Sorting { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
    
        public virtual DefaultEmployeeField DefaultEmployeeField { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
