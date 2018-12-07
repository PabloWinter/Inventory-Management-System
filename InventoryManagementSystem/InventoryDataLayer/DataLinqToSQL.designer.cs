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

namespace InventoryDataLayer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="retailmgmt")]
	public partial class DataLinqToSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTProductGroup(TProductGroup instance);
    partial void UpdateTProductGroup(TProductGroup instance);
    partial void DeleteTProductGroup(TProductGroup instance);
    partial void InsertTProduct(TProduct instance);
    partial void UpdateTProduct(TProduct instance);
    partial void DeleteTProduct(TProduct instance);
    partial void InsertTCategory(TCategory instance);
    partial void UpdateTCategory(TCategory instance);
    partial void DeleteTCategory(TCategory instance);
    partial void InsertTBrand(TBrand instance);
    partial void UpdateTBrand(TBrand instance);
    partial void DeleteTBrand(TBrand instance);
    partial void InsertTPurchaseLog(TPurchaseLog instance);
    partial void UpdateTPurchaseLog(TPurchaseLog instance);
    partial void DeleteTPurchaseLog(TPurchaseLog instance);
    partial void InsertTLocation(TLocation instance);
    partial void UpdateTLocation(TLocation instance);
    partial void DeleteTLocation(TLocation instance);
    #endregion
		
		public DataLinqToSQLDataContext() : 
				base(global::InventoryDataLayer.Properties.Settings.Default.retailmgmtConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqToSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqToSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqToSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataLinqToSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TProductGroup> TProductGroups
		{
			get
			{
				return this.GetTable<TProductGroup>();
			}
		}
		
		public System.Data.Linq.Table<TProduct> TProducts
		{
			get
			{
				return this.GetTable<TProduct>();
			}
		}
		
		public System.Data.Linq.Table<TCategory> TCategories
		{
			get
			{
				return this.GetTable<TCategory>();
			}
		}
		
		public System.Data.Linq.Table<TBrand> TBrands
		{
			get
			{
				return this.GetTable<TBrand>();
			}
		}
		
		public System.Data.Linq.Table<TPurchaseLog> TPurchaseLogs
		{
			get
			{
				return this.GetTable<TPurchaseLog>();
			}
		}
		
		public System.Data.Linq.Table<TLocation> TLocations
		{
			get
			{
				return this.GetTable<TLocation>();
			}
		}
		
		public System.Data.Linq.Table<TReturned> TReturneds
		{
			get
			{
				return this.GetTable<TReturned>();
			}
		}
		
		public System.Data.Linq.Table<TInStock> TInStocks
		{
			get
			{
				return this.GetTable<TInStock>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TProductGroup")]
	public partial class TProductGroup : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Barcode;
		
		private string _Name;
		
		private decimal _Price;
		
		private decimal _Tax;
		
		private System.Nullable<decimal> _Discount;
		
		private string _DESCRIPTION;
		
		private System.Nullable<int> _CategoryID;
		
		private int _BrandID;
		
		private string _FullProductName;
		
		private string _ShortProductName;
		
		private EntitySet<TProduct> _TProducts;
		
		private EntitySet<TPurchaseLog> _TPurchaseLogs;
		
		private EntityRef<TCategory> _TCategory;
		
		private EntityRef<TBrand> _TBrand;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBarcodeChanging(int value);
    partial void OnBarcodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnTaxChanging(decimal value);
    partial void OnTaxChanged();
    partial void OnDiscountChanging(System.Nullable<decimal> value);
    partial void OnDiscountChanged();
    partial void OnDESCRIPTIONChanging(string value);
    partial void OnDESCRIPTIONChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> value);
    partial void OnCategoryIDChanged();
    partial void OnBrandIDChanging(int value);
    partial void OnBrandIDChanged();
    partial void OnFullProductNameChanging(string value);
    partial void OnFullProductNameChanged();
    partial void OnShortProductNameChanging(string value);
    partial void OnShortProductNameChanged();
    #endregion
		
		public TProductGroup()
		{
			this._TProducts = new EntitySet<TProduct>(new Action<TProduct>(this.attach_TProducts), new Action<TProduct>(this.detach_TProducts));
			this._TPurchaseLogs = new EntitySet<TPurchaseLog>(new Action<TPurchaseLog>(this.attach_TPurchaseLogs), new Action<TPurchaseLog>(this.detach_TPurchaseLogs));
			this._TCategory = default(EntityRef<TCategory>);
			this._TBrand = default(EntityRef<TBrand>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Barcode", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Barcode
		{
			get
			{
				return this._Barcode;
			}
			set
			{
				if ((this._Barcode != value))
				{
					this.OnBarcodeChanging(value);
					this.SendPropertyChanging();
					this._Barcode = value;
					this.SendPropertyChanged("Barcode");
					this.OnBarcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tax", DbType="Money NOT NULL")]
		public decimal Tax
		{
			get
			{
				return this._Tax;
			}
			set
			{
				if ((this._Tax != value))
				{
					this.OnTaxChanging(value);
					this.SendPropertyChanging();
					this._Tax = value;
					this.SendPropertyChanged("Tax");
					this.OnTaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discount", DbType="Money")]
		public System.Nullable<decimal> Discount
		{
			get
			{
				return this._Discount;
			}
			set
			{
				if ((this._Discount != value))
				{
					this.OnDiscountChanging(value);
					this.SendPropertyChanging();
					this._Discount = value;
					this.SendPropertyChanged("Discount");
					this.OnDiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESCRIPTION", DbType="NVarChar(250) NOT NULL", CanBeNull=false)]
		public string DESCRIPTION
		{
			get
			{
				return this._DESCRIPTION;
			}
			set
			{
				if ((this._DESCRIPTION != value))
				{
					this.OnDESCRIPTIONChanging(value);
					this.SendPropertyChanging();
					this._DESCRIPTION = value;
					this.SendPropertyChanged("DESCRIPTION");
					this.OnDESCRIPTIONChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
		public System.Nullable<int> CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					if (this._TCategory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrandID", DbType="Int NOT NULL")]
		public int BrandID
		{
			get
			{
				return this._BrandID;
			}
			set
			{
				if ((this._BrandID != value))
				{
					if (this._TBrand.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBrandIDChanging(value);
					this.SendPropertyChanging();
					this._BrandID = value;
					this.SendPropertyChanged("BrandID");
					this.OnBrandIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullProductName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FullProductName
		{
			get
			{
				return this._FullProductName;
			}
			set
			{
				if ((this._FullProductName != value))
				{
					this.OnFullProductNameChanging(value);
					this.SendPropertyChanging();
					this._FullProductName = value;
					this.SendPropertyChanged("FullProductName");
					this.OnFullProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortProductName", DbType="NVarChar(50)")]
		public string ShortProductName
		{
			get
			{
				return this._ShortProductName;
			}
			set
			{
				if ((this._ShortProductName != value))
				{
					this.OnShortProductNameChanging(value);
					this.SendPropertyChanging();
					this._ShortProductName = value;
					this.SendPropertyChanged("ShortProductName");
					this.OnShortProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TProductGroup_TProduct", Storage="_TProducts", ThisKey="Barcode", OtherKey="Barcode")]
		public EntitySet<TProduct> TProducts
		{
			get
			{
				return this._TProducts;
			}
			set
			{
				this._TProducts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TProductGroup_TPurchaseLog", Storage="_TPurchaseLogs", ThisKey="Barcode", OtherKey="Barcode")]
		public EntitySet<TPurchaseLog> TPurchaseLogs
		{
			get
			{
				return this._TPurchaseLogs;
			}
			set
			{
				this._TPurchaseLogs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCategory_TProductGroup", Storage="_TCategory", ThisKey="CategoryID", OtherKey="CategoryID", IsForeignKey=true)]
		public TCategory TCategory
		{
			get
			{
				return this._TCategory.Entity;
			}
			set
			{
				TCategory previousValue = this._TCategory.Entity;
				if (((previousValue != value) 
							|| (this._TCategory.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TCategory.Entity = null;
						previousValue.TProductGroups.Remove(this);
					}
					this._TCategory.Entity = value;
					if ((value != null))
					{
						value.TProductGroups.Add(this);
						this._CategoryID = value.CategoryID;
					}
					else
					{
						this._CategoryID = default(Nullable<int>);
					}
					this.SendPropertyChanged("TCategory");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBrand_TProductGroup", Storage="_TBrand", ThisKey="BrandID", OtherKey="BrandID", IsForeignKey=true)]
		public TBrand TBrand
		{
			get
			{
				return this._TBrand.Entity;
			}
			set
			{
				TBrand previousValue = this._TBrand.Entity;
				if (((previousValue != value) 
							|| (this._TBrand.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBrand.Entity = null;
						previousValue.TProductGroups.Remove(this);
					}
					this._TBrand.Entity = value;
					if ((value != null))
					{
						value.TProductGroups.Add(this);
						this._BrandID = value.BrandID;
					}
					else
					{
						this._BrandID = default(int);
					}
					this.SendPropertyChanged("TBrand");
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
		
		private void attach_TProducts(TProduct entity)
		{
			this.SendPropertyChanging();
			entity.TProductGroup = this;
		}
		
		private void detach_TProducts(TProduct entity)
		{
			this.SendPropertyChanging();
			entity.TProductGroup = null;
		}
		
		private void attach_TPurchaseLogs(TPurchaseLog entity)
		{
			this.SendPropertyChanging();
			entity.TProductGroup = this;
		}
		
		private void detach_TPurchaseLogs(TPurchaseLog entity)
		{
			this.SendPropertyChanging();
			entity.TProductGroup = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TProduct")]
	public partial class TProduct : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SerialNumber;
		
		private System.Nullable<int> _Barcode;
		
		private EntityRef<TProductGroup> _TProductGroup;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSerialNumberChanging(int value);
    partial void OnSerialNumberChanged();
    partial void OnBarcodeChanging(System.Nullable<int> value);
    partial void OnBarcodeChanged();
    #endregion
		
		public TProduct()
		{
			this._TProductGroup = default(EntityRef<TProductGroup>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumber", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				if ((this._SerialNumber != value))
				{
					this.OnSerialNumberChanging(value);
					this.SendPropertyChanging();
					this._SerialNumber = value;
					this.SendPropertyChanged("SerialNumber");
					this.OnSerialNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Barcode", DbType="Int")]
		public System.Nullable<int> Barcode
		{
			get
			{
				return this._Barcode;
			}
			set
			{
				if ((this._Barcode != value))
				{
					if (this._TProductGroup.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBarcodeChanging(value);
					this.SendPropertyChanging();
					this._Barcode = value;
					this.SendPropertyChanged("Barcode");
					this.OnBarcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TProductGroup_TProduct", Storage="_TProductGroup", ThisKey="Barcode", OtherKey="Barcode", IsForeignKey=true)]
		public TProductGroup TProductGroup
		{
			get
			{
				return this._TProductGroup.Entity;
			}
			set
			{
				TProductGroup previousValue = this._TProductGroup.Entity;
				if (((previousValue != value) 
							|| (this._TProductGroup.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TProductGroup.Entity = null;
						previousValue.TProducts.Remove(this);
					}
					this._TProductGroup.Entity = value;
					if ((value != null))
					{
						value.TProducts.Add(this);
						this._Barcode = value.Barcode;
					}
					else
					{
						this._Barcode = default(Nullable<int>);
					}
					this.SendPropertyChanged("TProductGroup");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TCategory")]
	public partial class TCategory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryID;
		
		private string _Name;
		
		private EntitySet<TProductGroup> _TProductGroups;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public TCategory()
		{
			this._TProductGroups = new EntitySet<TProductGroup>(new Action<TProductGroup>(this.attach_TProductGroups), new Action<TProductGroup>(this.detach_TProductGroups));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TCategory_TProductGroup", Storage="_TProductGroups", ThisKey="CategoryID", OtherKey="CategoryID")]
		public EntitySet<TProductGroup> TProductGroups
		{
			get
			{
				return this._TProductGroups;
			}
			set
			{
				this._TProductGroups.Assign(value);
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
		
		private void attach_TProductGroups(TProductGroup entity)
		{
			this.SendPropertyChanging();
			entity.TCategory = this;
		}
		
		private void detach_TProductGroups(TProductGroup entity)
		{
			this.SendPropertyChanging();
			entity.TCategory = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBrand")]
	public partial class TBrand : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BrandID;
		
		private string _Name;
		
		private EntitySet<TProductGroup> _TProductGroups;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBrandIDChanging(int value);
    partial void OnBrandIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public TBrand()
		{
			this._TProductGroups = new EntitySet<TProductGroup>(new Action<TProductGroup>(this.attach_TProductGroups), new Action<TProductGroup>(this.detach_TProductGroups));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrandID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BrandID
		{
			get
			{
				return this._BrandID;
			}
			set
			{
				if ((this._BrandID != value))
				{
					this.OnBrandIDChanging(value);
					this.SendPropertyChanging();
					this._BrandID = value;
					this.SendPropertyChanged("BrandID");
					this.OnBrandIDChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBrand_TProductGroup", Storage="_TProductGroups", ThisKey="BrandID", OtherKey="BrandID")]
		public EntitySet<TProductGroup> TProductGroups
		{
			get
			{
				return this._TProductGroups;
			}
			set
			{
				this._TProductGroups.Assign(value);
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
		
		private void attach_TProductGroups(TProductGroup entity)
		{
			this.SendPropertyChanging();
			entity.TBrand = this;
		}
		
		private void detach_TProductGroups(TProductGroup entity)
		{
			this.SendPropertyChanging();
			entity.TBrand = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TPurchaseLog")]
	public partial class TPurchaseLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TransactionID;
		
		private System.Nullable<int> _Barcode;
		
		private System.Nullable<int> _LocationID;
		
		private System.DateTime _Date;
		
		private int _Quantity;
		
		private int _TotalCost;
		
		private EntityRef<TProductGroup> _TProductGroup;
		
		private EntityRef<TLocation> _TLocation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIDChanging(int value);
    partial void OnTransactionIDChanged();
    partial void OnBarcodeChanging(System.Nullable<int> value);
    partial void OnBarcodeChanged();
    partial void OnLocationIDChanging(System.Nullable<int> value);
    partial void OnLocationIDChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    partial void OnTotalCostChanging(int value);
    partial void OnTotalCostChanged();
    #endregion
		
		public TPurchaseLog()
		{
			this._TProductGroup = default(EntityRef<TProductGroup>);
			this._TLocation = default(EntityRef<TLocation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TransactionID
		{
			get
			{
				return this._TransactionID;
			}
			set
			{
				if ((this._TransactionID != value))
				{
					this.OnTransactionIDChanging(value);
					this.SendPropertyChanging();
					this._TransactionID = value;
					this.SendPropertyChanged("TransactionID");
					this.OnTransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Barcode", DbType="Int")]
		public System.Nullable<int> Barcode
		{
			get
			{
				return this._Barcode;
			}
			set
			{
				if ((this._Barcode != value))
				{
					if (this._TProductGroup.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBarcodeChanging(value);
					this.SendPropertyChanging();
					this._Barcode = value;
					this.SendPropertyChanged("Barcode");
					this.OnBarcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationID", DbType="Int")]
		public System.Nullable<int> LocationID
		{
			get
			{
				return this._LocationID;
			}
			set
			{
				if ((this._LocationID != value))
				{
					if (this._TLocation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLocationIDChanging(value);
					this.SendPropertyChanging();
					this._LocationID = value;
					this.SendPropertyChanged("LocationID");
					this.OnLocationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime2 NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalCost", DbType="Int NOT NULL")]
		public int TotalCost
		{
			get
			{
				return this._TotalCost;
			}
			set
			{
				if ((this._TotalCost != value))
				{
					this.OnTotalCostChanging(value);
					this.SendPropertyChanging();
					this._TotalCost = value;
					this.SendPropertyChanged("TotalCost");
					this.OnTotalCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TProductGroup_TPurchaseLog", Storage="_TProductGroup", ThisKey="Barcode", OtherKey="Barcode", IsForeignKey=true)]
		public TProductGroup TProductGroup
		{
			get
			{
				return this._TProductGroup.Entity;
			}
			set
			{
				TProductGroup previousValue = this._TProductGroup.Entity;
				if (((previousValue != value) 
							|| (this._TProductGroup.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TProductGroup.Entity = null;
						previousValue.TPurchaseLogs.Remove(this);
					}
					this._TProductGroup.Entity = value;
					if ((value != null))
					{
						value.TPurchaseLogs.Add(this);
						this._Barcode = value.Barcode;
					}
					else
					{
						this._Barcode = default(Nullable<int>);
					}
					this.SendPropertyChanged("TProductGroup");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TLocation_TPurchaseLog", Storage="_TLocation", ThisKey="LocationID", OtherKey="LocationID", IsForeignKey=true)]
		public TLocation TLocation
		{
			get
			{
				return this._TLocation.Entity;
			}
			set
			{
				TLocation previousValue = this._TLocation.Entity;
				if (((previousValue != value) 
							|| (this._TLocation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TLocation.Entity = null;
						previousValue.TPurchaseLogs.Remove(this);
					}
					this._TLocation.Entity = value;
					if ((value != null))
					{
						value.TPurchaseLogs.Add(this);
						this._LocationID = value.LocationID;
					}
					else
					{
						this._LocationID = default(Nullable<int>);
					}
					this.SendPropertyChanged("TLocation");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TLocation")]
	public partial class TLocation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LocationID;
		
		private string _Name;
		
		private string _Address;
		
		private string _City;
		
		private int _Phone;
		
		private EntitySet<TPurchaseLog> _TPurchaseLogs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLocationIDChanging(int value);
    partial void OnLocationIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnPhoneChanging(int value);
    partial void OnPhoneChanged();
    #endregion
		
		public TLocation()
		{
			this._TPurchaseLogs = new EntitySet<TPurchaseLog>(new Action<TPurchaseLog>(this.attach_TPurchaseLogs), new Action<TPurchaseLog>(this.detach_TPurchaseLogs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LocationID
		{
			get
			{
				return this._LocationID;
			}
			set
			{
				if ((this._LocationID != value))
				{
					this.OnLocationIDChanging(value);
					this.SendPropertyChanging();
					this._LocationID = value;
					this.SendPropertyChanged("LocationID");
					this.OnLocationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(70) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Int NOT NULL")]
		public int Phone
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TLocation_TPurchaseLog", Storage="_TPurchaseLogs", ThisKey="LocationID", OtherKey="LocationID")]
		public EntitySet<TPurchaseLog> TPurchaseLogs
		{
			get
			{
				return this._TPurchaseLogs;
			}
			set
			{
				this._TPurchaseLogs.Assign(value);
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
		
		private void attach_TPurchaseLogs(TPurchaseLog entity)
		{
			this.SendPropertyChanging();
			entity.TLocation = this;
		}
		
		private void detach_TPurchaseLogs(TPurchaseLog entity)
		{
			this.SendPropertyChanging();
			entity.TLocation = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TReturned")]
	public partial class TReturned
	{
		
		private System.Nullable<int> _BarcodeID;
		
		private System.Nullable<int> _LocationID;
		
		private int _Quantity;
		
		public TReturned()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BarcodeID", DbType="Int")]
		public System.Nullable<int> BarcodeID
		{
			get
			{
				return this._BarcodeID;
			}
			set
			{
				if ((this._BarcodeID != value))
				{
					this._BarcodeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationID", DbType="Int")]
		public System.Nullable<int> LocationID
		{
			get
			{
				return this._LocationID;
			}
			set
			{
				if ((this._LocationID != value))
				{
					this._LocationID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this._Quantity = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TInStock")]
	public partial class TInStock
	{
		
		private int _BarcodeID;
		
		private int _LocationID;
		
		private int _Quantity;
		
		public TInStock()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BarcodeID", DbType="Int NOT NULL")]
		public int BarcodeID
		{
			get
			{
				return this._BarcodeID;
			}
			set
			{
				if ((this._BarcodeID != value))
				{
					this._BarcodeID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationID", DbType="Int NOT NULL")]
		public int LocationID
		{
			get
			{
				return this._LocationID;
			}
			set
			{
				if ((this._LocationID != value))
				{
					this._LocationID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
		public int Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this._Quantity = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
