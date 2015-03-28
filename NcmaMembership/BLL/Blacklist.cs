using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Blacklist
	{
		public  int? ID { get; set; } 
		public  int? FormerMemberID { get; set; } 
		public  string FirstName { get; set; } 
		public  string LastName { get; set; } 
		public  string Reason { get; set; } 
		public  DateTime? DateListed { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_blacklistInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_blacklistInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_blacklistUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_blacklistUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_blacklistUpdate");
		}

		public  List<Blacklist> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("blacklist");
			return BlacklistHelper.FromTableToList(tbl);
		}

		public  List<Blacklist> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("blacklist", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return BlacklistHelper.FromTableToList(tbl);
		}

		public  Blacklist GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "blacklist");
			return BlacklistHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class BlacklistHelper
	{
		internal static List<Blacklist> FromTableToList(DataTable tbl)
		{
			IList<Blacklist> data = tbl.AsEnumerable().Select(row =>
				new Blacklist
				{
					ID = row.Field<int?>("ID"),
					FormerMemberID = row.Field<int?>("FormerMemberID"),
					FirstName = row.Field<string>("FirstName"),
					LastName = row.Field<string>("LastName"),
					Reason = row.Field<string>("Reason"),
					DateListed = row.Field<DateTime?>("DateListed"),
				}).ToList();
			return (List<Blacklist>)data;
		}
	}
}
