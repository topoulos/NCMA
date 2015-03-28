using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Applicant
	{
		public  int? id { get; set; } 
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
		public  string About { get; set; } 
		public  string Style { get; set; } 
		public  bool? Approved { get; set; } 
		public  bool? InputIntoNCMA { get; set; } 
		public  DateTime? ApprovedDate { get; set; } 
		public  DateTime? SubmitDate { get; set; } 
		public  DateTime? InputIntoNCMADate { get; set; } 
		public  string DojoName { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_applicantInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_applicantInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_applicantUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_applicantUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_applicantUpdate");
		}

		public  List<Applicant> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("applicant");
			return ApplicantHelper.FromTableToList(tbl);
		}

		public  List<Applicant> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("applicant", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return ApplicantHelper.FromTableToList(tbl);
		}

		public  Applicant GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "applicant");
			return ApplicantHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class ApplicantHelper
	{
		internal static List<Applicant> FromTableToList(DataTable tbl)
		{
			IList<Applicant> data = tbl.AsEnumerable().Select(row =>
				new Applicant
				{
					id = row.Field<int?>("id"),
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
					About = row.Field<string>("About"),
					Style = row.Field<string>("Style"),
					Approved = row.Field<bool?>("Approved"),
					InputIntoNCMA = row.Field<bool?>("InputIntoNCMA"),
					ApprovedDate = row.Field<DateTime?>("ApprovedDate"),
					SubmitDate = row.Field<DateTime?>("SubmitDate"),
					InputIntoNCMADate = row.Field<DateTime?>("InputIntoNCMADate"),
					DojoName = row.Field<string>("DojoName"),
				}).ToList();
			return (List<Applicant>)data;
		}
	}
}
