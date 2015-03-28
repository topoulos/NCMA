using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Membertype
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_membertypeInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_membertypeInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_membertypeUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_membertypeUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_membertypeUpdate");
		}

		public  List<Membertype> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("membertype");
			return MembertypeHelper.FromTableToList(tbl);
		}

		public  List<Membertype> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("membertype", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return MembertypeHelper.FromTableToList(tbl);
		}

		public  Membertype GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "membertype");
			return MembertypeHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class MembertypeHelper
	{
		internal static List<Membertype> FromTableToList(DataTable tbl)
		{
			IList<Membertype> data = tbl.AsEnumerable().Select(row =>
				new Membertype
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
				}).ToList();
			return (List<Membertype>)data;
		}
	}
}
