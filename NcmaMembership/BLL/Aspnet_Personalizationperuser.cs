using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Personalizationperuser
	{
		public   Id { get; set; } 
		public   PathId { get; set; } 
		public   UserId { get; set; } 
		public   PageSettings { get; set; } 
		public  DateTime? LastUpdatedDate { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_PersonalizationPerUserInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_PersonalizationPerUserInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_PersonalizationPerUserUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_PersonalizationPerUserUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_PersonalizationPerUserUpdate");
		}

		public  List<Aspnet_Personalizationperuser> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_PersonalizationPerUser");
			return Aspnet_PersonalizationperuserHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Personalizationperuser> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_PersonalizationPerUser", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_PersonalizationperuserHelper.FromTableToList(tbl);
		}

		public  Aspnet_Personalizationperuser GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_PersonalizationPerUser");
			return Aspnet_PersonalizationperuserHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_PersonalizationperuserHelper
	{
		internal static List<Aspnet_Personalizationperuser> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Personalizationperuser> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Personalizationperuser
				{
					Id = row.Field<>("Id"),
					PathId = row.Field<>("PathId"),
					UserId = row.Field<>("UserId"),
					PageSettings = row.Field<>("PageSettings"),
					LastUpdatedDate = row.Field<DateTime?>("LastUpdatedDate"),
				}).ToList();
			return (List<Aspnet_Personalizationperuser>)data;
		}
	}
}
