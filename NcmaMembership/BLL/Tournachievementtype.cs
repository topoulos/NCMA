using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Tournachievementtype
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 
		public  string Description { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_tournachievementtypeInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_tournachievementtypeInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_tournachievementtypeUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_tournachievementtypeUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_tournachievementtypeUpdate");
		}

		public  List<Tournachievementtype> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("tournachievementtype");
			return TournachievementtypeHelper.FromTableToList(tbl);
		}

		public  List<Tournachievementtype> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("tournachievementtype", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return TournachievementtypeHelper.FromTableToList(tbl);
		}

		public  Tournachievementtype GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "tournachievementtype");
			return TournachievementtypeHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class TournachievementtypeHelper
	{
		internal static List<Tournachievementtype> FromTableToList(DataTable tbl)
		{
			IList<Tournachievementtype> data = tbl.AsEnumerable().Select(row =>
				new Tournachievementtype
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
					Description = row.Field<string>("Description"),
				}).ToList();
			return (List<Tournachievementtype>)data;
		}
	}
}
