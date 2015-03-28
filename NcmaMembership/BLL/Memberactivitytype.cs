using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Memberactivitytype
	{
		public  int? ID { get; set; } 
		public  string Description { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_memberactivitytypeInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_memberactivitytypeInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_memberactivitytypeUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_memberactivitytypeUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_memberactivitytypeUpdate");
		}

		public  List<Memberactivitytype> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("memberactivitytype");
			return MemberactivitytypeHelper.FromTableToList(tbl);
		}

		public  List<Memberactivitytype> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("memberactivitytype", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return MemberactivitytypeHelper.FromTableToList(tbl);
		}

		public  Memberactivitytype GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "memberactivitytype");
			return MemberactivitytypeHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class MemberactivitytypeHelper
	{
		internal static List<Memberactivitytype> FromTableToList(DataTable tbl)
		{
			IList<Memberactivitytype> data = tbl.AsEnumerable().Select(row =>
				new Memberactivitytype
				{
					ID = row.Field<int?>("ID"),
					Description = row.Field<string>("Description"),
				}).ToList();
			return (List<Memberactivitytype>)data;
		}
	}
}
