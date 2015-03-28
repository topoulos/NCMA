using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Dojo
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 
		public  string Style { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_dojoInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_dojoInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_dojoUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_dojoUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_dojoUpdate");
		}

		public  List<Dojo> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("dojo");
			return DojoHelper.FromTableToList(tbl);
		}

		public  List<Dojo> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("dojo", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return DojoHelper.FromTableToList(tbl);
		}

		public  Dojo GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "dojo");
			return DojoHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class DojoHelper
	{
		internal static List<Dojo> FromTableToList(DataTable tbl)
		{
			IList<Dojo> data = tbl.AsEnumerable().Select(row =>
				new Dojo
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
					Style = row.Field<string>("Style"),
				}).ToList();
			return (List<Dojo>)data;
		}
	}
}
