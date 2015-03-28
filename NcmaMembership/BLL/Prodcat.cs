using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Prodcat
	{
		public  int? ID { get; set; } 
		public  string prodcatname { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_prodcatInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_prodcatInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_prodcatUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_prodcatUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_prodcatUpdate");
		}

		public  List<Prodcat> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("prodcat");
			return ProdcatHelper.FromTableToList(tbl);
		}

		public  List<Prodcat> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("prodcat", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return ProdcatHelper.FromTableToList(tbl);
		}

		public  Prodcat GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "prodcat");
			return ProdcatHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class ProdcatHelper
	{
		internal static List<Prodcat> FromTableToList(DataTable tbl)
		{
			IList<Prodcat> data = tbl.AsEnumerable().Select(row =>
				new Prodcat
				{
					ID = row.Field<int?>("ID"),
					prodcatname = row.Field<string>("prodcatname"),
				}).ToList();
			return (List<Prodcat>)data;
		}
	}
}
