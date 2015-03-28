using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Instructortype
	{
		public  int? ID { get; set; } 
		public  string InstructorTypeName { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_instructortypeInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_instructortypeInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_instructortypeUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_instructortypeUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_instructortypeUpdate");
		}

		public  List<Instructortype> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("instructortype");
			return InstructortypeHelper.FromTableToList(tbl);
		}

		public  List<Instructortype> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("instructortype", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return InstructortypeHelper.FromTableToList(tbl);
		}

		public  Instructortype GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "instructortype");
			return InstructortypeHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class InstructortypeHelper
	{
		internal static List<Instructortype> FromTableToList(DataTable tbl)
		{
			IList<Instructortype> data = tbl.AsEnumerable().Select(row =>
				new Instructortype
				{
					ID = row.Field<int?>("ID"),
					InstructorTypeName = row.Field<string>("InstructorTypeName"),
				}).ToList();
			return (List<Instructortype>)data;
		}
	}
}
