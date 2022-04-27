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
    
    public partial class MenuConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MenuConfiguration()
        {
            this.AssignMenuHeaders = new HashSet<AssignMenuHeader>();
            this.AssignRoles = new HashSet<AssignRole>();
        }
    
        public int MenuId { get; set; }
        public string MenuKey { get; set; }
        public string Name { get; set; }
        public string MenuController { get; set; }
        public string MenuAction { get; set; }
        public string MenuIcon { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public bool IsAdminOnly { get; set; }
        public int SortOrder { get; set; }
        public Nullable<int> CreateUserId { get; set; }
        public Nullable<System.DateTime> CreateDateTime { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignMenuHeader> AssignMenuHeaders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignRole> AssignRoles { get; set; }
    }
}