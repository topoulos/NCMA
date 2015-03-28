using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Tournresult
	{
		public  int? ID { get; set; } 
		public  int? TournamentID { get; set; } 
		public  int? MemberID { get; set; } 
		public  int? TournAcheivementTypeID { get; set; } 
		public  int? TournDivisionID { get; set; } 
		public  int? TournCompTypeID { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_tournresultInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_tournresultInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_tournresultUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_tournresultUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_tournresultUpdate");
		}

		public  List<Tournresult> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("tournresult");
			return TournresultHelper.FromTableToList(tbl);
		}

		public  List<Tournresult> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("tournresult", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return TournresultHelper.FromTableToList(tbl);
		}

		public  Tournresult GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "tournresult");
			return TournresultHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class TournresultHelper
	{
		internal static List<Tournresult> FromTableToList(DataTable tbl)
		{
			IList<Tournresult> data = tbl.AsEnumerable().Select(row =>
				new Tournresult
				{
					ID = row.Field<int?>("ID"),
					TournamentID = row.Field<int?>("TournamentID"),
					MemberID = row.Field<int?>("MemberID"),
					TournAcheivementTypeID = row.Field<int?>("TournAcheivementTypeID"),
					TournDivisionID = row.Field<int?>("TournDivisionID"),
					TournCompTypeID = row.Field<int?>("TournCompTypeID"),
				}).ToList();
			return (List<Tournresult>)data;
		}
	}
}
