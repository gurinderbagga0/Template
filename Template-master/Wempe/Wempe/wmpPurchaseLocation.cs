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
    
    public partial class wmpPurchaseLocation
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string mainAddressLine1 { get; set; }
        public string mainAddressLine2 { get; set; }
        public string mainCity { get; set; }
        public string mainState { get; set; }
        public string mainZipCode { get; set; }
        public string mainZipCodePlusFour { get; set; }
        public string mainCountry { get; set; }
        public string mainTelephoneSegment1 { get; set; }
        public string mainTelephoneSegment2 { get; set; }
        public string mainTelephoneSegment3 { get; set; }
        public string mainTelephoneExtension { get; set; }
        public string mainFaxSegment1 { get; set; }
        public string mainFaxSegment2 { get; set; }
        public string mainFaxSegment3 { get; set; }
        public string mainEMailAddress { get; set; }
        public string mainContact { get; set; }
        public string mainContactTelephoneSegment1 { get; set; }
        public string mainContactTelephoneSegment2 { get; set; }
        public string mainContactTelephoneSegment3 { get; set; }
        public string mainContactTelephoneExtension { get; set; }
        public string mainContactFaxSegment1 { get; set; }
        public string mainContactFaxSegment2 { get; set; }
        public string mainContactFaxSegment3 { get; set; }
        public string mainContactEMailAddress { get; set; }
        public string notes { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<long> UpdateBy { get; set; }
        public Nullable<long> OwnerID { get; set; }
        public Nullable<long> brandId { get; set; }
    }
}