﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace Model
{

    /// <summary>
    /// 实体类TestTable 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("TestTable")]
    [Serializable]
    public partial class TestTable : Entity
    {
        #region Model
        private Guid _Id;
        private string _Name;
        private string _IDNumber;
        private string _MobilePhone;
        private bool? _Test1;
        private int? _Test2;
        private string _Test3;
        private DateTime _CreateTime;
        private decimal? _T1;
        private decimal _T2;
        private int _T3;
        private bool _T4;
        private DateTime? _T5;
        private decimal? _T6;
        private decimal _T7;
        private double? _T8;
        private double _T9;
        private string _T10;
        private string _T11;
        private string _T12;
        private string _T13;
        /// <summary>
        /// 
        /// </summary>
        public Guid Id
        {
            get { return _Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange(_.Name, _Name, value);
                this._Name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IDNumber
        {
            get { return _IDNumber; }
            set
            {
                this.OnPropertyValueChange(_.IDNumber, _IDNumber, value);
                this._IDNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MobilePhone
        {
            get { return _MobilePhone; }
            set
            {
                this.OnPropertyValueChange(_.MobilePhone, _MobilePhone, value);
                this._MobilePhone = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? Test1
        {
            get { return _Test1; }
            set
            {
                this.OnPropertyValueChange(_.Test1, _Test1, value);
                this._Test1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Test2
        {
            get { return _Test2; }
            set
            {
                this.OnPropertyValueChange(_.Test2, _Test2, value);
                this._Test2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Test3
        {
            get { return _Test3; }
            set
            {
                this.OnPropertyValueChange(_.Test3, _Test3, value);
                this._Test3 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            get { return _CreateTime; }
            set
            {
                this.OnPropertyValueChange(_.CreateTime, _CreateTime, value);
                this._CreateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? T1
        {
            get { return _T1; }
            set
            {
                this.OnPropertyValueChange(_.T1, _T1, value);
                this._T1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal T2
        {
            get { return _T2; }
            set
            {
                this.OnPropertyValueChange(_.T2, _T2, value);
                this._T2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int T3
        {
            get { return _T3; }
            set
            {
                this.OnPropertyValueChange(_.T3, _T3, value);
                this._T3 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool T4
        {
            get { return _T4; }
            set
            {
                this.OnPropertyValueChange(_.T4, _T4, value);
                this._T4 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? T5
        {
            get { return _T5; }
            set
            {
                this.OnPropertyValueChange(_.T5, _T5, value);
                this._T5 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? T6
        {
            get { return _T6; }
            set
            {
                this.OnPropertyValueChange(_.T6, _T6, value);
                this._T6 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal T7
        {
            get { return _T7; }
            set
            {
                this.OnPropertyValueChange(_.T7, _T7, value);
                this._T7 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double? T8
        {
            get { return _T8; }
            set
            {
                this.OnPropertyValueChange(_.T8, _T8, value);
                this._T8 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public double T9
        {
            get { return _T9; }
            set
            {
                this.OnPropertyValueChange(_.T9, _T9, value);
                this._T9 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string T10
        {
            get { return _T10; }
            set
            {
                this.OnPropertyValueChange(_.T10, _T10, value);
                this._T10 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string T11
        {
            get { return _T11; }
            set
            {
                this.OnPropertyValueChange(_.T11, _T11, value);
                this._T11 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string T12
        {
            get { return _T12; }
            set
            {
                this.OnPropertyValueChange(_.T12, _T12, value);
                this._T12 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string T13
        {
            get { return _T13; }
            set
            {
                this.OnPropertyValueChange(_.T13, _T13, value);
                this._T13 = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.Id};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.Id,
				_.Name,
				_.IDNumber,
				_.MobilePhone,
				_.Test1,
				_.Test2,
				_.Test3,
				_.CreateTime,
				_.T1,
				_.T2,
				_.T3,
				_.T4,
				_.T5,
				_.T6,
				_.T7,
				_.T8,
				_.T9,
				_.T10,
				_.T11,
				_.T12,
				_.T13};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._Id,
				this._Name,
				this._IDNumber,
				this._MobilePhone,
				this._Test1,
				this._Test2,
				this._Test3,
				this._CreateTime,
				this._T1,
				this._T2,
				this._T3,
				this._T4,
				this._T5,
				this._T6,
				this._T7,
				this._T8,
				this._T9,
				this._T10,
				this._T11,
				this._T12,
				this._T13};
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "TestTable");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Id = new Field("Id", "TestTable", "Id");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Name = new Field("Name", "TestTable", "Name");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IDNumber = new Field("IDNumber", "TestTable", "IDNumber");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MobilePhone = new Field("MobilePhone", "TestTable", "MobilePhone");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Test1 = new Field("Test1", "TestTable", "Test1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Test2 = new Field("Test2", "TestTable", "Test2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Test3 = new Field("Test3", "TestTable", "Test3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CreateTime = new Field("CreateTime", "TestTable", "CreateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T1 = new Field("T1", "TestTable", "T1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T2 = new Field("T2", "TestTable", "T2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T3 = new Field("T3", "TestTable", "T3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T4 = new Field("T4", "TestTable", "T4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T5 = new Field("T5", "TestTable", "T5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T6 = new Field("T6", "TestTable", "T6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T7 = new Field("T7", "TestTable", "T7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T8 = new Field("T8", "TestTable", "T8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T9 = new Field("T9", "TestTable", "T9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T10 = new Field("T10", "TestTable", "T10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T11 = new Field("T11", "TestTable", "T11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T12 = new Field("T12", "TestTable", "T12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field T13 = new Field("T13", "TestTable", "T13");
        }
        #endregion


    }
}

