using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Product
	{
		public  int? ID { get; set; } 
		public  string productname { get; set; } 
		public  int? categoryid { get; set; } 
		public  int? duration { get; set; } 
		public  Decimal? amount { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_productInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_productInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_productUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_productUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_productUpdate");
		}

		public  List<Product> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("product");
			return ProductHelper.FromTableToList(tbl);
		}

		public  List<Product> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("product", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return ProductHelper.FromTableToList(tbl);
		}

		public  Product GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "product");
			return ProductHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class ProductHelper
	{
		internal static List<Product> FromTableToList(DataTable tbl)
		{
			IList<Product> data = tbl.AsEnumerable().Select(row =>
				new Product
				{
					ID = row.Field<int?>("ID"),
					productname = row.Field<string>("productname"),
					categoryid = row.Field<int?>("categoryid"),
					duration = row.Field<int?>("duration"),
					amount = row.Field<Decimal?>("amount"),
				}).ToList();
			return (List<Product>)data;
		}
	}
}
