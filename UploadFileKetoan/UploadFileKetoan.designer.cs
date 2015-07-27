﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UploadFileKetoan
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UploadFileKetoan")]
	public partial class UploadFileKetoanDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUserType(UserType instance);
    partial void UpdateUserType(UserType instance);
    partial void DeleteUserType(UserType instance);
    partial void InsertFile(File instance);
    partial void UpdateFile(File instance);
    partial void DeleteFile(File instance);
    partial void InsertCongty(Congty instance);
    partial void UpdateCongty(Congty instance);
    partial void DeleteCongty(Congty instance);
    partial void InsertUpload(Upload instance);
    partial void UpdateUpload(Upload instance);
    partial void DeleteUpload(Upload instance);
    #endregion
		
		public UploadFileKetoanDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["UploadFileKetoanConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UploadFileKetoanDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UploadFileKetoanDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UploadFileKetoanDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UploadFileKetoanDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserType> UserTypes
		{
			get
			{
				return this.GetTable<UserType>();
			}
		}
		
		public System.Data.Linq.Table<File> Files
		{
			get
			{
				return this.GetTable<File>();
			}
		}
		
		public System.Data.Linq.Table<Congty> Congties
		{
			get
			{
				return this.GetTable<Congty>();
			}
		}
		
		public System.Data.Linq.Table<Upload> Uploads
		{
			get
			{
				return this.GetTable<Upload>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Username;
		
		private string _Password;
		
		private string _Saft;
		
		private System.Nullable<bool> _IsActive;
		
		private System.Nullable<int> _UserTypeID;
		
		private string _Fullname;
		
		private string _Phone;
		
		private string _Address;
		
		private EntityRef<UserType> _UserType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnSaftChanging(string value);
    partial void OnSaftChanged();
    partial void OnIsActiveChanging(System.Nullable<bool> value);
    partial void OnIsActiveChanged();
    partial void OnUserTypeIDChanging(System.Nullable<int> value);
    partial void OnUserTypeIDChanged();
    partial void OnFullnameChanging(string value);
    partial void OnFullnameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
		
		public User()
		{
			this._UserType = default(EntityRef<UserType>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Saft", DbType="VarChar(250)")]
		public string Saft
		{
			get
			{
				return this._Saft;
			}
			set
			{
				if ((this._Saft != value))
				{
					this.OnSaftChanging(value);
					this.SendPropertyChanging();
					this._Saft = value;
					this.SendPropertyChanged("Saft");
					this.OnSaftChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserTypeID", DbType="Int")]
		public System.Nullable<int> UserTypeID
		{
			get
			{
				return this._UserTypeID;
			}
			set
			{
				if ((this._UserTypeID != value))
				{
					if (this._UserType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserTypeIDChanging(value);
					this.SendPropertyChanging();
					this._UserTypeID = value;
					this.SendPropertyChanged("UserTypeID");
					this.OnUserTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fullname", DbType="NVarChar(250)")]
		public string Fullname
		{
			get
			{
				return this._Fullname;
			}
			set
			{
				if ((this._Fullname != value))
				{
					this.OnFullnameChanging(value);
					this.SendPropertyChanging();
					this._Fullname = value;
					this.SendPropertyChanged("Fullname");
					this.OnFullnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(15)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(550)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserType_User", Storage="_UserType", ThisKey="UserTypeID", OtherKey="ID", IsForeignKey=true, DeleteRule="CASCADE")]
		public UserType UserType
		{
			get
			{
				return this._UserType.Entity;
			}
			set
			{
				UserType previousValue = this._UserType.Entity;
				if (((previousValue != value) 
							|| (this._UserType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._UserType.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._UserType.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._UserTypeID = value.ID;
					}
					else
					{
						this._UserTypeID = default(Nullable<int>);
					}
					this.SendPropertyChanged("UserType");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserType")]
	public partial class UserType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Code;
		
		private string _Name;
		
		private System.Nullable<int> _Pos;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPosChanging(System.Nullable<int> value);
    partial void OnPosChanged();
    #endregion
		
		public UserType()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(550) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pos", DbType="Int")]
		public System.Nullable<int> Pos
		{
			get
			{
				return this._Pos;
			}
			set
			{
				if ((this._Pos != value))
				{
					this.OnPosChanging(value);
					this.SendPropertyChanging();
					this._Pos = value;
					this.SendPropertyChanged("Pos");
					this.OnPosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="UserType_User", Storage="_Users", ThisKey="ID", OtherKey="UserTypeID")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.UserType = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.UserType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[File]")]
	public partial class File : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _UploadID;
		
		private string _Filename;
		
		private EntityRef<Upload> _Upload;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUploadIDChanging(int value);
    partial void OnUploadIDChanged();
    partial void OnFilenameChanging(string value);
    partial void OnFilenameChanged();
    #endregion
		
		public File()
		{
			this._Upload = default(EntityRef<Upload>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UploadID", DbType="Int NOT NULL")]
		public int UploadID
		{
			get
			{
				return this._UploadID;
			}
			set
			{
				if ((this._UploadID != value))
				{
					if (this._Upload.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUploadIDChanging(value);
					this.SendPropertyChanging();
					this._UploadID = value;
					this.SendPropertyChanged("UploadID");
					this.OnUploadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Filename", DbType="NVarChar(550)")]
		public string Filename
		{
			get
			{
				return this._Filename;
			}
			set
			{
				if ((this._Filename != value))
				{
					this.OnFilenameChanging(value);
					this.SendPropertyChanging();
					this._Filename = value;
					this.SendPropertyChanged("Filename");
					this.OnFilenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Upload_File", Storage="_Upload", ThisKey="UploadID", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Upload Upload
		{
			get
			{
				return this._Upload.Entity;
			}
			set
			{
				Upload previousValue = this._Upload.Entity;
				if (((previousValue != value) 
							|| (this._Upload.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Upload.Entity = null;
						previousValue.Files.Remove(this);
					}
					this._Upload.Entity = value;
					if ((value != null))
					{
						value.Files.Add(this);
						this._UploadID = value.ID;
					}
					else
					{
						this._UploadID = default(int);
					}
					this.SendPropertyChanged("Upload");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Congty")]
	public partial class Congty : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MASOTHUE;
		
		private string _TENCONGTY;
		
		private string _DIACHI;
		
		private System.Nullable<System.DateTime> _NGAYTAO;
		
		private System.Nullable<int> _UserID;
		
		private EntitySet<Upload> _Uploads;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMASOTHUEChanging(string value);
    partial void OnMASOTHUEChanged();
    partial void OnTENCONGTYChanging(string value);
    partial void OnTENCONGTYChanged();
    partial void OnDIACHIChanging(string value);
    partial void OnDIACHIChanged();
    partial void OnNGAYTAOChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYTAOChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    #endregion
		
		public Congty()
		{
			this._Uploads = new EntitySet<Upload>(new Action<Upload>(this.attach_Uploads), new Action<Upload>(this.detach_Uploads));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MASOTHUE", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string MASOTHUE
		{
			get
			{
				return this._MASOTHUE;
			}
			set
			{
				if ((this._MASOTHUE != value))
				{
					this.OnMASOTHUEChanging(value);
					this.SendPropertyChanging();
					this._MASOTHUE = value;
					this.SendPropertyChanged("MASOTHUE");
					this.OnMASOTHUEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENCONGTY", DbType="NVarChar(250)")]
		public string TENCONGTY
		{
			get
			{
				return this._TENCONGTY;
			}
			set
			{
				if ((this._TENCONGTY != value))
				{
					this.OnTENCONGTYChanging(value);
					this.SendPropertyChanging();
					this._TENCONGTY = value;
					this.SendPropertyChanged("TENCONGTY");
					this.OnTENCONGTYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DIACHI", DbType="NVarChar(550)")]
		public string DIACHI
		{
			get
			{
				return this._DIACHI;
			}
			set
			{
				if ((this._DIACHI != value))
				{
					this.OnDIACHIChanging(value);
					this.SendPropertyChanging();
					this._DIACHI = value;
					this.SendPropertyChanged("DIACHI");
					this.OnDIACHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYTAO", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> NGAYTAO
		{
			get
			{
				return this._NGAYTAO;
			}
			set
			{
				if ((this._NGAYTAO != value))
				{
					this.OnNGAYTAOChanging(value);
					this.SendPropertyChanging();
					this._NGAYTAO = value;
					this.SendPropertyChanged("NGAYTAO");
					this.OnNGAYTAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Congty_Upload", Storage="_Uploads", ThisKey="ID", OtherKey="CongtyID")]
		public EntitySet<Upload> Uploads
		{
			get
			{
				return this._Uploads;
			}
			set
			{
				this._Uploads.Assign(value);
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
		
		private void attach_Uploads(Upload entity)
		{
			this.SendPropertyChanging();
			entity.Congty = this;
		}
		
		private void detach_Uploads(Upload entity)
		{
			this.SendPropertyChanging();
			entity.Congty = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Upload")]
	public partial class Upload : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _CongtyID;
		
		private System.Nullable<int> _NAM;
		
		private System.Nullable<int> _KY;
		
		private System.Nullable<System.DateTime> _NGAYTAO;
		
		private System.Nullable<int> _UserID;
		
		private EntitySet<File> _Files;
		
		private EntityRef<Congty> _Congty;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCongtyIDChanging(int value);
    partial void OnCongtyIDChanged();
    partial void OnNAMChanging(System.Nullable<int> value);
    partial void OnNAMChanged();
    partial void OnKYChanging(System.Nullable<int> value);
    partial void OnKYChanged();
    partial void OnNGAYTAOChanging(System.Nullable<System.DateTime> value);
    partial void OnNGAYTAOChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    #endregion
		
		public Upload()
		{
			this._Files = new EntitySet<File>(new Action<File>(this.attach_Files), new Action<File>(this.detach_Files));
			this._Congty = default(EntityRef<Congty>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongtyID", DbType="Int NOT NULL")]
		public int CongtyID
		{
			get
			{
				return this._CongtyID;
			}
			set
			{
				if ((this._CongtyID != value))
				{
					if (this._Congty.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCongtyIDChanging(value);
					this.SendPropertyChanging();
					this._CongtyID = value;
					this.SendPropertyChanged("CongtyID");
					this.OnCongtyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAM", DbType="Int")]
		public System.Nullable<int> NAM
		{
			get
			{
				return this._NAM;
			}
			set
			{
				if ((this._NAM != value))
				{
					this.OnNAMChanging(value);
					this.SendPropertyChanging();
					this._NAM = value;
					this.SendPropertyChanged("NAM");
					this.OnNAMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KY", DbType="Int")]
		public System.Nullable<int> KY
		{
			get
			{
				return this._KY;
			}
			set
			{
				if ((this._KY != value))
				{
					this.OnKYChanging(value);
					this.SendPropertyChanging();
					this._KY = value;
					this.SendPropertyChanged("KY");
					this.OnKYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NGAYTAO", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> NGAYTAO
		{
			get
			{
				return this._NGAYTAO;
			}
			set
			{
				if ((this._NGAYTAO != value))
				{
					this.OnNGAYTAOChanging(value);
					this.SendPropertyChanging();
					this._NGAYTAO = value;
					this.SendPropertyChanged("NGAYTAO");
					this.OnNGAYTAOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Upload_File", Storage="_Files", ThisKey="ID", OtherKey="UploadID")]
		public EntitySet<File> Files
		{
			get
			{
				return this._Files;
			}
			set
			{
				this._Files.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Congty_Upload", Storage="_Congty", ThisKey="CongtyID", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Congty Congty
		{
			get
			{
				return this._Congty.Entity;
			}
			set
			{
				Congty previousValue = this._Congty.Entity;
				if (((previousValue != value) 
							|| (this._Congty.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Congty.Entity = null;
						previousValue.Uploads.Remove(this);
					}
					this._Congty.Entity = value;
					if ((value != null))
					{
						value.Uploads.Add(this);
						this._CongtyID = value.ID;
					}
					else
					{
						this._CongtyID = default(int);
					}
					this.SendPropertyChanged("Congty");
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
		
		private void attach_Files(File entity)
		{
			this.SendPropertyChanging();
			entity.Upload = this;
		}
		
		private void detach_Files(File entity)
		{
			this.SendPropertyChanging();
			entity.Upload = null;
		}
	}
}
#pragma warning restore 1591