namespace NCMA.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NcmaModel : DbContext
    {
        public NcmaModel()
            : base("name=NcmaModel")
        {
        }

        public virtual DbSet<applicant> applicants { get; set; }
        public virtual DbSet<blacklist> blacklists { get; set; }
        public virtual DbSet<certificate> certificates { get; set; }
        public virtual DbSet<cert> certs { get; set; }
        public virtual DbSet<certtype> certtypes { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<dojo> dojoes { get; set; }
        public virtual DbSet<dojoinstructor> dojoinstructors { get; set; }
        public virtual DbSet<instructortype> instructortypes { get; set; }
        public virtual DbSet<invoice> invoices { get; set; }
        public virtual DbSet<issuetype> issuetypes { get; set; }
        public virtual DbSet<lineitem> lineitems { get; set; }
        public virtual DbSet<member> members { get; set; }
        public virtual DbSet<memberactivity> memberactivities { get; set; }
        public virtual DbSet<memberactivitytype> memberactivitytypes { get; set; }
        public virtual DbSet<membercert> membercerts { get; set; }
        public virtual DbSet<memberdiscount> memberdiscounts { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<prodcat> prodcats { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<tournachievementtype> tournachievementtypes { get; set; }
        public virtual DbSet<tournament> tournaments { get; set; }
        public virtual DbSet<tourncomptype> tourncomptypes { get; set; }
        public virtual DbSet<tourndivision> tourndivisions { get; set; }
        public virtual DbSet<tournresult> tournresults { get; set; }
        public virtual DbSet<inactive> inactives { get; set; }
        public virtual DbSet<inactivemember> inactivemembers { get; set; }
        public virtual DbSet<memberissue> memberissues { get; set; }
        public virtual DbSet<membertype> membertypes { get; set; }
        public virtual DbSet<rank> ranks { get; set; }
        public virtual DbSet<vwActiveInstructor> vwActiveInstructors { get; set; }
        public virtual DbSet<vwAllGridLookup> vwAllGridLookups { get; set; }
        public virtual DbSet<vwCertificate> vwCertificates { get; set; }
        public virtual DbSet<vwInactiveGridLookup> vwInactiveGridLookups { get; set; }
        public virtual DbSet<vwInvoice> vwInvoices { get; set; }
        public virtual DbSet<vwMemberGrid> vwMemberGrids { get; set; }
        public virtual DbSet<vwMemberGridLookup> vwMemberGridLookups { get; set; }
        public virtual DbSet<vwMemberLookup> vwMemberLookups { get; set; }
        public virtual DbSet<vwTournResult> vwTournResults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<applicant>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.Suffix)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.About)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.Style)
                .IsUnicode(false);

            modelBuilder.Entity<applicant>()
                .Property(e => e.DojoName)
                .IsUnicode(false);

            modelBuilder.Entity<blacklist>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<blacklist>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<blacklist>()
                .Property(e => e.Reason)
                .IsUnicode(false);

            modelBuilder.Entity<certificate>()
                .Property(e => e.CertType)
                .IsUnicode(false);

            modelBuilder.Entity<certtype>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<certtype>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<dojo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<dojo>()
                .Property(e => e.Style)
                .IsUnicode(false);

            modelBuilder.Entity<instructortype>()
                .Property(e => e.InstructorTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<issuetype>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<issuetype>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Suffix)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.RankText)
                .IsUnicode(false);

            modelBuilder.Entity<member>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<memberactivity>()
                .Property(e => e.ActivityDescription)
                .IsUnicode(false);

            modelBuilder.Entity<memberactivitytype>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.paymentamount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<prodcat>()
                .Property(e => e.prodcatname)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.productname)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.amount)
                .HasPrecision(12, 2);

            modelBuilder.Entity<state>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<state>()
                .Property(e => e.StateAbbrev)
                .IsUnicode(false);

            modelBuilder.Entity<tournachievementtype>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tournachievementtype>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tournament>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tournament>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<tournament>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<tournament>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<tournament>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<tournament>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<tourncomptype>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tourncomptype>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tourndivision>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tourndivision>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.Suffix)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.RankText)
                .IsUnicode(false);

            modelBuilder.Entity<inactive>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.Suffix)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.RankText)
                .IsUnicode(false);

            modelBuilder.Entity<inactivemember>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<memberissue>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<membertype>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<vwActiveInstructor>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<vwActiveInstructor>()
                .Property(e => e.Last)
                .IsUnicode(false);

            modelBuilder.Entity<vwActiveInstructor>()
                .Property(e => e.First)
                .IsUnicode(false);

            modelBuilder.Entity<vwActiveInstructor>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<vwActiveInstructor>()
                .Property(e => e.Dojo)
                .IsUnicode(false);

            modelBuilder.Entity<vwActiveInstructor>()
                .Property(e => e.MemType)
                .IsUnicode(false);

            modelBuilder.Entity<vwActiveInstructor>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<vwAllGridLookup>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<vwAllGridLookup>()
                .Property(e => e.Last)
                .IsUnicode(false);

            modelBuilder.Entity<vwAllGridLookup>()
                .Property(e => e.First)
                .IsUnicode(false);

            modelBuilder.Entity<vwAllGridLookup>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<vwAllGridLookup>()
                .Property(e => e.Dojo)
                .IsUnicode(false);

            modelBuilder.Entity<vwAllGridLookup>()
                .Property(e => e.MemType)
                .IsUnicode(false);

            modelBuilder.Entity<vwAllGridLookup>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<vwAllGridLookup>()
                .Property(e => e.RankText)
                .IsUnicode(false);

            modelBuilder.Entity<vwCertificate>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<vwCertificate>()
                .Property(e => e.InstructorsName)
                .IsUnicode(false);

            modelBuilder.Entity<vwCertificate>()
                .Property(e => e.Dojo)
                .IsUnicode(false);

            modelBuilder.Entity<vwCertificate>()
                .Property(e => e.InstructorType)
                .IsUnicode(false);

            modelBuilder.Entity<vwCertificate>()
                .Property(e => e.CertType)
                .IsUnicode(false);

            modelBuilder.Entity<vwInactiveGridLookup>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<vwInactiveGridLookup>()
                .Property(e => e.Last)
                .IsUnicode(false);

            modelBuilder.Entity<vwInactiveGridLookup>()
                .Property(e => e.First)
                .IsUnicode(false);

            modelBuilder.Entity<vwInactiveGridLookup>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<vwInactiveGridLookup>()
                .Property(e => e.Dojo)
                .IsUnicode(false);

            modelBuilder.Entity<vwInactiveGridLookup>()
                .Property(e => e.MemType)
                .IsUnicode(false);

            modelBuilder.Entity<vwInactiveGridLookup>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<vwInactiveGridLookup>()
                .Property(e => e.RankText)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.Suffix)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.Address1)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.Address2)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.Address3)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.productname)
                .IsUnicode(false);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.prodamt)
                .HasPrecision(12, 2);

            modelBuilder.Entity<vwInvoice>()
                .Property(e => e.prodcatname)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGrid>()
                .Property(e => e.Last)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGrid>()
                .Property(e => e.First)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGrid>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGrid>()
                .Property(e => e.Dojo)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGrid>()
                .Property(e => e.MemType)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGrid>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGrid>()
                .Property(e => e.RankText)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGridLookup>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGridLookup>()
                .Property(e => e.Last)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGridLookup>()
                .Property(e => e.First)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGridLookup>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGridLookup>()
                .Property(e => e.Dojo)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGridLookup>()
                .Property(e => e.MemType)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGridLookup>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberGridLookup>()
                .Property(e => e.RankText)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberLookup>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<vwMemberLookup>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.Last)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.First)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.Dojo)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.MemType)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.tourncomptypename)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.tournstate)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.tournachievementtypename)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.tournachievementtypedesc)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.tourndivisionname)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.tourndivisiondesc)
                .IsUnicode(false);

            modelBuilder.Entity<vwTournResult>()
                .Property(e => e.tourncomptypedesc)
                .IsUnicode(false);
        }
    }
}
