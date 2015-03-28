using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Applications
	{
		public  string ApplicationName { get; set; } 
		public  string LoweredApplicationName { get; set; } 
		public   ApplicationId { get; set; } 
		public  string Description { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_ApplicationsInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_ApplicationsInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_ApplicationsUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_ApplicationsUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_ApplicationsUpdate");
		}

		public  List<Aspnet_Applications> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_Applications");
			return Aspnet_ApplicationsHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Applications> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_Applications", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_ApplicationsHelper.FromTableToList(tbl);
		}

		public  Aspnet_Applications GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_Applications");
			return Aspnet_ApplicationsHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_ApplicationsHelper
	{
		internal static List<Aspnet_Applications> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Applications> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Applications
				{
					ApplicationName = row.Field<string>("ApplicationName"),
					LoweredApplicationName = row.Field<string>("LoweredApplicationName"),
					ApplicationId = row.Field<>("ApplicationId"),
					Description = row.Field<string>("Description"),
				}).ToList();
			return (List<Aspnet_Applications>)data;
		}
	}
}
