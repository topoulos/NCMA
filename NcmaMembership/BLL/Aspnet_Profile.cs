using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Profile
	{
		public   UserId { get; set; } 
		public  string PropertyNames { get; set; } 
		public  string PropertyValuesString { get; set; } 
		public   PropertyValuesBinary { get; set; } 
		public  DateTime? LastUpdatedDate { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_ProfileInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_ProfileInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_ProfileUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_ProfileUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_ProfileUpdate");
		}

		public  List<Aspnet_Profile> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_Profile");
			return Aspnet_ProfileHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Profile> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_Profile", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_ProfileHelper.FromTableToList(tbl);
		}

		public  Aspnet_Profile GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_Profile");
			return Aspnet_ProfileHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_ProfileHelper
	{
		internal static List<Aspnet_Profile> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Profile> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Profile
				{
					UserId = row.Field<>("UserId"),
					PropertyNames = row.Field<string>("PropertyNames"),
					PropertyValuesString = row.Field<string>("PropertyValuesString"),
					PropertyValuesBinary = row.Field<>("PropertyValuesBinary"),
					LastUpdatedDate = row.Field<DateTime?>("LastUpdatedDate"),
				}).ToList();
			return (List<Aspnet_Profile>)data;
		}
	}
}
