using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Country
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_countryInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_countryInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_countryUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_countryUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_countryUpdate");
		}

		public  List<Country> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("country");
			return CountryHelper.FromTableToList(tbl);
		}

		public  List<Country> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("country", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return CountryHelper.FromTableToList(tbl);
		}

		public  Country GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "country");
			return CountryHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class CountryHelper
	{
		internal static List<Country> FromTableToList(DataTable tbl)
		{
			IList<Country> data = tbl.AsEnumerable().Select(row =>
				new Country
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
				}).ToList();
			return (List<Country>)data;
		}
	}
}
