﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Purplepen
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbPurplepen")]
	public partial class dcPurplepenDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcomment(comment instance);
    partial void Updatecomment(comment instance);
    partial void Deletecomment(comment instance);
    partial void Insertuploadversion(uploadversion instance);
    partial void Updateuploadversion(uploadversion instance);
    partial void Deleteuploadversion(uploadversion instance);
    partial void Insertdot(dot instance);
    partial void Updatedot(dot instance);
    partial void Deletedot(dot instance);
    partial void Insertranking(ranking instance);
    partial void Updateranking(ranking instance);
    partial void Deleteranking(ranking instance);
    partial void Insertproject(project instance);
    partial void Updateproject(project instance);
    partial void Deleteproject(project instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public dcPurplepenDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["dbPurplepenConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dcPurplepenDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcPurplepenDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcPurplepenDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcPurplepenDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<comment> comments
		{
			get
			{
				return this.GetTable<comment>();
			}
		}
		
		public System.Data.Linq.Table<uploadversion> uploadversions
		{
			get
			{
				return this.GetTable<uploadversion>();
			}
		}
		
		public System.Data.Linq.Table<dot> dots
		{
			get
			{
				return this.GetTable<dot>();
			}
		}
		
		public System.Data.Linq.Table<ranking> rankings
		{
			get
			{
				return this.GetTable<ranking>();
			}
		}
		
		public System.Data.Linq.Table<project> projects
		{
			get
			{
				return this.GetTable<project>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.comments")]
	public partial class comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _comment_id;
		
		private int _upload_id;
		
		private int _user_id;
		
		private string _title;
		
		private string _description;
		
		private int _score;
		
		private System.DateTime _datum;
		
		private int _category;
		
		private int _dot_id;
		
		private EntitySet<uploadversion> _uploadversions;
		
		private EntitySet<dot> _dots;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncomment_idChanging(int value);
    partial void Oncomment_idChanged();
    partial void Onupload_idChanging(int value);
    partial void Onupload_idChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnscoreChanging(int value);
    partial void OnscoreChanged();
    partial void OndatumChanging(System.DateTime value);
    partial void OndatumChanged();
    partial void OncategoryChanging(int value);
    partial void OncategoryChanged();
    partial void Ondot_idChanging(int value);
    partial void Ondot_idChanged();
    #endregion
		
		public comment()
		{
			this._uploadversions = new EntitySet<uploadversion>(new Action<uploadversion>(this.attach_uploadversions), new Action<uploadversion>(this.detach_uploadversions));
			this._dots = new EntitySet<dot>(new Action<dot>(this.attach_dots), new Action<dot>(this.detach_dots));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comment_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int comment_id
		{
			get
			{
				return this._comment_id;
			}
			set
			{
				if ((this._comment_id != value))
				{
					this.Oncomment_idChanging(value);
					this.SendPropertyChanging();
					this._comment_id = value;
					this.SendPropertyChanged("comment_id");
					this.Oncomment_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_upload_id", DbType="Int NOT NULL")]
		public int upload_id
		{
			get
			{
				return this._upload_id;
			}
			set
			{
				if ((this._upload_id != value))
				{
					this.Onupload_idChanging(value);
					this.SendPropertyChanging();
					this._upload_id = value;
					this.SendPropertyChanged("upload_id");
					this.Onupload_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_score", DbType="Int NOT NULL")]
		public int score
		{
			get
			{
				return this._score;
			}
			set
			{
				if ((this._score != value))
				{
					this.OnscoreChanging(value);
					this.SendPropertyChanging();
					this._score = value;
					this.SendPropertyChanged("score");
					this.OnscoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datum", DbType="Date NOT NULL")]
		public System.DateTime datum
		{
			get
			{
				return this._datum;
			}
			set
			{
				if ((this._datum != value))
				{
					this.OndatumChanging(value);
					this.SendPropertyChanging();
					this._datum = value;
					this.SendPropertyChanged("datum");
					this.OndatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="Int NOT NULL")]
		public int category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dot_id", DbType="Int NOT NULL")]
		public int dot_id
		{
			get
			{
				return this._dot_id;
			}
			set
			{
				if ((this._dot_id != value))
				{
					this.Ondot_idChanging(value);
					this.SendPropertyChanging();
					this._dot_id = value;
					this.SendPropertyChanged("dot_id");
					this.Ondot_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="comment_uploadversion", Storage="_uploadversions", ThisKey="upload_id", OtherKey="version_id")]
		public EntitySet<uploadversion> uploadversions
		{
			get
			{
				return this._uploadversions;
			}
			set
			{
				this._uploadversions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="comment_dot", Storage="_dots", ThisKey="dot_id", OtherKey="dot_id")]
		public EntitySet<dot> dots
		{
			get
			{
				return this._dots;
			}
			set
			{
				this._dots.Assign(value);
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
		
		private void attach_uploadversions(uploadversion entity)
		{
			this.SendPropertyChanging();
			entity.comment = this;
		}
		
		private void detach_uploadversions(uploadversion entity)
		{
			this.SendPropertyChanging();
			entity.comment = null;
		}
		
		private void attach_dots(dot entity)
		{
			this.SendPropertyChanging();
			entity.comment = this;
		}
		
		private void detach_dots(dot entity)
		{
			this.SendPropertyChanging();
			entity.comment = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.version")]
	public partial class uploadversion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _version_id;
		
		private int _version;
		
		private string _path;
		
		private string _description;
		
		private System.DateTime _datum;
		
		private int _project_id;
		
		private int _viewed;
		
		private System.DateTime _beamer;
		
		private int _flag;
		
		private EntitySet<project> _uploads;
		
		private EntityRef<comment> _comment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onversion_idChanging(int value);
    partial void Onversion_idChanged();
    partial void OnversionChanging(int value);
    partial void OnversionChanged();
    partial void OnpathChanging(string value);
    partial void OnpathChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OndatumChanging(System.DateTime value);
    partial void OndatumChanged();
    partial void Onproject_idChanging(int value);
    partial void Onproject_idChanged();
    partial void OnviewedChanging(int value);
    partial void OnviewedChanged();
    partial void OnbeamerChanging(System.DateTime value);
    partial void OnbeamerChanged();
    partial void OnflagChanging(int value);
    partial void OnflagChanged();
    #endregion
		
		public uploadversion()
		{
			this._uploads = new EntitySet<project>(new Action<project>(this.attach_uploads), new Action<project>(this.detach_uploads));
			this._comment = default(EntityRef<comment>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_version_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int version_id
		{
			get
			{
				return this._version_id;
			}
			set
			{
				if ((this._version_id != value))
				{
					if (this._comment.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onversion_idChanging(value);
					this.SendPropertyChanging();
					this._version_id = value;
					this.SendPropertyChanged("version_id");
					this.Onversion_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_version", DbType="Int NOT NULL")]
		public int version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((this._version != value))
				{
					this.OnversionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("version");
					this.OnversionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_path", DbType="VarChar(1000) NOT NULL", CanBeNull=false)]
		public string path
		{
			get
			{
				return this._path;
			}
			set
			{
				if ((this._path != value))
				{
					this.OnpathChanging(value);
					this.SendPropertyChanging();
					this._path = value;
					this.SendPropertyChanged("path");
					this.OnpathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datum", DbType="DateTime NOT NULL")]
		public System.DateTime datum
		{
			get
			{
				return this._datum;
			}
			set
			{
				if ((this._datum != value))
				{
					this.OndatumChanging(value);
					this.SendPropertyChanging();
					this._datum = value;
					this.SendPropertyChanged("datum");
					this.OndatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_project_id", DbType="Int NOT NULL")]
		public int project_id
		{
			get
			{
				return this._project_id;
			}
			set
			{
				if ((this._project_id != value))
				{
					this.Onproject_idChanging(value);
					this.SendPropertyChanging();
					this._project_id = value;
					this.SendPropertyChanged("project_id");
					this.Onproject_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_viewed")]
		public int viewed
		{
			get
			{
				return this._viewed;
			}
			set
			{
				if ((this._viewed != value))
				{
					this.OnviewedChanging(value);
					this.SendPropertyChanging();
					this._viewed = value;
					this.SendPropertyChanged("viewed");
					this.OnviewedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_beamer")]
		public System.DateTime beamer
		{
			get
			{
				return this._beamer;
			}
			set
			{
				if ((this._beamer != value))
				{
					this.OnbeamerChanging(value);
					this.SendPropertyChanging();
					this._beamer = value;
					this.SendPropertyChanged("beamer");
					this.OnbeamerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_flag")]
		public int flag
		{
			get
			{
				return this._flag;
			}
			set
			{
				if ((this._flag != value))
				{
					this.OnflagChanging(value);
					this.SendPropertyChanging();
					this._flag = value;
					this.SendPropertyChanged("flag");
					this.OnflagChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="uploadversion_project", Storage="_uploads", ThisKey="project_id", OtherKey="project_id")]
		public EntitySet<project> projects
		{
			get
			{
				return this._uploads;
			}
			set
			{
				this._uploads.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="comment_uploadversion", Storage="_comment", ThisKey="version_id", OtherKey="upload_id", IsForeignKey=true)]
		public comment comment
		{
			get
			{
				return this._comment.Entity;
			}
			set
			{
				comment previousValue = this._comment.Entity;
				if (((previousValue != value) 
							|| (this._comment.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._comment.Entity = null;
						previousValue.uploadversions.Remove(this);
					}
					this._comment.Entity = value;
					if ((value != null))
					{
						value.uploadversions.Add(this);
						this._version_id = value.upload_id;
					}
					else
					{
						this._version_id = default(int);
					}
					this.SendPropertyChanged("comment");
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
		
		private void attach_uploads(project entity)
		{
			this.SendPropertyChanging();
			entity.uploadversion = this;
		}
		
		private void detach_uploads(project entity)
		{
			this.SendPropertyChanging();
			entity.uploadversion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.dots")]
	public partial class dot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _dot_id;
		
		private int _dot_x;
		
		private int _dot_y;
		
		private EntityRef<comment> _comment;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ondot_idChanging(int value);
    partial void Ondot_idChanged();
    partial void Ondot_xChanging(int value);
    partial void Ondot_xChanged();
    partial void Ondot_yChanging(int value);
    partial void Ondot_yChanged();
    #endregion
		
		public dot()
		{
			this._comment = default(EntityRef<comment>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dot_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int dot_id
		{
			get
			{
				return this._dot_id;
			}
			set
			{
				if ((this._dot_id != value))
				{
					if (this._comment.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ondot_idChanging(value);
					this.SendPropertyChanging();
					this._dot_id = value;
					this.SendPropertyChanged("dot_id");
					this.Ondot_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dot_x", DbType="Int NOT NULL")]
		public int dot_x
		{
			get
			{
				return this._dot_x;
			}
			set
			{
				if ((this._dot_x != value))
				{
					this.Ondot_xChanging(value);
					this.SendPropertyChanging();
					this._dot_x = value;
					this.SendPropertyChanged("dot_x");
					this.Ondot_xChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dot_y", DbType="Int NOT NULL")]
		public int dot_y
		{
			get
			{
				return this._dot_y;
			}
			set
			{
				if ((this._dot_y != value))
				{
					this.Ondot_yChanging(value);
					this.SendPropertyChanging();
					this._dot_y = value;
					this.SendPropertyChanged("dot_y");
					this.Ondot_yChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="comment_dot", Storage="_comment", ThisKey="dot_id", OtherKey="dot_id", IsForeignKey=true)]
		public comment comment
		{
			get
			{
				return this._comment.Entity;
			}
			set
			{
				comment previousValue = this._comment.Entity;
				if (((previousValue != value) 
							|| (this._comment.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._comment.Entity = null;
						previousValue.dots.Remove(this);
					}
					this._comment.Entity = value;
					if ((value != null))
					{
						value.dots.Add(this);
						this._dot_id = value.dot_id;
					}
					else
					{
						this._dot_id = default(int);
					}
					this.SendPropertyChanged("comment");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ranking")]
	public partial class ranking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _rank_id;
		
		private string _name;
		
		private EntityRef<user> _user;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onrank_idChanging(int value);
    partial void Onrank_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public ranking()
		{
			this._user = default(EntityRef<user>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rank_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int rank_id
		{
			get
			{
				return this._rank_id;
			}
			set
			{
				if ((this._rank_id != value))
				{
					if (this._user.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onrank_idChanging(value);
					this.SendPropertyChanging();
					this._rank_id = value;
					this.SendPropertyChanged("rank_id");
					this.Onrank_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_ranking", Storage="_user", ThisKey="rank_id", OtherKey="rank_id", IsForeignKey=true)]
		public user user
		{
			get
			{
				return this._user.Entity;
			}
			set
			{
				user previousValue = this._user.Entity;
				if (((previousValue != value) 
							|| (this._user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._user.Entity = null;
						previousValue.rankings.Remove(this);
					}
					this._user.Entity = value;
					if ((value != null))
					{
						value.rankings.Add(this);
						this._rank_id = value.rank_id;
					}
					else
					{
						this._rank_id = default(int);
					}
					this.SendPropertyChanged("user");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.uploads")]
	public partial class project : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _upload_id;
		
		private int _user_id;
		
		private string _name;
		
		private EntitySet<user> _users;
		
		private EntityRef<uploadversion> _uploadversion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onproject_idChanging(int value);
    partial void Onproject_idChanged();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public project()
		{
			this._users = new EntitySet<user>(new Action<user>(this.attach_users), new Action<user>(this.detach_users));
			this._uploadversion = default(EntityRef<uploadversion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="upload_id", Storage="_upload_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int project_id
		{
			get
			{
				return this._upload_id;
			}
			set
			{
				if ((this._upload_id != value))
				{
					this.Onproject_idChanging(value);
					this.SendPropertyChanging();
					this._upload_id = value;
					this.SendPropertyChanged("project_id");
					this.Onproject_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="Int NOT NULL")]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="project_user", Storage="_users", ThisKey="user_id", OtherKey="user_id")]
		public EntitySet<user> users
		{
			get
			{
				return this._users;
			}
			set
			{
				this._users.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="uploadversion_project", Storage="_uploadversion", ThisKey="project_id", OtherKey="project_id", IsForeignKey=true)]
		public uploadversion uploadversion
		{
			get
			{
				return this._uploadversion.Entity;
			}
			set
			{
				uploadversion previousValue = this._uploadversion.Entity;
				if (((previousValue != value) 
							|| (this._uploadversion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._uploadversion.Entity = null;
						previousValue.projects.Remove(this);
					}
					this._uploadversion.Entity = value;
					if ((value != null))
					{
						value.projects.Add(this);
						this._upload_id = value.project_id;
					}
					else
					{
						this._upload_id = default(int);
					}
					this.SendPropertyChanged("uploadversion");
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
		
		private void attach_users(user entity)
		{
			this.SendPropertyChanging();
			entity.project = this;
		}
		
		private void detach_users(user entity)
		{
			this.SendPropertyChanging();
			entity.project = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _user_id;
		
		private int _fb_id;
		
		private string _name;
		
		private int _permission;
		
		private int _comments_plus;
		
		private int _comments_min;
		
		private int _report;
		
		private int _rank_id;
		
		private EntitySet<ranking> _rankings;
		
		private EntityRef<project> _upload;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(int value);
    partial void Onuser_idChanged();
    partial void Onfb_idChanging(int value);
    partial void Onfb_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpermissionChanging(int value);
    partial void OnpermissionChanged();
    partial void Oncomments_plusChanging(int value);
    partial void Oncomments_plusChanged();
    partial void Oncomments_minChanging(int value);
    partial void Oncomments_minChanged();
    partial void OnreportChanging(int value);
    partial void OnreportChanged();
    partial void Onrank_idChanging(int value);
    partial void Onrank_idChanged();
    #endregion
		
		public user()
		{
			this._rankings = new EntitySet<ranking>(new Action<ranking>(this.attach_rankings), new Action<ranking>(this.detach_rankings));
			this._upload = default(EntityRef<project>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					if (this._upload.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fb_id", DbType="Int NOT NULL")]
		public int fb_id
		{
			get
			{
				return this._fb_id;
			}
			set
			{
				if ((this._fb_id != value))
				{
					this.Onfb_idChanging(value);
					this.SendPropertyChanging();
					this._fb_id = value;
					this.SendPropertyChanged("fb_id");
					this.Onfb_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_permission", DbType="Int NOT NULL")]
		public int permission
		{
			get
			{
				return this._permission;
			}
			set
			{
				if ((this._permission != value))
				{
					this.OnpermissionChanging(value);
					this.SendPropertyChanging();
					this._permission = value;
					this.SendPropertyChanged("permission");
					this.OnpermissionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comments_plus", DbType="Int NOT NULL")]
		public int comments_plus
		{
			get
			{
				return this._comments_plus;
			}
			set
			{
				if ((this._comments_plus != value))
				{
					this.Oncomments_plusChanging(value);
					this.SendPropertyChanging();
					this._comments_plus = value;
					this.SendPropertyChanged("comments_plus");
					this.Oncomments_plusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_comments_min", DbType="Int NOT NULL")]
		public int comments_min
		{
			get
			{
				return this._comments_min;
			}
			set
			{
				if ((this._comments_min != value))
				{
					this.Oncomments_minChanging(value);
					this.SendPropertyChanging();
					this._comments_min = value;
					this.SendPropertyChanged("comments_min");
					this.Oncomments_minChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_report", DbType="Int NOT NULL")]
		public int report
		{
			get
			{
				return this._report;
			}
			set
			{
				if ((this._report != value))
				{
					this.OnreportChanging(value);
					this.SendPropertyChanging();
					this._report = value;
					this.SendPropertyChanged("report");
					this.OnreportChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rank_id", DbType="Int NOT NULL")]
		public int rank_id
		{
			get
			{
				return this._rank_id;
			}
			set
			{
				if ((this._rank_id != value))
				{
					this.Onrank_idChanging(value);
					this.SendPropertyChanging();
					this._rank_id = value;
					this.SendPropertyChanged("rank_id");
					this.Onrank_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="user_ranking", Storage="_rankings", ThisKey="rank_id", OtherKey="rank_id")]
		public EntitySet<ranking> rankings
		{
			get
			{
				return this._rankings;
			}
			set
			{
				this._rankings.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="project_user", Storage="_upload", ThisKey="user_id", OtherKey="user_id", IsForeignKey=true)]
		public project project
		{
			get
			{
				return this._upload.Entity;
			}
			set
			{
				project previousValue = this._upload.Entity;
				if (((previousValue != value) 
							|| (this._upload.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._upload.Entity = null;
						previousValue.users.Remove(this);
					}
					this._upload.Entity = value;
					if ((value != null))
					{
						value.users.Add(this);
						this._user_id = value.user_id;
					}
					else
					{
						this._user_id = default(int);
					}
					this.SendPropertyChanged("project");
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
		
		private void attach_rankings(ranking entity)
		{
			this.SendPropertyChanging();
			entity.user = this;
		}
		
		private void detach_rankings(ranking entity)
		{
			this.SendPropertyChanging();
			entity.user = null;
		}
	}
}
#pragma warning restore 1591
