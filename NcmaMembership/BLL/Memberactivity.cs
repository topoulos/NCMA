using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Memberactivity
	{
		public  int? ID { get; set; } 
		public  int? TypeID { get; set; } 
		public  DateTime? ActivityDate { get; set; } 
		public  int? MemberID { get; set; } 
		public  string ActivityDescription { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_memberactivityInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_memberactivityInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_memberactivityUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_memberactivityUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_memberactivityUpdate");
		}

		public  List<Memberactivity> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("memberactivity");
			return MemberactivityHelper.FromTableToList(tbl);
		}

		public  List<Memberactivity> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("memberactivity", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return MemberactivityHelper.FromTableToList(tbl);
		}

		public  Memberactivity GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "memberactivity");
			return MemberactivityHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class MemberactivityHelper
	{
		internal static List<Memberactivity> FromTableToList(DataTable tbl)
		{
			IList<Memberactivity> data = tbl.AsEnumerable().Select(row =>
				new Memberactivity
				{
					ID = row.Field<int?>("ID"),
					TypeID = row.Field<int?>("TypeID"),
					ActivityDate = row.Field<DateTime?>("ActivityDate"),
					MemberID = row.Field<int?>("MemberID"),
					ActivityDescription = row.Field<string>("ActivityDescription"),
				}).ToList();
			return (List<Memberactivity>)data;
		}
	}
}
