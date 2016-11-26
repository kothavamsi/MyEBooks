﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace MyEBooks.WebApi
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MyEbooksEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MyEbooksEntities object using the connection string found in the 'MyEbooksEntities' section of the application configuration file.
        /// </summary>
        public MyEbooksEntities() : base("name=MyEbooksEntities", "MyEbooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MyEbooksEntities object.
        /// </summary>
        public MyEbooksEntities(string connectionString) : base(connectionString, "MyEbooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MyEbooksEntities object.
        /// </summary>
        public MyEbooksEntities(EntityConnection connection) : base(connection, "MyEbooksEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PopularAuthorTag> PopularAuthorTags
        {
            get
            {
                if ((_PopularAuthorTags == null))
                {
                    _PopularAuthorTags = base.CreateObjectSet<PopularAuthorTag>("PopularAuthorTags");
                }
                return _PopularAuthorTags;
            }
        }
        private ObjectSet<PopularAuthorTag> _PopularAuthorTags;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PopularPublisherTag> PopularPublisherTags
        {
            get
            {
                if ((_PopularPublisherTags == null))
                {
                    _PopularPublisherTags = base.CreateObjectSet<PopularPublisherTag>("PopularPublisherTags");
                }
                return _PopularPublisherTags;
            }
        }
        private ObjectSet<PopularPublisherTag> _PopularPublisherTags;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PopularSearchTag> PopularSearchTags
        {
            get
            {
                if ((_PopularSearchTags == null))
                {
                    _PopularSearchTags = base.CreateObjectSet<PopularSearchTag>("PopularSearchTags");
                }
                return _PopularSearchTags;
            }
        }
        private ObjectSet<PopularSearchTag> _PopularSearchTags;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PopularAuthorTags EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPopularAuthorTags(PopularAuthorTag popularAuthorTag)
        {
            base.AddObject("PopularAuthorTags", popularAuthorTag);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PopularPublisherTags EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPopularPublisherTags(PopularPublisherTag popularPublisherTag)
        {
            base.AddObject("PopularPublisherTags", popularPublisherTag);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the PopularSearchTags EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPopularSearchTags(PopularSearchTag popularSearchTag)
        {
            base.AddObject("PopularSearchTags", popularSearchTag);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MyEbooksModel", Name="PopularAuthorTag")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PopularAuthorTag : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PopularAuthorTag object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="count">Initial value of the Count property.</param>
        /// <param name="createdOn">Initial value of the CreatedOn property.</param>
        /// <param name="lastSearchedOn">Initial value of the LastSearchedOn property.</param>
        public static PopularAuthorTag CreatePopularAuthorTag(global::System.Int32 id, global::System.String author, global::System.Int32 count, global::System.DateTime createdOn, global::System.DateTime lastSearchedOn)
        {
            PopularAuthorTag popularAuthorTag = new PopularAuthorTag();
            popularAuthorTag.Id = id;
            popularAuthorTag.Author = author;
            popularAuthorTag.Count = count;
            popularAuthorTag.CreatedOn = createdOn;
            popularAuthorTag.LastSearchedOn = lastSearchedOn;
            return popularAuthorTag;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Count
        {
            get
            {
                return _Count;
            }
            set
            {
                OnCountChanging(value);
                ReportPropertyChanging("Count");
                _Count = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Count");
                OnCountChanged();
            }
        }
        private global::System.Int32 _Count;
        partial void OnCountChanging(global::System.Int32 value);
        partial void OnCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedOn
        {
            get
            {
                return _CreatedOn;
            }
            set
            {
                OnCreatedOnChanging(value);
                ReportPropertyChanging("CreatedOn");
                _CreatedOn = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreatedOn");
                OnCreatedOnChanged();
            }
        }
        private global::System.DateTime _CreatedOn;
        partial void OnCreatedOnChanging(global::System.DateTime value);
        partial void OnCreatedOnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastSearchedOn
        {
            get
            {
                return _LastSearchedOn;
            }
            set
            {
                OnLastSearchedOnChanging(value);
                ReportPropertyChanging("LastSearchedOn");
                _LastSearchedOn = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastSearchedOn");
                OnLastSearchedOnChanged();
            }
        }
        private global::System.DateTime _LastSearchedOn;
        partial void OnLastSearchedOnChanging(global::System.DateTime value);
        partial void OnLastSearchedOnChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MyEbooksModel", Name="PopularPublisherTag")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PopularPublisherTag : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PopularPublisherTag object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="publisher">Initial value of the Publisher property.</param>
        /// <param name="count">Initial value of the Count property.</param>
        /// <param name="createdOn">Initial value of the CreatedOn property.</param>
        /// <param name="lastSearchedOn">Initial value of the LastSearchedOn property.</param>
        public static PopularPublisherTag CreatePopularPublisherTag(global::System.Int32 id, global::System.String publisher, global::System.Int32 count, global::System.DateTime createdOn, global::System.DateTime lastSearchedOn)
        {
            PopularPublisherTag popularPublisherTag = new PopularPublisherTag();
            popularPublisherTag.Id = id;
            popularPublisherTag.Publisher = publisher;
            popularPublisherTag.Count = count;
            popularPublisherTag.CreatedOn = createdOn;
            popularPublisherTag.LastSearchedOn = lastSearchedOn;
            return popularPublisherTag;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Publisher
        {
            get
            {
                return _Publisher;
            }
            set
            {
                OnPublisherChanging(value);
                ReportPropertyChanging("Publisher");
                _Publisher = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Publisher");
                OnPublisherChanged();
            }
        }
        private global::System.String _Publisher;
        partial void OnPublisherChanging(global::System.String value);
        partial void OnPublisherChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Count
        {
            get
            {
                return _Count;
            }
            set
            {
                OnCountChanging(value);
                ReportPropertyChanging("Count");
                _Count = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Count");
                OnCountChanged();
            }
        }
        private global::System.Int32 _Count;
        partial void OnCountChanging(global::System.Int32 value);
        partial void OnCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedOn
        {
            get
            {
                return _CreatedOn;
            }
            set
            {
                OnCreatedOnChanging(value);
                ReportPropertyChanging("CreatedOn");
                _CreatedOn = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreatedOn");
                OnCreatedOnChanged();
            }
        }
        private global::System.DateTime _CreatedOn;
        partial void OnCreatedOnChanging(global::System.DateTime value);
        partial void OnCreatedOnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastSearchedOn
        {
            get
            {
                return _LastSearchedOn;
            }
            set
            {
                OnLastSearchedOnChanging(value);
                ReportPropertyChanging("LastSearchedOn");
                _LastSearchedOn = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastSearchedOn");
                OnLastSearchedOnChanged();
            }
        }
        private global::System.DateTime _LastSearchedOn;
        partial void OnLastSearchedOnChanging(global::System.DateTime value);
        partial void OnLastSearchedOnChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MyEbooksModel", Name="PopularSearchTag")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class PopularSearchTag : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new PopularSearchTag object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="keyword">Initial value of the Keyword property.</param>
        /// <param name="count">Initial value of the Count property.</param>
        /// <param name="createdOn">Initial value of the CreatedOn property.</param>
        /// <param name="lastSearchedOn">Initial value of the LastSearchedOn property.</param>
        public static PopularSearchTag CreatePopularSearchTag(global::System.Int32 id, global::System.String keyword, global::System.Int32 count, global::System.DateTime createdOn, global::System.DateTime lastSearchedOn)
        {
            PopularSearchTag popularSearchTag = new PopularSearchTag();
            popularSearchTag.Id = id;
            popularSearchTag.Keyword = keyword;
            popularSearchTag.Count = count;
            popularSearchTag.CreatedOn = createdOn;
            popularSearchTag.LastSearchedOn = lastSearchedOn;
            return popularSearchTag;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Keyword
        {
            get
            {
                return _Keyword;
            }
            set
            {
                OnKeywordChanging(value);
                ReportPropertyChanging("Keyword");
                _Keyword = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Keyword");
                OnKeywordChanged();
            }
        }
        private global::System.String _Keyword;
        partial void OnKeywordChanging(global::System.String value);
        partial void OnKeywordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Count
        {
            get
            {
                return _Count;
            }
            set
            {
                OnCountChanging(value);
                ReportPropertyChanging("Count");
                _Count = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Count");
                OnCountChanged();
            }
        }
        private global::System.Int32 _Count;
        partial void OnCountChanging(global::System.Int32 value);
        partial void OnCountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedOn
        {
            get
            {
                return _CreatedOn;
            }
            set
            {
                OnCreatedOnChanging(value);
                ReportPropertyChanging("CreatedOn");
                _CreatedOn = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreatedOn");
                OnCreatedOnChanged();
            }
        }
        private global::System.DateTime _CreatedOn;
        partial void OnCreatedOnChanging(global::System.DateTime value);
        partial void OnCreatedOnChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastSearchedOn
        {
            get
            {
                return _LastSearchedOn;
            }
            set
            {
                OnLastSearchedOnChanging(value);
                ReportPropertyChanging("LastSearchedOn");
                _LastSearchedOn = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastSearchedOn");
                OnLastSearchedOnChanged();
            }
        }
        private global::System.DateTime _LastSearchedOn;
        partial void OnLastSearchedOnChanging(global::System.DateTime value);
        partial void OnLastSearchedOnChanged();

        #endregion

    
    }

    #endregion

    
}
