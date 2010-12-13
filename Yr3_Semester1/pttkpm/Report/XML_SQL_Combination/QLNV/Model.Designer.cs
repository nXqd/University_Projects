﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace QLNV
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class dbSqliteEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new dbSqliteEntities object using the connection string found in the 'dbSqliteEntities' section of the application configuration file.
        /// </summary>
        public dbSqliteEntities() : base("name=dbSqliteEntities", "dbSqliteEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dbSqliteEntities object.
        /// </summary>
        public dbSqliteEntities(string connectionString) : base(connectionString, "dbSqliteEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dbSqliteEntities object.
        /// </summary>
        public dbSqliteEntities(EntityConnection connection) : base(connection, "dbSqliteEntities")
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
        public ObjectSet<NhanVien> NhanViens
        {
            get
            {
                if ((_NhanViens == null))
                {
                    _NhanViens = base.CreateObjectSet<NhanVien>("NhanViens");
                }
                return _NhanViens;
            }
        }
        private ObjectSet<NhanVien> _NhanViens;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the NhanViens EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToNhanViens(NhanVien nhanVien)
        {
            base.AddObject("NhanViens", nhanVien);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="dbSqliteModel", Name="NhanVien")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class NhanVien : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new NhanVien object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="hoTen">Initial value of the hoTen property.</param>
        /// <param name="ngaySinh">Initial value of the ngaySinh property.</param>
        /// <param name="diaChi">Initial value of the diaChi property.</param>
        /// <param name="tienLuong">Initial value of the tienLuong property.</param>
        /// <param name="ngheNghiep">Initial value of the ngheNghiep property.</param>
        /// <param name="thuocTinhKhac">Initial value of the thuocTinhKhac property.</param>
        public static NhanVien CreateNhanVien(global::System.Int32 id, global::System.String hoTen, global::System.DateTime ngaySinh, global::System.String diaChi, global::System.Double tienLuong, global::System.String ngheNghiep, global::System.String thuocTinhKhac)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.ID = id;
            nhanVien.hoTen = hoTen;
            nhanVien.ngaySinh = ngaySinh;
            nhanVien.diaChi = diaChi;
            nhanVien.tienLuong = tienLuong;
            nhanVien.ngheNghiep = ngheNghiep;
            nhanVien.thuocTinhKhac = thuocTinhKhac;
            return nhanVien;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String hoTen
        {
            get
            {
                return _hoTen;
            }
            set
            {
                if (_hoTen != value)
                {
                    OnhoTenChanging(value);
                    ReportPropertyChanging("hoTen");
                    _hoTen = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("hoTen");
                    OnhoTenChanged();
                }
            }
        }
        private global::System.String _hoTen;
        partial void OnhoTenChanging(global::System.String value);
        partial void OnhoTenChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ngaySinh
        {
            get
            {
                return _ngaySinh;
            }
            set
            {
                if (_ngaySinh != value)
                {
                    OnngaySinhChanging(value);
                    ReportPropertyChanging("ngaySinh");
                    _ngaySinh = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ngaySinh");
                    OnngaySinhChanged();
                }
            }
        }
        private global::System.DateTime _ngaySinh;
        partial void OnngaySinhChanging(global::System.DateTime value);
        partial void OnngaySinhChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String diaChi
        {
            get
            {
                return _diaChi;
            }
            set
            {
                if (_diaChi != value)
                {
                    OndiaChiChanging(value);
                    ReportPropertyChanging("diaChi");
                    _diaChi = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("diaChi");
                    OndiaChiChanged();
                }
            }
        }
        private global::System.String _diaChi;
        partial void OndiaChiChanging(global::System.String value);
        partial void OndiaChiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double tienLuong
        {
            get
            {
                return _tienLuong;
            }
            set
            {
                if (_tienLuong != value)
                {
                    OntienLuongChanging(value);
                    ReportPropertyChanging("tienLuong");
                    _tienLuong = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("tienLuong");
                    OntienLuongChanged();
                }
            }
        }
        private global::System.Double _tienLuong;
        partial void OntienLuongChanging(global::System.Double value);
        partial void OntienLuongChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ngheNghiep
        {
            get
            {
                return _ngheNghiep;
            }
            set
            {
                if (_ngheNghiep != value)
                {
                    OnngheNghiepChanging(value);
                    ReportPropertyChanging("ngheNghiep");
                    _ngheNghiep = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("ngheNghiep");
                    OnngheNghiepChanged();
                }
            }
        }
        private global::System.String _ngheNghiep;
        partial void OnngheNghiepChanging(global::System.String value);
        partial void OnngheNghiepChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String thuocTinhKhac
        {
            get
            {
                return _thuocTinhKhac;
            }
            set
            {
                if (_thuocTinhKhac != value)
                {
                    OnthuocTinhKhacChanging(value);
                    ReportPropertyChanging("thuocTinhKhac");
                    _thuocTinhKhac = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("thuocTinhKhac");
                    OnthuocTinhKhacChanged();
                }
            }
        }
        private global::System.String _thuocTinhKhac;
        partial void OnthuocTinhKhacChanging(global::System.String value);
        partial void OnthuocTinhKhacChanged();

        #endregion
    
    }

    #endregion
    
}
