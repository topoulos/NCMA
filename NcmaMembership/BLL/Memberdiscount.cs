using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Memberdiscount
	{
		public  int? ID { get; set; } 
		public  int? MemberDiscountPercentage { get; set; } 
		public  int? MemberID { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_memberdiscountInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_memberdiscountInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_memberdiscountUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_memberdiscountUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_memberdiscountUpdate");
		}

		public  List<Memberdiscount> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("memberdiscount");
			return MemberdiscountHelper.FromTableToList(tbl);
		}

		public  List<Memberdiscount> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("memberdiscount", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return MemberdiscountHelper.FromTableToList(tbl);
		}

		public  Memberdiscount GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "memberdiscount");
			return MemberdiscountHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class MemberdiscountHelper
	{
		internal static List<Memberdiscount> FromTableToList(DataTable tbl)
		{
			IList<Memberdiscount> data = tbl.AsEnumerable().Select(row =>
				new Memberdiscount
				{
					ID = row.Field<int?>("ID"),
					MemberDiscountPercentage = row.Field<int?>("MemberDiscountPercentage"),
					MemberID = row.Field<int?>("MemberID"),
				}).ToList();
			return (List<Memberdiscount>)data;
		}
	}
}
