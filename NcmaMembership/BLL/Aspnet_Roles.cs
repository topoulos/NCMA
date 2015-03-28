using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Roles
	{
		public   ApplicationId { get; set; } 
		public   RoleId { get; set; } 
		public  string RoleName { get; set; } 
		public  string LoweredRoleName { get; set; } 
		public  string Description { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_RolesInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_RolesInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_RolesUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_RolesUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_RolesUpdate");
		}

		public  List<Aspnet_Roles> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_Roles");
			return Aspnet_RolesHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Roles> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_Roles", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_RolesHelper.FromTableToList(tbl);
		}

		public  Aspnet_Roles GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_Roles");
			return Aspnet_RolesHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_RolesHelper
	{
		internal static List<Aspnet_Roles> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Roles> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Roles
				{
					ApplicationId = row.Field<>("ApplicationId"),
					RoleId = row.Field<>("RoleId"),
					RoleName = row.Field<string>("RoleName"),
					LoweredRoleName = row.Field<string>("LoweredRoleName"),
					Description = row.Field<string>("Description"),
				}).ToList();
			return (List<Aspnet_Roles>)data;
		}
	}
}
