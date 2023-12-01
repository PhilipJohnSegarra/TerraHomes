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

namespace TerraHomes
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TerraZonDB")]
	public partial class DCterrazonDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertAgentsProperty(AgentsProperty instance);
    partial void UpdateAgentsProperty(AgentsProperty instance);
    partial void DeleteAgentsProperty(AgentsProperty instance);
    partial void InsertPropertyImage(PropertyImage instance);
    partial void UpdatePropertyImage(PropertyImage instance);
    partial void DeletePropertyImage(PropertyImage instance);
    partial void InsertProperty(Property instance);
    partial void UpdateProperty(Property instance);
    partial void DeleteProperty(Property instance);
    #endregion
		
		public DCterrazonDataContext() : 
				base(global::TerraHomes.Properties.Settings.Default.TerraZonDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DCterrazonDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCterrazonDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCterrazonDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DCterrazonDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
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
		
		public System.Data.Linq.Table<AgentsProperty> AgentsProperties
		{
			get
			{
				return this.GetTable<AgentsProperty>();
			}
		}
		
		public System.Data.Linq.Table<PropertyImage> PropertyImages
		{
			get
			{
				return this.GetTable<PropertyImage>();
			}
		}
		
		public System.Data.Linq.Table<Property> Properties
		{
			get
			{
				return this.GetTable<Property>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_GetData")]
		public ISingleResult<sp_GetDataResult> sp_GetData()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_GetDataResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_InsertSignUp")]
		public int sp_InsertSignUp([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), email, username, password);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _Username;
		
		private string _Password;
		
		private string _Firstname;
		
		private string _Lastname;
		
		private string _Email;
		
		private string _UserType;
		
		private EntitySet<Property> _Properties;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstnameChanging(string value);
    partial void OnFirstnameChanged();
    partial void OnLastnameChanging(string value);
    partial void OnLastnameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnUserTypeChanging(string value);
    partial void OnUserTypeChanged();
    #endregion
		
		public User()
		{
			this._Properties = new EntitySet<Property>(new Action<Property>(this.attach_Properties), new Action<Property>(this.detach_Properties));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="VarChar(50)")]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this.OnFirstnameChanging(value);
					this.SendPropertyChanging();
					this._Firstname = value;
					this.SendPropertyChanged("Firstname");
					this.OnFirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="VarChar(50)")]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this.OnLastnameChanging(value);
					this.SendPropertyChanging();
					this._Lastname = value;
					this.SendPropertyChanged("Lastname");
					this.OnLastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(50)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this.OnUserTypeChanging(value);
					this.SendPropertyChanging();
					this._UserType = value;
					this.SendPropertyChanged("UserType");
					this.OnUserTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Property", Storage="_Properties", ThisKey="UserID", OtherKey="OwnerID")]
		public EntitySet<Property> Properties
		{
			get
			{
				return this._Properties;
			}
			set
			{
				this._Properties.Assign(value);
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
		
		private void attach_Properties(Property entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Properties(Property entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AgentsProperties")]
	public partial class AgentsProperty : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AgentPropertyID;
		
		private string _AgentID;
		
		private System.Nullable<int> _PropertyID;
		
		private EntityRef<Property> _Property;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAgentPropertyIDChanging(int value);
    partial void OnAgentPropertyIDChanged();
    partial void OnAgentIDChanging(string value);
    partial void OnAgentIDChanged();
    partial void OnPropertyIDChanging(System.Nullable<int> value);
    partial void OnPropertyIDChanged();
    #endregion
		
		public AgentsProperty()
		{
			this._Property = default(EntityRef<Property>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgentPropertyID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AgentPropertyID
		{
			get
			{
				return this._AgentPropertyID;
			}
			set
			{
				if ((this._AgentPropertyID != value))
				{
					this.OnAgentPropertyIDChanging(value);
					this.SendPropertyChanging();
					this._AgentPropertyID = value;
					this.SendPropertyChanged("AgentPropertyID");
					this.OnAgentPropertyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AgentID", DbType="VarChar(50)")]
		public string AgentID
		{
			get
			{
				return this._AgentID;
			}
			set
			{
				if ((this._AgentID != value))
				{
					this.OnAgentIDChanging(value);
					this.SendPropertyChanging();
					this._AgentID = value;
					this.SendPropertyChanged("AgentID");
					this.OnAgentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyID", DbType="Int")]
		public System.Nullable<int> PropertyID
		{
			get
			{
				return this._PropertyID;
			}
			set
			{
				if ((this._PropertyID != value))
				{
					if (this._Property.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPropertyIDChanging(value);
					this.SendPropertyChanging();
					this._PropertyID = value;
					this.SendPropertyChanged("PropertyID");
					this.OnPropertyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Property_AgentsProperty", Storage="_Property", ThisKey="PropertyID", OtherKey="PropertyID", IsForeignKey=true)]
		public Property Property
		{
			get
			{
				return this._Property.Entity;
			}
			set
			{
				Property previousValue = this._Property.Entity;
				if (((previousValue != value) 
							|| (this._Property.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Property.Entity = null;
						previousValue.AgentsProperties.Remove(this);
					}
					this._Property.Entity = value;
					if ((value != null))
					{
						value.AgentsProperties.Add(this);
						this._PropertyID = value.PropertyID;
					}
					else
					{
						this._PropertyID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Property");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PropertyImages")]
	public partial class PropertyImage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ImageID;
		
		private System.Nullable<int> _PropertyID;
		
		private string _ImageURL;
		
		private EntityRef<Property> _Property;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnImageIDChanging(int value);
    partial void OnImageIDChanged();
    partial void OnPropertyIDChanging(System.Nullable<int> value);
    partial void OnPropertyIDChanged();
    partial void OnImageURLChanging(string value);
    partial void OnImageURLChanged();
    #endregion
		
		public PropertyImage()
		{
			this._Property = default(EntityRef<Property>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ImageID
		{
			get
			{
				return this._ImageID;
			}
			set
			{
				if ((this._ImageID != value))
				{
					this.OnImageIDChanging(value);
					this.SendPropertyChanging();
					this._ImageID = value;
					this.SendPropertyChanged("ImageID");
					this.OnImageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyID", DbType="Int")]
		public System.Nullable<int> PropertyID
		{
			get
			{
				return this._PropertyID;
			}
			set
			{
				if ((this._PropertyID != value))
				{
					if (this._Property.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPropertyIDChanging(value);
					this.SendPropertyChanging();
					this._PropertyID = value;
					this.SendPropertyChanged("PropertyID");
					this.OnPropertyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageURL", DbType="VarChar(50)")]
		public string ImageURL
		{
			get
			{
				return this._ImageURL;
			}
			set
			{
				if ((this._ImageURL != value))
				{
					this.OnImageURLChanging(value);
					this.SendPropertyChanging();
					this._ImageURL = value;
					this.SendPropertyChanged("ImageURL");
					this.OnImageURLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Property_PropertyImage", Storage="_Property", ThisKey="PropertyID", OtherKey="PropertyID", IsForeignKey=true)]
		public Property Property
		{
			get
			{
				return this._Property.Entity;
			}
			set
			{
				Property previousValue = this._Property.Entity;
				if (((previousValue != value) 
							|| (this._Property.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Property.Entity = null;
						previousValue.PropertyImages.Remove(this);
					}
					this._Property.Entity = value;
					if ((value != null))
					{
						value.PropertyImages.Add(this);
						this._PropertyID = value.PropertyID;
					}
					else
					{
						this._PropertyID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Property");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Properties")]
	public partial class Property : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PropertyID;
		
		private string _PropertyName;
		
		private string _Address;
		
		private string _Description;
		
		private string _Type;
		
		private string _Status;
		
		private System.Nullable<decimal> _Price;
		
		private string _Size;
		
		private System.Nullable<int> _OwnerID;
		
		private EntitySet<AgentsProperty> _AgentsProperties;
		
		private EntitySet<PropertyImage> _PropertyImages;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPropertyIDChanging(int value);
    partial void OnPropertyIDChanged();
    partial void OnPropertyNameChanging(string value);
    partial void OnPropertyNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnPriceChanging(System.Nullable<decimal> value);
    partial void OnPriceChanged();
    partial void OnSizeChanging(string value);
    partial void OnSizeChanged();
    partial void OnOwnerIDChanging(System.Nullable<int> value);
    partial void OnOwnerIDChanged();
    #endregion
		
		public Property()
		{
			this._AgentsProperties = new EntitySet<AgentsProperty>(new Action<AgentsProperty>(this.attach_AgentsProperties), new Action<AgentsProperty>(this.detach_AgentsProperties));
			this._PropertyImages = new EntitySet<PropertyImage>(new Action<PropertyImage>(this.attach_PropertyImages), new Action<PropertyImage>(this.detach_PropertyImages));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PropertyID
		{
			get
			{
				return this._PropertyID;
			}
			set
			{
				if ((this._PropertyID != value))
				{
					this.OnPropertyIDChanging(value);
					this.SendPropertyChanging();
					this._PropertyID = value;
					this.SendPropertyChanged("PropertyID");
					this.OnPropertyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyName", DbType="VarChar(250)")]
		public string PropertyName
		{
			get
			{
				return this._PropertyName;
			}
			set
			{
				if ((this._PropertyName != value))
				{
					this.OnPropertyNameChanging(value);
					this.SendPropertyChanging();
					this._PropertyName = value;
					this.SendPropertyChanged("PropertyName");
					this.OnPropertyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(250)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(550)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50)")]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(100)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="VarChar(150)")]
		public string Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerID", DbType="Int")]
		public System.Nullable<int> OwnerID
		{
			get
			{
				return this._OwnerID;
			}
			set
			{
				if ((this._OwnerID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOwnerIDChanging(value);
					this.SendPropertyChanging();
					this._OwnerID = value;
					this.SendPropertyChanged("OwnerID");
					this.OnOwnerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Property_AgentsProperty", Storage="_AgentsProperties", ThisKey="PropertyID", OtherKey="PropertyID")]
		public EntitySet<AgentsProperty> AgentsProperties
		{
			get
			{
				return this._AgentsProperties;
			}
			set
			{
				this._AgentsProperties.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Property_PropertyImage", Storage="_PropertyImages", ThisKey="PropertyID", OtherKey="PropertyID")]
		public EntitySet<PropertyImage> PropertyImages
		{
			get
			{
				return this._PropertyImages;
			}
			set
			{
				this._PropertyImages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Property", Storage="_User", ThisKey="OwnerID", OtherKey="UserID", IsForeignKey=true)]
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
						previousValue.Properties.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Properties.Add(this);
						this._OwnerID = value.UserID;
					}
					else
					{
						this._OwnerID = default(Nullable<int>);
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
		
		private void attach_AgentsProperties(AgentsProperty entity)
		{
			this.SendPropertyChanging();
			entity.Property = this;
		}
		
		private void detach_AgentsProperties(AgentsProperty entity)
		{
			this.SendPropertyChanging();
			entity.Property = null;
		}
		
		private void attach_PropertyImages(PropertyImage entity)
		{
			this.SendPropertyChanging();
			entity.Property = this;
		}
		
		private void detach_PropertyImages(PropertyImage entity)
		{
			this.SendPropertyChanging();
			entity.Property = null;
		}
	}
	
	public partial class sp_GetDataResult
	{
		
		private int _UserID;
		
		private string _Username;
		
		private string _Password;
		
		private string _Firstname;
		
		private string _Lastname;
		
		private string _Email;
		
		private string _UserType;
		
		public sp_GetDataResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
					this._Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="VarChar(50)")]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this._Firstname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="VarChar(50)")]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this._Lastname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserType", DbType="VarChar(50)")]
		public string UserType
		{
			get
			{
				return this._UserType;
			}
			set
			{
				if ((this._UserType != value))
				{
					this._UserType = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
