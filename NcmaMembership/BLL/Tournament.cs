using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Tournament
	{
		public  int? ID { get; set; } 
		public  string Address1 { get; set; } 
		public  string Address2 { get; set; } 
		public  string Address3 { get; set; } 
		public  string City { get; set; } 
		public  int? StateID { get; set; } 
		public  string PostalCode { get; set; } 
		public  DateTime? TournDate { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_tournamentInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_tournamentInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_tournamentUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_tournamentUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_tournamentUpdate");
		}

		public  List<Tournament> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("tournament");
			return TournamentHelper.FromTableToList(tbl);
		}

		public  List<Tournament> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("tournament", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return TournamentHelper.FromTableToList(tbl);
		}

		public  Tournament GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "tournament");
			return TournamentHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class TournamentHelper
	{
		internal static List<Tournament> FromTableToList(DataTable tbl)
		{
			IList<Tournament> data = tbl.AsEnumerable().Select(row =>
				new Tournament
				{
					ID = row.Field<int?>("ID"),
					Address1 = row.Field<string>("Address1"),
					Address2 = row.Field<string>("Address2"),
					Address3 = row.Field<string>("Address3"),
					City = row.Field<string>("City"),
					StateID = row.Field<int?>("StateID"),
					PostalCode = row.Field<string>("PostalCode"),
					TournDate = row.Field<DateTime?>("TournDate"),
				}).ToList();
			return (List<Tournament>)data;
		}
	}
}
