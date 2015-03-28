using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  State
	{
		public  int? ID { get; set; } 
		public  string StateName { get; set; } 
		public  string StateAbbrev { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_stateInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_stateInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_stateUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_stateUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_stateUpdate");
		}

		public  List<State> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("state");
			return StateHelper.FromTableToList(tbl);
		}

		public  List<State> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("state", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return StateHelper.FromTableToList(tbl);
		}

		public  State GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "state");
			return StateHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class StateHelper
	{
		internal static List<State> FromTableToList(DataTable tbl)
		{
			IList<State> data = tbl.AsEnumerable().Select(row =>
				new State
				{
					ID = row.Field<int?>("ID"),
					StateName = row.Field<string>("StateName"),
					StateAbbrev = row.Field<string>("StateAbbrev"),
				}).ToList();
			return (List<State>)data;
		}
	}
}
