using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Payment
	{
		public  int? ID { get; set; } 
		public  DateTime? paymentdate { get; set; } 
		public  int? memberid { get; set; } 
		public  Decimal? paymentamount { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_paymentInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_paymentInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_paymentUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_paymentUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_paymentUpdate");
		}

		public  List<Payment> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("payment");
			return PaymentHelper.FromTableToList(tbl);
		}

		public  List<Payment> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("payment", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return PaymentHelper.FromTableToList(tbl);
		}

		public  Payment GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "payment");
			return PaymentHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class PaymentHelper
	{
		internal static List<Payment> FromTableToList(DataTable tbl)
		{
			IList<Payment> data = tbl.AsEnumerable().Select(row =>
				new Payment
				{
					ID = row.Field<int?>("ID"),
					paymentdate = row.Field<DateTime?>("paymentdate"),
					memberid = row.Field<int?>("memberid"),
					paymentamount = row.Field<Decimal?>("paymentamount"),
				}).ToList();
			return (List<Payment>)data;
		}
	}
}
