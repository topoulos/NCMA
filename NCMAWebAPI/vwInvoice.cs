//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCMAWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwInvoice
    {
        public int productid { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public Nullable<System.DateTime> DateJoined { get; set; }
        public Nullable<int> Active { get; set; }
        public Nullable<System.DateTime> DateLastPaid { get; set; }
        public Nullable<System.DateTime> DateInactive { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<int> MemberID { get; set; }
        public int lineitemid { get; set; }
        public int qty { get; set; }
        public int discount { get; set; }
        public int invoiceid { get; set; }
        public string productname { get; set; }
        public int prodcatid { get; set; }
        public Nullable<int> prodduration { get; set; }
        public decimal prodamt { get; set; }
        public string prodcatname { get; set; }
    }
}