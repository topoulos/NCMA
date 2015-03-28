using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Webevent_Events
	{
		public  string EventId { get; set; } 
		public  DateTime? EventTimeUtc { get; set; } 
		public  DateTime? EventTime { get; set; } 
		public  string EventType { get; set; } 
		public  Decimal? EventSequence { get; set; } 
		public  Decimal? EventOccurrence { get; set; } 
		public  int? EventCode { get; set; } 
		public  int? EventDetailCode { get; set; } 
		public  string Message { get; set; } 
		public  string ApplicationPath { get; set; } 
		public  string ApplicationVirtualPath { get; set; } 
		public  string MachineName { get; set; } 
		public  string RequestUrl { get; set; } 
		public  string ExceptionType { get; set; } 
		public  string Details { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_WebEvent_EventsInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_WebEvent_EventsInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_WebEvent_EventsUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_WebEvent_EventsUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_WebEvent_EventsUpdate");
		}

		public  List<Aspnet_Webevent_Events> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_WebEvent_Events");
			return Aspnet_Webevent_EventsHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Webevent_Events> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_WebEvent_Events", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_Webevent_EventsHelper.FromTableToList(tbl);
		}

		public  Aspnet_Webevent_Events GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_WebEvent_Events");
			return Aspnet_Webevent_EventsHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_Webevent_EventsHelper
	{
		internal static List<Aspnet_Webevent_Events> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Webevent_Events> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Webevent_Events
				{
					EventId = row.Field<string>("EventId"),
					EventTimeUtc = row.Field<DateTime?>("EventTimeUtc"),
					EventTime = row.Field<DateTime?>("EventTime"),
					EventType = row.Field<string>("EventType"),
					EventSequence = row.Field<Decimal?>("EventSequence"),
					EventOccurrence = row.Field<Decimal?>("EventOccurrence"),
					EventCode = row.Field<int?>("EventCode"),
					EventDetailCode = row.Field<int?>("EventDetailCode"),
					Message = row.Field<string>("Message"),
					ApplicationPath = row.Field<string>("ApplicationPath"),
					ApplicationVirtualPath = row.Field<string>("ApplicationVirtualPath"),
					MachineName = row.Field<string>("MachineName"),
					RequestUrl = row.Field<string>("RequestUrl"),
					ExceptionType = row.Field<string>("ExceptionType"),
					Details = row.Field<string>("Details"),
				}).ToList();
			return (List<Aspnet_Webevent_Events>)data;
		}
	}
}
