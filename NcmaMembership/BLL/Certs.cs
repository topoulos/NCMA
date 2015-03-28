using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Certs
	{
		public  int? ID { get; set; } 
		public  int? MemberID { get; set; } 
		public  int? InstructorID { get; set; } 
		public  int? CertTypeID { get; set; } 
		public  bool? Completed { get; set; } 
		public  int? MemberActivityID { get; set; } 
		public  DateTime? CertDate { get; set; } 
		public  DateTime? EndDate { get; set; } 
		public  int? TourneyID { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_certsInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_certsInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_certsUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_certsUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_certsUpdate");
		}

		public  List<Certs> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("certs");
			return CertsHelper.FromTableToList(tbl);
		}

		public  List<Certs> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("certs", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return CertsHelper.FromTableToList(tbl);
		}

		public  Certs GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "certs");
			return CertsHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class CertsHelper
	{
		internal static List<Certs> FromTableToList(DataTable tbl)
		{
			IList<Certs> data = tbl.AsEnumerable().Select(row =>
				new Certs
				{
					ID = row.Field<int?>("ID"),
					MemberID = row.Field<int?>("MemberID"),
					InstructorID = row.Field<int?>("InstructorID"),
					CertTypeID = row.Field<int?>("CertTypeID"),
					Completed = row.Field<bool?>("Completed"),
					MemberActivityID = row.Field<int?>("MemberActivityID"),
					CertDate = row.Field<DateTime?>("CertDate"),
					EndDate = row.Field<DateTime?>("EndDate"),
					TourneyID = row.Field<int?>("TourneyID"),
				}).ToList();
			return (List<Certs>)data;
		}
	}
}
