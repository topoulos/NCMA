using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Lineitem
	{
		public  int? ID { get; set; } 
		public  int? productid { get; set; } 
		public  int? qty { get; set; } 
		public  int? discount { get; set; } 
		public  int? memberid { get; set; } 
		public  DateTime? purchasedate { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_lineitemInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_lineitemInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_lineitemUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_lineitemUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_lineitemUpdate");
		}

		public  List<Lineitem> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("lineitem");
			return LineitemHelper.FromTableToList(tbl);
		}

		public  List<Lineitem> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("lineitem", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return LineitemHelper.FromTableToList(tbl);
		}

		public  Lineitem GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "lineitem");
			return LineitemHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class LineitemHelper
	{
		internal static List<Lineitem> FromTableToList(DataTable tbl)
		{
			IList<Lineitem> data = tbl.AsEnumerable().Select(row =>
				new Lineitem
				{
					ID = row.Field<int?>("ID"),
					productid = row.Field<int?>("productid"),
					qty = row.Field<int?>("qty"),
					discount = row.Field<int?>("discount"),
					memberid = row.Field<int?>("memberid"),
					purchasedate = row.Field<DateTime?>("purchasedate"),
				}).ToList();
			return (List<Lineitem>)data;
		}
	}
}
