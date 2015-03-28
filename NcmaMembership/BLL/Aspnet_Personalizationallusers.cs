using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Personalizationallusers
	{
		public   PathId { get; set; } 
		public   PageSettings { get; set; } 
		public  DateTime? LastUpdatedDate { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_PersonalizationAllUsersInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_PersonalizationAllUsersInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_PersonalizationAllUsersUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_PersonalizationAllUsersUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_PersonalizationAllUsersUpdate");
		}

		public  List<Aspnet_Personalizationallusers> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_PersonalizationAllUsers");
			return Aspnet_PersonalizationallusersHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Personalizationallusers> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_PersonalizationAllUsers", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_PersonalizationallusersHelper.FromTableToList(tbl);
		}

		public  Aspnet_Personalizationallusers GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_PersonalizationAllUsers");
			return Aspnet_PersonalizationallusersHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_PersonalizationallusersHelper
	{
		internal static List<Aspnet_Personalizationallusers> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Personalizationallusers> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Personalizationallusers
				{
					PathId = row.Field<>("PathId"),
					PageSettings = row.Field<>("PageSettings"),
					LastUpdatedDate = row.Field<DateTime?>("LastUpdatedDate"),
				}).ToList();
			return (List<Aspnet_Personalizationallusers>)data;
		}
	}
}
