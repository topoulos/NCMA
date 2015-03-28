using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Schemaversions
	{
		public  string Feature { get; set; } 
		public  string CompatibleSchemaVersion { get; set; } 
		public  bool? IsCurrentVersion { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_SchemaVersionsInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_SchemaVersionsInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_SchemaVersionsUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_SchemaVersionsUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_SchemaVersionsUpdate");
		}

		public  List<Aspnet_Schemaversions> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_SchemaVersions");
			return Aspnet_SchemaversionsHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Schemaversions> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_SchemaVersions", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_SchemaversionsHelper.FromTableToList(tbl);
		}

		public  Aspnet_Schemaversions GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_SchemaVersions");
			return Aspnet_SchemaversionsHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_SchemaversionsHelper
	{
		internal static List<Aspnet_Schemaversions> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Schemaversions> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Schemaversions
				{
					Feature = row.Field<string>("Feature"),
					CompatibleSchemaVersion = row.Field<string>("CompatibleSchemaVersion"),
					IsCurrentVersion = row.Field<bool?>("IsCurrentVersion"),
				}).ToList();
			return (List<Aspnet_Schemaversions>)data;
		}
	}
}
