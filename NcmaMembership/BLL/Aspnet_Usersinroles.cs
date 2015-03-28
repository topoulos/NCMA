using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Usersinroles
	{
		public   UserId { get; set; } 
		public   RoleId { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_UsersInRolesInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_UsersInRolesInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_UsersInRolesUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_UsersInRolesUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_UsersInRolesUpdate");
		}

		public  List<Aspnet_Usersinroles> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_UsersInRoles");
			return Aspnet_UsersinrolesHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Usersinroles> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_UsersInRoles", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_UsersinrolesHelper.FromTableToList(tbl);
		}

		public  Aspnet_Usersinroles GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_UsersInRoles");
			return Aspnet_UsersinrolesHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_UsersinrolesHelper
	{
		internal static List<Aspnet_Usersinroles> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Usersinroles> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Usersinroles
				{
					UserId = row.Field<>("UserId"),
					RoleId = row.Field<>("RoleId"),
				}).ToList();
			return (List<Aspnet_Usersinroles>)data;
		}
	}
}
