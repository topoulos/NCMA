using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Dojoinstructor
	{
		public  int? ID { get; set; } 
		public  int? DojoID { get; set; } 
		public  int? InstructorID { get; set; } 
		public  int? InstructorTypeID { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_dojoinstructorInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_dojoinstructorInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_dojoinstructorUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_dojoinstructorUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_dojoinstructorUpdate");
		}

		public  List<Dojoinstructor> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("dojoinstructor");
			return DojoinstructorHelper.FromTableToList(tbl);
		}

		public  List<Dojoinstructor> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("dojoinstructor", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return DojoinstructorHelper.FromTableToList(tbl);
		}

		public  Dojoinstructor GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "dojoinstructor");
			return DojoinstructorHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class DojoinstructorHelper
	{
		internal static List<Dojoinstructor> FromTableToList(DataTable tbl)
		{
			IList<Dojoinstructor> data = tbl.AsEnumerable().Select(row =>
				new Dojoinstructor
				{
					ID = row.Field<int?>("ID"),
					DojoID = row.Field<int?>("DojoID"),
					InstructorID = row.Field<int?>("InstructorID"),
					InstructorTypeID = row.Field<int?>("InstructorTypeID"),
				}).ToList();
			return (List<Dojoinstructor>)data;
		}
	}
}
