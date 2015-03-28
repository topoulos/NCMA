﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NcmaMembership
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_4170_ncma")]
	public partial class LargeSetsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmember(member instance);
    partial void Updatemember(member instance);
    partial void Deletemember(member instance);
    #endregion
		
		public LargeSetsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DB_4170_ncmaConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LargeSetsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LargeSetsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LargeSetsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LargeSetsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<member> members
		{
			get
			{
				return this.GetTable<member>();
			}
		}
		
		public System.Data.Linq.Table<vwMemberGridLookup> vwMemberGridLookups
		{
			get
			{
				return this.GetTable<vwMemberGridLookup>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.member")]
	public partial class member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _Suffix;
		
		private string _Address1;
		
		private string _Address2;
		
		private string _Address3;
		
		private string _City;
		
		private System.Nullable<int> _StateID;
		
		private System.Nullable<int> _CountryID;
		
		private string _PostalCode;
		
		private string _HomePhone;
		
		private string _CellPhone;
		
		private string _Email;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private System.Nullable<int> _PlanID;
		
		private System.Nullable<int> _DojoID;
		
		private System.Nullable<int> _MemberTypeID;
		
		private System.Nullable<System.DateTime> _DateJoined;
		
		private System.Nullable<System.DateTime> _DateOfRank;
		
		private string _RankText;
		
		private int _Active;
		
		private System.Nullable<System.DateTime> _DateInactive;
		
		private System.Nullable<System.DateTime> _DateLastPaid;
		
		private string _Comments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnMiddleNameChanging(string value);
    partial void OnMiddleNameChanged();
    partial void OnSuffixChanging(string value);
    partial void OnSuffixChanged();
    partial void OnAddress1Changing(string value);
    partial void OnAddress1Changed();
    partial void OnAddress2Changing(string value);
    partial void OnAddress2Changed();
    partial void OnAddress3Changing(string value);
    partial void OnAddress3Changed();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateIDChanging(System.Nullable<int> value);
    partial void OnStateIDChanged();
    partial void OnCountryIDChanging(System.Nullable<int> value);
    partial void OnCountryIDChanged();
    partial void OnPostalCodeChanging(string value);
    partial void OnPostalCodeChanged();
    partial void OnHomePhoneChanging(string value);
    partial void OnHomePhoneChanged();
    partial void OnCellPhoneChanging(string value);
    partial void OnCellPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnPlanIDChanging(System.Nullable<int> value);
    partial void OnPlanIDChanged();
    partial void OnDojoIDChanging(System.Nullable<int> value);
    partial void OnDojoIDChanged();
    partial void OnMemberTypeIDChanging(System.Nullable<int> value);
    partial void OnMemberTypeIDChanged();
    partial void OnDateJoinedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateJoinedChanged();
    partial void OnDateOfRankChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfRankChanged();
    partial void OnRankTextChanging(string value);
    partial void OnRankTextChanged();
    partial void OnActiveChanging(int value);
    partial void OnActiveChanged();
    partial void OnDateInactiveChanging(System.Nullable<System.DateTime> value);
    partial void OnDateInactiveChanged();
    partial void OnDateLastPaidChanging(System.Nullable<System.DateTime> value);
    partial void OnDateLastPaidChanged();
    partial void OnCommentsChanging(string value);
    partial void OnCommentsChanged();
    #endregion
		
		public member()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="VarChar(255)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this.OnMiddleNameChanging(value);
					this.SendPropertyChanging();
					this._MiddleName = value;
					this.SendPropertyChanged("MiddleName");
					this.OnMiddleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Suffix", DbType="VarChar(255)")]
		public string Suffix
		{
			get
			{
				return this._Suffix;
			}
			set
			{
				if ((this._Suffix != value))
				{
					this.OnSuffixChanging(value);
					this.SendPropertyChanging();
					this._Suffix = value;
					this.SendPropertyChanged("Suffix");
					this.OnSuffixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address1", DbType="VarChar(255)")]
		public string Address1
		{
			get
			{
				return this._Address1;
			}
			set
			{
				if ((this._Address1 != value))
				{
					this.OnAddress1Changing(value);
					this.SendPropertyChanging();
					this._Address1 = value;
					this.SendPropertyChanged("Address1");
					this.OnAddress1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address2", DbType="VarChar(255)")]
		public string Address2
		{
			get
			{
				return this._Address2;
			}
			set
			{
				if ((this._Address2 != value))
				{
					this.OnAddress2Changing(value);
					this.SendPropertyChanging();
					this._Address2 = value;
					this.SendPropertyChanged("Address2");
					this.OnAddress2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address3", DbType="VarChar(255)")]
		public string Address3
		{
			get
			{
				return this._Address3;
			}
			set
			{
				if ((this._Address3 != value))
				{
					this.OnAddress3Changing(value);
					this.SendPropertyChanging();
					this._Address3 = value;
					this.SendPropertyChanged("Address3");
					this.OnAddress3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(255)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateID", DbType="Int")]
		public System.Nullable<int> StateID
		{
			get
			{
				return this._StateID;
			}
			set
			{
				if ((this._StateID != value))
				{
					this.OnStateIDChanging(value);
					this.SendPropertyChanging();
					this._StateID = value;
					this.SendPropertyChanged("StateID");
					this.OnStateIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryID", DbType="Int")]
		public System.Nullable<int> CountryID
		{
			get
			{
				return this._CountryID;
			}
			set
			{
				if ((this._CountryID != value))
				{
					this.OnCountryIDChanging(value);
					this.SendPropertyChanging();
					this._CountryID = value;
					this.SendPropertyChanged("CountryID");
					this.OnCountryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="VarChar(12)")]
		public string PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this.OnPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._PostalCode = value;
					this.SendPropertyChanged("PostalCode");
					this.OnPostalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HomePhone", DbType="VarChar(20)")]
		public string HomePhone
		{
			get
			{
				return this._HomePhone;
			}
			set
			{
				if ((this._HomePhone != value))
				{
					this.OnHomePhoneChanging(value);
					this.SendPropertyChanging();
					this._HomePhone = value;
					this.SendPropertyChanged("HomePhone");
					this.OnHomePhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CellPhone", DbType="VarChar(20)")]
		public string CellPhone
		{
			get
			{
				return this._CellPhone;
			}
			set
			{
				if ((this._CellPhone != value))
				{
					this.OnCellPhoneChanging(value);
					this.SendPropertyChanging();
					this._CellPhone = value;
					this.SendPropertyChanged("CellPhone");
					this.OnCellPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(255)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlanID", DbType="Int")]
		public System.Nullable<int> PlanID
		{
			get
			{
				return this._PlanID;
			}
			set
			{
				if ((this._PlanID != value))
				{
					this.OnPlanIDChanging(value);
					this.SendPropertyChanging();
					this._PlanID = value;
					this.SendPropertyChanged("PlanID");
					this.OnPlanIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DojoID", DbType="Int")]
		public System.Nullable<int> DojoID
		{
			get
			{
				return this._DojoID;
			}
			set
			{
				if ((this._DojoID != value))
				{
					this.OnDojoIDChanging(value);
					this.SendPropertyChanging();
					this._DojoID = value;
					this.SendPropertyChanged("DojoID");
					this.OnDojoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemberTypeID", DbType="Int")]
		public System.Nullable<int> MemberTypeID
		{
			get
			{
				return this._MemberTypeID;
			}
			set
			{
				if ((this._MemberTypeID != value))
				{
					this.OnMemberTypeIDChanging(value);
					this.SendPropertyChanging();
					this._MemberTypeID = value;
					this.SendPropertyChanged("MemberTypeID");
					this.OnMemberTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateJoined", DbType="Date")]
		public System.Nullable<System.DateTime> DateJoined
		{
			get
			{
				return this._DateJoined;
			}
			set
			{
				if ((this._DateJoined != value))
				{
					this.OnDateJoinedChanging(value);
					this.SendPropertyChanging();
					this._DateJoined = value;
					this.SendPropertyChanged("DateJoined");
					this.OnDateJoinedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfRank", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfRank
		{
			get
			{
				return this._DateOfRank;
			}
			set
			{
				if ((this._DateOfRank != value))
				{
					this.OnDateOfRankChanging(value);
					this.SendPropertyChanging();
					this._DateOfRank = value;
					this.SendPropertyChanged("DateOfRank");
					this.OnDateOfRankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RankText", DbType="VarChar(500)")]
		public string RankText
		{
			get
			{
				return this._RankText;
			}
			set
			{
				if ((this._RankText != value))
				{
					this.OnRankTextChanging(value);
					this.SendPropertyChanging();
					this._RankText = value;
					this.SendPropertyChanged("RankText");
					this.OnRankTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Int NOT NULL")]
		public int Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateInactive", DbType="Date")]
		public System.Nullable<System.DateTime> DateInactive
		{
			get
			{
				return this._DateInactive;
			}
			set
			{
				if ((this._DateInactive != value))
				{
					this.OnDateInactiveChanging(value);
					this.SendPropertyChanging();
					this._DateInactive = value;
					this.SendPropertyChanged("DateInactive");
					this.OnDateInactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateLastPaid", DbType="Date")]
		public System.Nullable<System.DateTime> DateLastPaid
		{
			get
			{
				return this._DateLastPaid;
			}
			set
			{
				if ((this._DateLastPaid != value))
				{
					this.OnDateLastPaidChanging(value);
					this.SendPropertyChanging();
					this._DateLastPaid = value;
					this.SendPropertyChanged("DateLastPaid");
					this.OnDateLastPaidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comments", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Comments
		{
			get
			{
				return this._Comments;
			}
			set
			{
				if ((this._Comments != value))
				{
					this.OnCommentsChanging(value);
					this.SendPropertyChanging();
					this._Comments = value;
					this.SendPropertyChanged("Comments");
					this.OnCommentsChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vwMemberGridLookup")]
	public partial class vwMemberGridLookup
	{
		
		private string _FullName;
		
		private string _Last;
		
		private string _First;
		
		private string _Country;
		
		private string _Dojo;
		
		private string _MemType;
		
		private string _State;
		
		private System.Nullable<System.DateTime> _DateJoined;
		
		private System.Nullable<System.DateTime> _DateOfRank;
		
		private int _Active;
		
		private System.Nullable<System.DateTime> _DateLastPaid;
		
		private int _ID;
		
		private string _RankText;
		
		public vwMemberGridLookup()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(1023) NOT NULL", CanBeNull=false)]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last", DbType="VarChar(255)")]
		public string Last
		{
			get
			{
				return this._Last;
			}
			set
			{
				if ((this._Last != value))
				{
					this._Last = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First", DbType="VarChar(255)")]
		public string First
		{
			get
			{
				return this._First;
			}
			set
			{
				if ((this._First != value))
				{
					this._First = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="VarChar(255)")]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this._Country = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dojo", DbType="VarChar(255)")]
		public string Dojo
		{
			get
			{
				return this._Dojo;
			}
			set
			{
				if ((this._Dojo != value))
				{
					this._Dojo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MemType", DbType="VarChar(255)")]
		public string MemType
		{
			get
			{
				return this._MemType;
			}
			set
			{
				if ((this._MemType != value))
				{
					this._MemType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(2)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this._State = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateJoined", DbType="Date")]
		public System.Nullable<System.DateTime> DateJoined
		{
			get
			{
				return this._DateJoined;
			}
			set
			{
				if ((this._DateJoined != value))
				{
					this._DateJoined = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfRank", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfRank
		{
			get
			{
				return this._DateOfRank;
			}
			set
			{
				if ((this._DateOfRank != value))
				{
					this._DateOfRank = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Int NOT NULL")]
		public int Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateLastPaid", DbType="Date")]
		public System.Nullable<System.DateTime> DateLastPaid
		{
			get
			{
				return this._DateLastPaid;
			}
			set
			{
				if ((this._DateLastPaid != value))
				{
					this._DateLastPaid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RankText", DbType="VarChar(500)")]
		public string RankText
		{
			get
			{
				return this._RankText;
			}
			set
			{
				if ((this._RankText != value))
				{
					this._RankText = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
