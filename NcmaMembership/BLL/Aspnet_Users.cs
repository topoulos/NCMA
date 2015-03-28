using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Users
	{
		public   ApplicationId { get; set; } 
		public   UserId { get; set; } 
		public  string UserName { get; set; } 
		public  string LoweredUserName { get; set; } 
		public  string MobileAlias { get; set; } 
		public  bool? IsAnonymous { get; set; } 
		public  DateTime? LastActivityDate { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_UsersInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_UsersInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_UsersUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_UsersUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_UsersUpdate");
		}

		public  List<Aspnet_Users> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_Users");
			return Aspnet_UsersHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Users> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_Users", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_UsersHelper.FromTableToList(tbl);
		}

		public  Aspnet_Users GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_Users");
			return Aspnet_UsersHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_UsersHelper
	{
		internal static List<Aspnet_Users> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Users> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Users
				{
					ApplicationId = row.Field<>("ApplicationId"),
					UserId = row.Field<>("UserId"),
					UserName = row.Field<string>("UserName"),
					LoweredUserName = row.Field<string>("LoweredUserName"),
					MobileAlias = row.Field<string>("MobileAlias"),
					IsAnonymous = row.Field<bool?>("IsAnonymous"),
					LastActivityDate = row.Field<DateTime?>("LastActivityDate"),
				}).ToList();
			return (List<Aspnet_Users>)data;
		}
	}
}
