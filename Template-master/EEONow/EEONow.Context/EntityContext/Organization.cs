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
    
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            this.AgencyYearsOfServices = new HashSet<AgencyYearsOfService>();
            this.AgeRanges = new HashSet<AgeRange>();
            this.AvailableLaborMarketFileVersions = new HashSet<AvailableLaborMarketFileVersion>();
            this.EEOJobCategories = new HashSet<EEOJobCategory>();
            this.Employees = new HashSet<Employee>();
            this.FileSubmissions = new HashSet<FileSubmission>();
            this.Genders = new HashSet<Gender>();
            this.GenerateCSVs = new HashSet<GenerateCSV>();
            this.GraphOrganizationViews = new HashSet<GraphOrganizationView>();
            this.LastPerformanceRatings = new HashSet<LastPerformanceRating>();
            this.PositionYearsOfServices = new HashSet<PositionYearsOfService>();
            this.Races = new HashSet<Race>();
            this.SalaryRanges = new HashSet<SalaryRange>();
            this.VacancyRanges = new HashSet<VacancyRange>();
            this.UserRoles = new HashSet<UserRole>();
            this.AssignedGraphOrganizationViews = new HashSet<AssignedGraphOrganizationView>();
            this.OrganizationLabelFields = new HashSet<OrganizationLabelField>();
            this.EmployeeActiveFields = new HashSet<EmployeeActiveField>();
            this.PublicURLs = new HashSet<PublicURL>();
            this.LoginDeviceInfoes = new HashSet<LoginDeviceInfo>();
        }
    
        public int OrganizationId { get; set; }
        public string OrgCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public bool Active { get; set; }
        public Nullable<int> ParentOrganizationID { get; set; }
        public string NonVacanciesDisplayColorCode { get; set; }
        public string VacanciesDisplayColorCode { get; set; }
        public int CreateUserId { get; set; }
        public System.DateTime CreateDateTime { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public bool EnableTwoFactorAuthentication { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgencyYearsOfService> AgencyYearsOfServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AgeRange> AgeRanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailableLaborMarketFileVersion> AvailableLaborMarketFileVersions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EEOJobCategory> EEOJobCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileSubmission> FileSubmissions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gender> Genders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GenerateCSV> GenerateCSVs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GraphOrganizationView> GraphOrganizationViews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LastPerformanceRating> LastPerformanceRatings { get; set; }
        public virtual State State { get; set; }
        public virtual State StatesALMDefault { get; set; }
        public virtual USCensus_EEO_OccupationCodes USCensus_EEO_OccupationCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PositionYearsOfService> PositionYearsOfServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Race> Races { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryRange> SalaryRanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VacancyRange> VacancyRanges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssignedGraphOrganizationView> AssignedGraphOrganizationViews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationLabelField> OrganizationLabelFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeActiveField> EmployeeActiveFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublicURL> PublicURLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoginDeviceInfo> LoginDeviceInfoes { get; set; }
    }
}