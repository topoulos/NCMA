using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Tourndivision
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 
		public  string Description { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_tourndivisionInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_tourndivisionInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_tourndivisionUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_tourndivisionUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_tourndivisionUpdate");
		}

		public  List<Tourndivision> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("tourndivision");
			return TourndivisionHelper.FromTableToList(tbl);
		}

		public  List<Tourndivision> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("tourndivision", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return TourndivisionHelper.FromTableToList(tbl);
		}

		public  Tourndivision GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "tourndivision");
			return TourndivisionHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class TourndivisionHelper
	{
		internal static List<Tourndivision> FromTableToList(DataTable tbl)
		{
			IList<Tourndivision> data = tbl.AsEnumerable().Select(row =>
				new Tourndivision
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
					Description = row.Field<string>("Description"),
				}).ToList();
			return (List<Tourndivision>)data;
		}
	}
}
