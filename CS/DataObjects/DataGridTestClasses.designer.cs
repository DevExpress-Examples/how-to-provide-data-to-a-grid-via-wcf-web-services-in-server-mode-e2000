﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30220.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataObjects
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DXGridServerModeDB")]
	public partial class DataGridTestClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertWpfServerSideGridTest(WpfServerSideGridTest instance);
    partial void UpdateWpfServerSideGridTest(WpfServerSideGridTest instance);
    partial void DeleteWpfServerSideGridTest(WpfServerSideGridTest instance);
    #endregion
		
		public DataGridTestClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataGridTestClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataGridTestClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataGridTestClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<WpfServerSideGridTest> WpfServerSideGridTests
		{
			get
			{
				return this.GetTable<WpfServerSideGridTest>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WpfServerSideGridTest")]
	public partial class WpfServerSideGridTest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OID;
		
		private string _Subject;
		
		private string _From;
		
		private System.Nullable<System.DateTime> _Sent;
		
		private System.Nullable<long> _Size;
		
		private System.Nullable<bool> _HasAttachment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOIDChanging(int value);
    partial void OnOIDChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnFromChanging(string value);
    partial void OnFromChanged();
    partial void OnSentChanging(System.Nullable<System.DateTime> value);
    partial void OnSentChanged();
    partial void OnSizeChanging(System.Nullable<long> value);
    partial void OnSizeChanged();
    partial void OnHasAttachmentChanging(System.Nullable<bool> value);
    partial void OnHasAttachmentChanged();
    #endregion
		
		public WpfServerSideGridTest()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int OID
		{
			get
			{
				return this._OID;
			}
			set
			{
				if ((this._OID != value))
				{
					this.OnOIDChanging(value);
					this.SendPropertyChanging();
					this._OID = value;
					this.SendPropertyChanged("OID");
					this.OnOIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NVarChar(100)")]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[From]", Storage="_From", DbType="NVarChar(100)")]
		public string From
		{
			get
			{
				return this._From;
			}
			set
			{
				if ((this._From != value))
				{
					this.OnFromChanging(value);
					this.SendPropertyChanging();
					this._From = value;
					this.SendPropertyChanged("From");
					this.OnFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sent", DbType="DateTime")]
		public System.Nullable<System.DateTime> Sent
		{
			get
			{
				return this._Sent;
			}
			set
			{
				if ((this._Sent != value))
				{
					this.OnSentChanging(value);
					this.SendPropertyChanging();
					this._Sent = value;
					this.SendPropertyChanged("Sent");
					this.OnSentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="BigInt")]
		public System.Nullable<long> Size
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HasAttachment", DbType="Bit")]
		public System.Nullable<bool> HasAttachment
		{
			get
			{
				return this._HasAttachment;
			}
			set
			{
				if ((this._HasAttachment != value))
				{
					this.OnHasAttachmentChanging(value);
					this.SendPropertyChanging();
					this._HasAttachment = value;
					this.SendPropertyChanged("HasAttachment");
					this.OnHasAttachmentChanged();
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