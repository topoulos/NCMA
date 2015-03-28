using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Paths
	{
		public   ApplicationId { get; set; } 
		public   PathId { get; set; } 
		public  string Path { get; set; } 
		public  string LoweredPath { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_PathsInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_PathsInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_PathsUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_PathsUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_PathsUpdate");
		}

		public  List<Aspnet_Paths> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_Paths");
			return Aspnet_PathsHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Paths> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_Paths", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_PathsHelper.FromTableToList(tbl);
		}

		public  Aspnet_Paths GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_Paths");
			return Aspnet_PathsHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_PathsHelper
	{
		internal static List<Aspnet_Paths> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Paths> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Paths
				{
					ApplicationId = row.Field<>("ApplicationId"),
					PathId = row.Field<>("PathId"),
					Path = row.Field<string>("Path"),
					LoweredPath = row.Field<string>("LoweredPath"),
				}).ToList();
			return (List<Aspnet_Paths>)data;
		}
	}
}
