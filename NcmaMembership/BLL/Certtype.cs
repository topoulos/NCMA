using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Certtype
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 
		public  string Description { get; set; } 
		public  int? ValidationDurationInDays { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_certtypeInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_certtypeInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_certtypeUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_certtypeUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_certtypeUpdate");
		}

		public  List<Certtype> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("certtype");
			return CerttypeHelper.FromTableToList(tbl);
		}

		public  List<Certtype> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("certtype", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return CerttypeHelper.FromTableToList(tbl);
		}

		public  Certtype GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "certtype");
			return CerttypeHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class CerttypeHelper
	{
		internal static List<Certtype> FromTableToList(DataTable tbl)
		{
			IList<Certtype> data = tbl.AsEnumerable().Select(row =>
				new Certtype
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
					Description = row.Field<string>("Description"),
					ValidationDurationInDays = row.Field<int?>("ValidationDurationInDays"),
				}).ToList();
			return (List<Certtype>)data;
		}
	}
}
