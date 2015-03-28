using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NcmaMembership.DAL;
using System.Data;

namespace NcmaMembership.BLL
{
	public class  Aspnet_Membership
	{
		public   ApplicationId { get; set; } 
		public   UserId { get; set; } 
		public  string Password { get; set; } 
		public  int? PasswordFormat { get; set; } 
		public  string PasswordSalt { get; set; } 
		public  string MobilePIN { get; set; } 
		public  string Email { get; set; } 
		public  string LoweredEmail { get; set; } 
		public  string PasswordQuestion { get; set; } 
		public  string PasswordAnswer { get; set; } 
		public  bool? IsApproved { get; set; } 
		public  bool? IsLockedOut { get; set; } 
		public  DateTime? CreateDate { get; set; } 
		public  DateTime? LastLoginDate { get; set; } 
		public  DateTime? LastPasswordChangedDate { get; set; } 
		public  DateTime? LastLockoutDate { get; set; } 
		public  int? FailedPasswordAttemptCount { get; set; } 
		public  DateTime? FailedPasswordAttemptWindowStart { get; set; } 
		public  int? FailedPasswordAnswerAttemptCount { get; set; } 
		public  DateTime? FailedPasswordAnswerAttemptWindowStart { get; set; } 
		public  string Comment { get; set; } 

		public  bool Insert()
		{
			return DAL.DAL.InsertRecordIntoTable(this, "id", "sp_aspnet_MembershipInsert");
		}

		public  bool Insert( data)
		{
			return DAL.DAL.InsertRecordIntoTable(data, "id", "sp_aspnet_MembershipInsert");
		}

		public  bool Update()
		{
			return DAL.DAL.UpdateRecordInTable(this, "id", "sp_aspnet_MembershipUpdate");
		}

		public  bool Update( data)
		{
			return DAL.DAL.UpdateRecordInTable(data, "id", "sp_aspnet_MembershipUpdate");
		}

		public  bool Delete(int ID)
		{
			return DAL.DAL.DeleteRecordFromTableWithID(ID, "sp_aspnet_MembershipUpdate");
		}

		public  List<Aspnet_Membership> GetAll()
		{
			DataTable tbl = DAL.DAL.GetAllRecordsFromTable("aspnet_Membership");
			return Aspnet_MembershipHelper.FromTableToList(tbl);
		}

		public  List<Aspnet_Membership> GetPage(int pageSize, int index, List<string> fieldsToFilter,string filterTextToFind, string fieldToSort)
		{
			DataTable tbl = DAL.DAL.GetPagedRecordsFromTable("aspnet_Membership", "ID", pageSize, index, fieldToSort, fieldsToFilter, "contains", filterTextToFind );
			return Aspnet_MembershipHelper.FromTableToList(tbl);
		}

		public  Aspnet_Membership GetSingle(int ID)
		{
			DataTable tbl = DAL.DAL.GetRecordFromTableByID(ID, "aspnet_Membership");
			return Aspnet_MembershipHelper.FromTableToList(tbl).FirstOrDefault();
		}
}

	internal class Aspnet_MembershipHelper
	{
		internal static List<Aspnet_Membership> FromTableToList(DataTable tbl)
		{
			IList<Aspnet_Membership> data = tbl.AsEnumerable().Select(row =>
				new Aspnet_Membership
				{
					ApplicationId = row.Field<>("ApplicationId"),
					UserId = row.Field<>("UserId"),
					Password = row.Field<string>("Password"),
					PasswordFormat = row.Field<int?>("PasswordFormat"),
					PasswordSalt = row.Field<string>("PasswordSalt"),
					MobilePIN = row.Field<string>("MobilePIN"),
					Email = row.Field<string>("Email"),
					LoweredEmail = row.Field<string>("LoweredEmail"),
					PasswordQuestion = row.Field<string>("PasswordQuestion"),
					PasswordAnswer = row.Field<string>("PasswordAnswer"),
					IsApproved = row.Field<bool?>("IsApproved"),
					IsLockedOut = row.Field<bool?>("IsLockedOut"),
					CreateDate = row.Field<DateTime?>("CreateDate"),
					LastLoginDate = row.Field<DateTime?>("LastLoginDate"),
					LastPasswordChangedDate = row.Field<DateTime?>("LastPasswordChangedDate"),
					LastLockoutDate = row.Field<DateTime?>("LastLockoutDate"),
					FailedPasswordAttemptCount = row.Field<int?>("FailedPasswordAttemptCount"),
					FailedPasswordAttemptWindowStart = row.Field<DateTime?>("FailedPasswordAttemptWindowStart"),
					FailedPasswordAnswerAttemptCount = row.Field<int?>("FailedPasswordAnswerAttemptCount"),
					FailedPasswordAnswerAttemptWindowStart = row.Field<DateTime?>("FailedPasswordAnswerAttemptWindowStart"),
					Comment = row.Field<string>("Comment"),
				}).ToList();
			return (List<Aspnet_Membership>)data;
		}
	}
}
