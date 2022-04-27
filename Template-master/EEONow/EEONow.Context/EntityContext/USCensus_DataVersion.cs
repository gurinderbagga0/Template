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
    
    public partial class USCensus_DataVersion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USCensus_DataVersion()
        {
            this.USCensus_ALLData = new HashSet<USCensus_ALLData>();
            this.USCensus_PUMAResidenceCodes = new HashSet<USCensus_PUMAResidenceCodes>();
            this.USCensus_EmployeeStatusRecode = new HashSet<USCensus_EmployeeStatusRecode>();
            this.USCensus_GeographyTypes = new HashSet<USCensus_GeographyTypes>();
            this.USCensus_MajorOccupationGroups = new HashSet<USCensus_MajorOccupationGroups>();
            this.USCensus_PUMAWorksiteCodes = new HashSet<USCensus_PUMAWorksiteCodes>();
            this.USCensus_EEO_OccupationCodes = new HashSet<USCensus_EEO_OccupationCodes>();
        }
    
        public int USCensusVersionID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<int> Year { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USCensus_ALLData> USCensus_ALLData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USCensus_PUMAResidenceCodes> USCensus_PUMAResidenceCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USCensus_EmployeeStatusRecode> USCensus_EmployeeStatusRecode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USCensus_GeographyTypes> USCensus_GeographyTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USCensus_MajorOccupationGroups> USCensus_MajorOccupationGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USCensus_PUMAWorksiteCodes> USCensus_PUMAWorksiteCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USCensus_EEO_OccupationCodes> USCensus_EEO_OccupationCodes { get; set; }
    }
}
