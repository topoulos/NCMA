using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Issuetype
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 
		public  string Description { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_issuetypeInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_issuetypeInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_issuetypeUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_issuetypeUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_issuetypeUpdate");
		}

		public  List<Issuetype> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("issuetype");
			return IssuetypeHelper.FromTableToList(tbl);
		}

		public  List<Issuetype> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("issuetype", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return IssuetypeHelper.FromTableToList(tbl);
		}

		public  Issuetype GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "issuetype");
			return IssuetypeHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class IssuetypeHelper
	{
		internal static List<Issuetype> FromTableToList(DataTable tbl)
		{
			IList<Issuetype> data = tbl.AsEnumerable().Select(row =>
				new Issuetype
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
					Description = row.Field<string>("Description"),
				}).ToList();
			return (List<Issuetype>)data;
		}
	}
}
