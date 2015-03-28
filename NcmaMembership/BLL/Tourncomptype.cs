using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Tourncomptype
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 
		public  string Description { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_tourncomptypeInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_tourncomptypeInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_tourncomptypeUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_tourncomptypeUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_tourncomptypeUpdate");
		}

		public  List<Tourncomptype> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("tourncomptype");
			return TourncomptypeHelper.FromTableToList(tbl);
		}

		public  List<Tourncomptype> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("tourncomptype", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return TourncomptypeHelper.FromTableToList(tbl);
		}

		public  Tourncomptype GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "tourncomptype");
			return TourncomptypeHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class TourncomptypeHelper
	{
		internal static List<Tourncomptype> FromTableToList(DataTable tbl)
		{
			IList<Tourncomptype> data = tbl.AsEnumerable().Select(row =>
				new Tourncomptype
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
					Description = row.Field<string>("Description"),
				}).ToList();
			return (List<Tourncomptype>)data;
		}
	}
}
