using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Member
	{
		public  int? ID { get; set; } 
		public  string LastName { get; set; } 
		public  string FirstName { get; set; } 
		public  string MiddleName { get; set; } 
		public  string Suffix { get; set; } 
		public  string Address1 { get; set; } 
		public  string Address2 { get; set; } 
		public  string Address3 { get; set; } 
		public  string City { get; set; } 
		public  int? StateID { get; set; } 
		public  int? CountryID { get; set; } 
		public  string PostalCode { get; set; } 
		public  string HomePhone { get; set; } 
		public  string CellPhone { get; set; } 
		public  string Email { get; set; } 
		public  DateTime? DOB { get; set; } 
		public  int? PlanID { get; set; } 
		public  int? DojoID { get; set; } 
		public  int? MemberTypeID { get; set; } 
		public  DateTime? DateJoined { get; set; } 
		public  DateTime? DateOfRank { get; set; } 
		public  int? RankID { get; set; } 
		public  int? Active { get; set; } 
		public  DateTime? DateInactive { get; set; } 
		public  DateTime? DateLastPaid { get; set; } 
		public  string Comments { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_applicantInsert");
		}

		public  bool Insert( Member data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_applicantInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_applicantUpdate");
		}

        public bool Update(Member data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_applicantUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_applicantUpdate");
		}

		public  List<Member> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("member");
			return MemberHelper.FromTableToList(tbl);
		}

		public  List<Member> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("member", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return MemberHelper.FromTableToList(tbl);
		}

		public  Member GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "member");
			return MemberHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class MemberHelper
	{
		internal static List<Member> FromTableToList(DataTable tbl)
		{
			IList<Member> data = tbl.AsEnumerable().Select(row =>
				new Member
				{
					ID = row.Field<int?>("ID"),
					LastName = row.Field<string>("LastName"),
					FirstName = row.Field<string>("FirstName"),
					MiddleName = row.Field<string>("MiddleName"),
					Suffix = row.Field<string>("Suffix"),
					Address1 = row.Field<string>("Address1"),
					Address2 = row.Field<string>("Address2"),
					Address3 = row.Field<string>("Address3"),
					City = row.Field<string>("City"),
					StateID = row.Field<int?>("StateID"),
					CountryID = row.Field<int?>("CountryID"),
					PostalCode = row.Field<string>("PostalCode"),
					HomePhone = row.Field<string>("HomePhone"),
					CellPhone = row.Field<string>("CellPhone"),
					Email = row.Field<string>("Email"),
					DOB = row.Field<DateTime?>("DOB"),
					PlanID = row.Field<int?>("PlanID"),
					DojoID = row.Field<int?>("DojoID"),
					MemberTypeID = row.Field<int?>("MemberTypeID"),
					DateJoined = row.Field<DateTime?>("DateJoined"),
					DateOfRank = row.Field<DateTime?>("DateOfRank"),
					RankID = row.Field<int?>("RankID"),
					Active = row.Field<int?>("Active"),
					DateInactive = row.Field<DateTime?>("DateInactive"),
					DateLastPaid = row.Field<DateTime?>("DateLastPaid"),
					Comments = row.Field<string>("Comments"),
				}).ToList();
			return (List<Member>)data;
		}
	}
}
