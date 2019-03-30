﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebNote.DB.Business
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebNoteDB")]
	public partial class WNDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertKeyValue(KeyValue instance);
    partial void UpdateKeyValue(KeyValue instance);
    partial void DeleteKeyValue(KeyValue instance);
    partial void InsertKeyword(Keyword instance);
    partial void UpdateKeyword(Keyword instance);
    partial void DeleteKeyword(Keyword instance);
    partial void InsertLanguage(Language instance);
    partial void UpdateLanguage(Language instance);
    partial void DeleteLanguage(Language instance);
    partial void InsertNote(Note instance);
    partial void UpdateNote(Note instance);
    partial void DeleteNote(Note instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUserRole(UserRole instance);
    partial void UpdateUserRole(UserRole instance);
    partial void DeleteUserRole(UserRole instance);
    #endregion
		
		public WNDataContext() : 
				base(global::WebNote.DB.Properties.Settings.Default.WebNoteDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WNDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WNDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WNDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WNDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KeyValue> KeyValues
		{
			get
			{
				return this.GetTable<KeyValue>();
			}
		}
		
		public System.Data.Linq.Table<Keyword> Keywords
		{
			get
			{
				return this.GetTable<Keyword>();
			}
		}
		
		public System.Data.Linq.Table<Language> Languages
		{
			get
			{
				return this.GetTable<Language>();
			}
		}
		
		public System.Data.Linq.Table<Note> Notes
		{
			get
			{
				return this.GetTable<Note>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserRole> UserRoles
		{
			get
			{
				return this.GetTable<UserRole>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KeyValue")]
	public partial class KeyValue : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private long _LanguageId;
		
		private long _KeywordId;
		
		private string _Value;
		
		private EntityRef<Keyword> _Keyword;
		
		private EntityRef<Language> _Language;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnLanguageIdChanging(long value);
    partial void OnLanguageIdChanged();
    partial void OnKeywordIdChanging(long value);
    partial void OnKeywordIdChanged();
    partial void OnValueChanging(string value);
    partial void OnValueChanged();
    #endregion
		
		public KeyValue()
		{
			this._Keyword = default(EntityRef<Keyword>);
			this._Language = default(EntityRef<Language>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanguageId", DbType="BigInt NOT NULL")]
		public long LanguageId
		{
			get
			{
				return this._LanguageId;
			}
			set
			{
				if ((this._LanguageId != value))
				{
					if (this._Language.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLanguageIdChanging(value);
					this.SendPropertyChanging();
					this._LanguageId = value;
					this.SendPropertyChanged("LanguageId");
					this.OnLanguageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeywordId", DbType="BigInt NOT NULL")]
		public long KeywordId
		{
			get
			{
				return this._KeywordId;
			}
			set
			{
				if ((this._KeywordId != value))
				{
					if (this._Keyword.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKeywordIdChanging(value);
					this.SendPropertyChanging();
					this._KeywordId = value;
					this.SendPropertyChanged("KeywordId");
					this.OnKeywordIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyword_KeyValue", Storage="_Keyword", ThisKey="KeywordId", OtherKey="Id", IsForeignKey=true)]
		public Keyword Keyword
		{
			get
			{
				return this._Keyword.Entity;
			}
			set
			{
				Keyword previousValue = this._Keyword.Entity;
				if (((previousValue != value) 
							|| (this._Keyword.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Keyword.Entity = null;
						previousValue.KeyValues.Remove(this);
					}
					this._Keyword.Entity = value;
					if ((value != null))
					{
						value.KeyValues.Add(this);
						this._KeywordId = value.Id;
					}
					else
					{
						this._KeywordId = default(long);
					}
					this.SendPropertyChanged("Keyword");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Language_KeyValue", Storage="_Language", ThisKey="LanguageId", OtherKey="Id", IsForeignKey=true)]
		public Language Language
		{
			get
			{
				return this._Language.Entity;
			}
			set
			{
				Language previousValue = this._Language.Entity;
				if (((previousValue != value) 
							|| (this._Language.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Language.Entity = null;
						previousValue.KeyValues.Remove(this);
					}
					this._Language.Entity = value;
					if ((value != null))
					{
						value.KeyValues.Add(this);
						this._LanguageId = value.Id;
					}
					else
					{
						this._LanguageId = default(long);
					}
					this.SendPropertyChanged("Language");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Keyword")]
	public partial class Keyword : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _name;
		
		private long _comment;
		
		private EntitySet<KeyValue> _KeyValues;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncommentChanging(long value);
    partial void OncommentChanged();
    #endregion
		
		public Keyword()
		{
			this._KeyValues = new EntitySet<KeyValue>(new Action<KeyValue>(this.attach_KeyValues), new Action<KeyValue>(this.detach_KeyValues));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comment", DbType="BigInt NOT NULL")]
		public long comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				if ((this._comment != value))
				{
					this.OncommentChanging(value);
					this.SendPropertyChanging();
					this._comment = value;
					this.SendPropertyChanged("comment");
					this.OncommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Keyword_KeyValue", Storage="_KeyValues", ThisKey="Id", OtherKey="KeywordId")]
		public EntitySet<KeyValue> KeyValues
		{
			get
			{
				return this._KeyValues;
			}
			set
			{
				this._KeyValues.Assign(value);
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
		
		private void attach_KeyValues(KeyValue entity)
		{
			this.SendPropertyChanging();
			entity.Keyword = this;
		}
		
		private void detach_KeyValues(KeyValue entity)
		{
			this.SendPropertyChanging();
			entity.Keyword = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Language")]
	public partial class Language : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _name;
		
		private string _comment;
		
		private EntitySet<KeyValue> _KeyValues;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncommentChanging(string value);
    partial void OncommentChanged();
    #endregion
		
		public Language()
		{
			this._KeyValues = new EntitySet<KeyValue>(new Action<KeyValue>(this.attach_KeyValues), new Action<KeyValue>(this.detach_KeyValues));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comment", DbType="NVarChar(100)")]
		public string comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				if ((this._comment != value))
				{
					this.OncommentChanging(value);
					this.SendPropertyChanging();
					this._comment = value;
					this.SendPropertyChanged("comment");
					this.OncommentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Language_KeyValue", Storage="_KeyValues", ThisKey="Id", OtherKey="LanguageId")]
		public EntitySet<KeyValue> KeyValues
		{
			get
			{
				return this._KeyValues;
			}
			set
			{
				this._KeyValues.Assign(value);
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
		
		private void attach_KeyValues(KeyValue entity)
		{
			this.SendPropertyChanging();
			entity.Language = this;
		}
		
		private void detach_KeyValues(KeyValue entity)
		{
			this.SendPropertyChanging();
			entity.Language = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Note")]
	public partial class Note : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _title;
		
		private string _content;
		
		private long _user_Id;
		
		private bool _isPublic;
		
		private System.Nullable<System.DateTime> _creation_date;
		
		private System.DateTime _last_update;
		
		private string _tag;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OncontentChanging(string value);
    partial void OncontentChanged();
    partial void Onuser_IdChanging(long value);
    partial void Onuser_IdChanged();
    partial void OnisPublicChanging(bool value);
    partial void OnisPublicChanged();
    partial void Oncreation_dateChanging(System.Nullable<System.DateTime> value);
    partial void Oncreation_dateChanged();
    partial void Onlast_updateChanging(System.DateTime value);
    partial void Onlast_updateChanged();
    partial void OntagChanging(string value);
    partial void OntagChanged();
    #endregion
		
		public Note()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_content", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string content
		{
			get
			{
				return this._content;
			}
			set
			{
				if ((this._content != value))
				{
					this.OncontentChanging(value);
					this.SendPropertyChanging();
					this._content = value;
					this.SendPropertyChanged("content");
					this.OncontentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_Id", DbType="BigInt NOT NULL")]
		public long user_Id
		{
			get
			{
				return this._user_Id;
			}
			set
			{
				if ((this._user_Id != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_IdChanging(value);
					this.SendPropertyChanging();
					this._user_Id = value;
					this.SendPropertyChanged("user_Id");
					this.Onuser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isPublic", DbType="Bit NOT NULL")]
		public bool isPublic
		{
			get
			{
				return this._isPublic;
			}
			set
			{
				if ((this._isPublic != value))
				{
					this.OnisPublicChanging(value);
					this.SendPropertyChanging();
					this._isPublic = value;
					this.SendPropertyChanged("isPublic");
					this.OnisPublicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creation_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> creation_date
		{
			get
			{
				return this._creation_date;
			}
			set
			{
				if ((this._creation_date != value))
				{
					this.Oncreation_dateChanging(value);
					this.SendPropertyChanging();
					this._creation_date = value;
					this.SendPropertyChanged("creation_date");
					this.Oncreation_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_update", DbType="DateTime NOT NULL")]
		public System.DateTime last_update
		{
			get
			{
				return this._last_update;
			}
			set
			{
				if ((this._last_update != value))
				{
					this.Onlast_updateChanging(value);
					this.SendPropertyChanging();
					this._last_update = value;
					this.SendPropertyChanged("last_update");
					this.Onlast_updateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tag", DbType="NVarChar(MAX)")]
		public string tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if ((this._tag != value))
				{
					this.OntagChanging(value);
					this.SendPropertyChanging();
					this._tag = value;
					this.SendPropertyChanged("tag");
					this.OntagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Note", Storage="_User", ThisKey="user_Id", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Notes.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Notes.Add(this);
						this._user_Id = value.Id;
					}
					else
					{
						this._user_Id = default(long);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Role")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Name;
		
		private string _description;
		
		private EntitySet<UserRole> _UserRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public Role()
		{
			this._UserRoles = new EntitySet<UserRole>(new Action<UserRole>(this.attach_UserRoles), new Action<UserRole>(this.detach_UserRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(200)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_UserRole", Storage="_UserRoles", ThisKey="Id", OtherKey="RoleId")]
		public EntitySet<UserRole> UserRoles
		{
			get
			{
				return this._UserRoles;
			}
			set
			{
				this._UserRoles.Assign(value);
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
		
		private void attach_UserRoles(UserRole entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_UserRoles(UserRole entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private string _Name;
		
		private string _Password;
		
		private string _Email;
		
		private EntitySet<Note> _Notes;
		
		private EntitySet<UserRole> _UserRoles;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public User()
		{
			this._Notes = new EntitySet<Note>(new Action<Note>(this.attach_Notes), new Action<Note>(this.detach_Notes));
			this._UserRoles = new EntitySet<UserRole>(new Action<UserRole>(this.attach_UserRoles), new Action<UserRole>(this.detach_UserRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Note", Storage="_Notes", ThisKey="Id", OtherKey="user_Id")]
		public EntitySet<Note> Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				this._Notes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserRole", Storage="_UserRoles", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<UserRole> UserRoles
		{
			get
			{
				return this._UserRoles;
			}
			set
			{
				this._UserRoles.Assign(value);
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
		
		private void attach_Notes(Note entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Notes(Note entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_UserRoles(UserRole entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_UserRoles(UserRole entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserRole")]
	public partial class UserRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private long _UserId;
		
		private long _RoleId;
		
		private EntityRef<Role> _Role;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(long value);
    partial void OnUserIdChanged();
    partial void OnRoleIdChanging(long value);
    partial void OnRoleIdChanged();
    #endregion
		
		public UserRole()
		{
			this._Role = default(EntityRef<Role>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="BigInt NOT NULL")]
		public long UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleId", DbType="BigInt NOT NULL")]
		public long RoleId
		{
			get
			{
				return this._RoleId;
			}
			set
			{
				if ((this._RoleId != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIdChanging(value);
					this.SendPropertyChanging();
					this._RoleId = value;
					this.SendPropertyChanged("RoleId");
					this.OnRoleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_UserRole", Storage="_Role", ThisKey="RoleId", OtherKey="Id", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.UserRoles.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.UserRoles.Add(this);
						this._RoleId = value.Id;
					}
					else
					{
						this._RoleId = default(long);
					}
					this.SendPropertyChanged("Role");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserRole", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserRoles.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserRoles.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(long);
					}
					this.SendPropertyChanged("User");
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