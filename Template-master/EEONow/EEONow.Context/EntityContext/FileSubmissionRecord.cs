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
    
    public partial class FileSubmissionRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileSubmissionRecord()
        {
            this.FileSubmissionErrors = new HashSet<FileSubmissionError>();
        }
    
        public int FileSubmissionRecordNumber { get; set; }
        public int FileSubmissionId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Filled { get; set; }
        public string VacancyDate { get; set; }
        public string PositionNumber { get; set; }
        public string SupervisorPositionNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string SupervisorFlag { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string NationalOrigin { get; set; }
        public string Age { get; set; }
        public string PositionTitle { get; set; }
        public string ProgramOfficeName { get; set; }
        public string OPSPosition { get; set; }
        public string Salary { get; set; }
        public string EEOCode { get; set; }
        public string PositionDateOfHire { get; set; }
        public string LastPerformanceRating { get; set; }
        public string AgencyDateOfHire { get; set; }
        public string StateCumulativeMonthsOfService { get; set; }
        public string UserID { get; set; }
        public string WorkAddress { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkZipCode { get; set; }
        public string WorkCounty { get; set; }
        public Nullable<bool> IsValidate { get; set; }
        public int CreateUserId { get; set; }
        public System.DateTime CreateDateTime { get; set; }
        public Nullable<int> UpdateUserId { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public string RegionName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileSubmissionError> FileSubmissionErrors { get; set; }
        public virtual FileSubmission FileSubmission { get; set; }
    }
}