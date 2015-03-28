using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Rank
	{
		public  int? ID { get; set; } 
		public  string Name { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_rankInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_rankInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_rankUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_rankUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_rankUpdate");
		}

		public  List<Rank> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("rank");
			return RankHelper.FromTableToList(tbl);
		}

		public  List<Rank> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("rank", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return RankHelper.FromTableToList(tbl);
		}

		public  Rank GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "rank");
			return RankHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class RankHelper
	{
		internal static List<Rank> FromTableToList(DataTable tbl)
		{
			IList<Rank> data = tbl.AsEnumerable().Select(row =>
				new Rank
				{
					ID = row.Field<int?>("ID"),
					Name = row.Field<string>("Name"),
				}).ToList();
			return (List<Rank>)data;
		}
	}
}
