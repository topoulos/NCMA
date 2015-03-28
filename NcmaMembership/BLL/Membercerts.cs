using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Membercerts
	{
		public  int? ID { get; set; } 
		public  int? MemberID { get; set; } 
		public  int? DojoID { get; set; } 
		public  int? CertificateTypeID { get; set; } 
		public  string RankText { get; set; } 
		public  int? InstructorID { get; set; } 
		public  int? InstructorTypeID { get; set; } 
		public  DateTime? FromDate { get; set; } 
		public  DateTime? ThruDate { get; set; } 
		public  bool? Completed { get; set; } 
		public  int? TourneyID { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_membercertsInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_membercertsInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_membercertsUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_membercertsUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_membercertsUpdate");
		}

		public  List<Membercerts> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("membercerts");
			return MembercertsHelper.FromTableToList(tbl);
		}

		public  List<Membercerts> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("membercerts", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return MembercertsHelper.FromTableToList(tbl);
		}

		public  Membercerts GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "membercerts");
			return MembercertsHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class MembercertsHelper
	{
		internal static List<Membercerts> FromTableToList(DataTable tbl)
		{
			IList<Membercerts> data = tbl.AsEnumerable().Select(row =>
				new Membercerts
				{
					ID = row.Field<int?>("ID"),
					MemberID = row.Field<int?>("MemberID"),
					DojoID = row.Field<int?>("DojoID"),
					CertificateTypeID = row.Field<int?>("CertificateTypeID"),
					RankText = row.Field<string>("RankText"),
					InstructorID = row.Field<int?>("InstructorID"),
					InstructorTypeID = row.Field<int?>("InstructorTypeID"),
					FromDate = row.Field<DateTime?>("FromDate"),
					ThruDate = row.Field<DateTime?>("ThruDate"),
					Completed = row.Field<bool?>("Completed"),
					TourneyID = row.Field<int?>("TourneyID"),
				}).ToList();
			return (List<Membercerts>)data;
		}
	}
}
