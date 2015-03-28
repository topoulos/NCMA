using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Memberissue
	{
		public  int? ID { get; set; } 
		public  int? MemberID { get; set; } 
		public  int? IssueID { get; set; } 
		public  string Notes { get; set; } 
		public  DateTime? IssueDate { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_memberissueInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_memberissueInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_memberissueUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_memberissueUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_memberissueUpdate");
		}

		public  List<Memberissue> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("memberissue");
			return MemberissueHelper.FromTableToList(tbl);
		}

		public  List<Memberissue> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("memberissue", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return MemberissueHelper.FromTableToList(tbl);
		}

		public  Memberissue GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "memberissue");
			return MemberissueHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class MemberissueHelper
	{
		internal static List<Memberissue> FromTableToList(DataTable tbl)
		{
			IList<Memberissue> data = tbl.AsEnumerable().Select(row =>
				new Memberissue
				{
					ID = row.Field<int?>("ID"),
					MemberID = row.Field<int?>("MemberID"),
					IssueID = row.Field<int?>("IssueID"),
					Notes = row.Field<string>("Notes"),
					IssueDate = row.Field<DateTime?>("IssueDate"),
				}).ToList();
			return (List<Memberissue>)data;
		}
	}
}
