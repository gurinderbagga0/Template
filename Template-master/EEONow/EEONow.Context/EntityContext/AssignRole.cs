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
    
    public partial class AssignRole
    {
        public int AssignRoleId { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
    
        public virtual UserRole UserRole { get; set; }
        public virtual MenuConfiguration MenuConfiguration { get; set; }
    }
}
