﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AccessControldb")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployeeData(EmployeeData instance);
    partial void UpdateEmployeeData(EmployeeData instance);
    partial void DeleteEmployeeData(EmployeeData instance);
    partial void InsertLogin(Login instance);
    partial void UpdateLogin(Login instance);
    partial void DeleteLogin(Login instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DataLayer.Properties.Settings.Default.AccessControldbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<EmployeeData> EmployeeDatas
		{
			get
			{
				return this.GetTable<EmployeeData>();
			}
		}
		
		public System.Data.Linq.Table<Login> Logins
		{
			get
			{
				return this.GetTable<Login>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeeData")]
	public partial class EmployeeData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _EmployeeId;
		
		private string _EmployeeName;
		
		private string _EmployeeAddress;
		
		private string _EmployeeEmail;
		
		private string _EmployeePhoneNumber;
		
		private string _EmployeeEntryTime;
		
		private string _EmployeeFinishTime;
		
		private EntityRef<EmployeeData> _EmployeeData2;
		
		private EntitySet<Login> _Logins;
		
		private EntityRef<EmployeeData> _EmployeeData1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIdChanging(string value);
    partial void OnEmployeeIdChanged();
    partial void OnEmployeeNameChanging(string value);
    partial void OnEmployeeNameChanged();
    partial void OnEmployeeAddressChanging(string value);
    partial void OnEmployeeAddressChanged();
    partial void OnEmployeeEmailChanging(string value);
    partial void OnEmployeeEmailChanged();
    partial void OnEmployeePhoneNumberChanging(string value);
    partial void OnEmployeePhoneNumberChanged();
    partial void OnEmployeeEntryTimeChanging(string value);
    partial void OnEmployeeEntryTimeChanged();
    partial void OnEmployeeFinishTimeChanging(string value);
    partial void OnEmployeeFinishTimeChanged();
    #endregion
		
		public EmployeeData()
		{
			this._EmployeeData2 = default(EntityRef<EmployeeData>);
			this._Logins = new EntitySet<Login>(new Action<Login>(this.attach_Logins), new Action<Login>(this.detach_Logins));
			this._EmployeeData1 = default(EntityRef<EmployeeData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._EmployeeData1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeName", DbType="NVarChar(50)")]
		public string EmployeeName
		{
			get
			{
				return this._EmployeeName;
			}
			set
			{
				if ((this._EmployeeName != value))
				{
					this.OnEmployeeNameChanging(value);
					this.SendPropertyChanging();
					this._EmployeeName = value;
					this.SendPropertyChanged("EmployeeName");
					this.OnEmployeeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeAddress", DbType="NVarChar(50)")]
		public string EmployeeAddress
		{
			get
			{
				return this._EmployeeAddress;
			}
			set
			{
				if ((this._EmployeeAddress != value))
				{
					this.OnEmployeeAddressChanging(value);
					this.SendPropertyChanging();
					this._EmployeeAddress = value;
					this.SendPropertyChanged("EmployeeAddress");
					this.OnEmployeeAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeEmail", DbType="NVarChar(50)")]
		public string EmployeeEmail
		{
			get
			{
				return this._EmployeeEmail;
			}
			set
			{
				if ((this._EmployeeEmail != value))
				{
					this.OnEmployeeEmailChanging(value);
					this.SendPropertyChanging();
					this._EmployeeEmail = value;
					this.SendPropertyChanged("EmployeeEmail");
					this.OnEmployeeEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeePhoneNumber", DbType="NVarChar(50)")]
		public string EmployeePhoneNumber
		{
			get
			{
				return this._EmployeePhoneNumber;
			}
			set
			{
				if ((this._EmployeePhoneNumber != value))
				{
					this.OnEmployeePhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._EmployeePhoneNumber = value;
					this.SendPropertyChanged("EmployeePhoneNumber");
					this.OnEmployeePhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeEntryTime", DbType="NVarChar(50)")]
		public string EmployeeEntryTime
		{
			get
			{
				return this._EmployeeEntryTime;
			}
			set
			{
				if ((this._EmployeeEntryTime != value))
				{
					this.OnEmployeeEntryTimeChanging(value);
					this.SendPropertyChanging();
					this._EmployeeEntryTime = value;
					this.SendPropertyChanged("EmployeeEntryTime");
					this.OnEmployeeEntryTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeFinishTime", DbType="NVarChar(50)")]
		public string EmployeeFinishTime
		{
			get
			{
				return this._EmployeeFinishTime;
			}
			set
			{
				if ((this._EmployeeFinishTime != value))
				{
					this.OnEmployeeFinishTimeChanging(value);
					this.SendPropertyChanging();
					this._EmployeeFinishTime = value;
					this.SendPropertyChanged("EmployeeFinishTime");
					this.OnEmployeeFinishTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EmployeeData_EmployeeData", Storage="_EmployeeData2", ThisKey="EmployeeId", OtherKey="EmployeeId", IsUnique=true, IsForeignKey=false)]
		public EmployeeData EmployeeData2
		{
			get
			{
				return this._EmployeeData2.Entity;
			}
			set
			{
				EmployeeData previousValue = this._EmployeeData2.Entity;
				if (((previousValue != value) 
							|| (this._EmployeeData2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EmployeeData2.Entity = null;
						previousValue.EmployeeData1 = null;
					}
					this._EmployeeData2.Entity = value;
					if ((value != null))
					{
						value.EmployeeData1 = this;
					}
					this.SendPropertyChanged("EmployeeData2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EmployeeData_Login", Storage="_Logins", ThisKey="EmployeeId", OtherKey="EmployeeId")]
		public EntitySet<Login> Logins
		{
			get
			{
				return this._Logins;
			}
			set
			{
				this._Logins.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EmployeeData_EmployeeData", Storage="_EmployeeData1", ThisKey="EmployeeId", OtherKey="EmployeeId", IsForeignKey=true)]
		public EmployeeData EmployeeData1
		{
			get
			{
				return this._EmployeeData1.Entity;
			}
			set
			{
				EmployeeData previousValue = this._EmployeeData1.Entity;
				if (((previousValue != value) 
							|| (this._EmployeeData1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EmployeeData1.Entity = null;
						previousValue.EmployeeData2 = null;
					}
					this._EmployeeData1.Entity = value;
					if ((value != null))
					{
						value.EmployeeData2 = this;
						this._EmployeeId = value.EmployeeId;
					}
					else
					{
						this._EmployeeId = default(string);
					}
					this.SendPropertyChanged("EmployeeData1");
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
		
		private void attach_Logins(Login entity)
		{
			this.SendPropertyChanging();
			entity.EmployeeData = this;
		}
		
		private void detach_Logins(Login entity)
		{
			this.SendPropertyChanging();
			entity.EmployeeData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Login")]
	public partial class Login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private string _Password;
		
		private string _EmployeeId;
		
		private EntityRef<EmployeeData> _EmployeeData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmployeeIdChanging(string value);
    partial void OnEmployeeIdChanged();
    #endregion
		
		public Login()
		{
			this._EmployeeData = default(EntityRef<EmployeeData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="NVarChar(50)")]
		public string EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._EmployeeData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EmployeeData_Login", Storage="_EmployeeData", ThisKey="EmployeeId", OtherKey="EmployeeId", IsForeignKey=true)]
		public EmployeeData EmployeeData
		{
			get
			{
				return this._EmployeeData.Entity;
			}
			set
			{
				EmployeeData previousValue = this._EmployeeData.Entity;
				if (((previousValue != value) 
							|| (this._EmployeeData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EmployeeData.Entity = null;
						previousValue.Logins.Remove(this);
					}
					this._EmployeeData.Entity = value;
					if ((value != null))
					{
						value.Logins.Add(this);
						this._EmployeeId = value.EmployeeId;
					}
					else
					{
						this._EmployeeId = default(string);
					}
					this.SendPropertyChanged("EmployeeData");
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
}
#pragma warning restore 1591