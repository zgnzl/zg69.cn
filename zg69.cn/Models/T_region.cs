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

namespace ZG69.Model
{

	/// <summary>
	/// 实体类T_region 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("T_region")]
	[Serializable]
	public partial class T_region : Entity 
	{
		#region Model
		private string _ID;
		private string _Name;
		private string _ParentId;
		private string _ShortName;
		private string _LevelType;
		private string _CityCode;
		private string _ZipCode;
		private string _MergerName;
		private string _lng;
		private string _Lat;
		private string _Pinyin;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			get{ return _ID; }
			set
			{
				this.OnPropertyValueChange(_.ID,_ID,value);
				this._ID=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange(_.Name,_Name,value);
				this._Name=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ParentId
		{
			get{ return _ParentId; }
			set
			{
				this.OnPropertyValueChange(_.ParentId,_ParentId,value);
				this._ParentId=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShortName
		{
			get{ return _ShortName; }
			set
			{
				this.OnPropertyValueChange(_.ShortName,_ShortName,value);
				this._ShortName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LevelType
		{
			get{ return _LevelType; }
			set
			{
				this.OnPropertyValueChange(_.LevelType,_LevelType,value);
				this._LevelType=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CityCode
		{
			get{ return _CityCode; }
			set
			{
				this.OnPropertyValueChange(_.CityCode,_CityCode,value);
				this._CityCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZipCode
		{
			get{ return _ZipCode; }
			set
			{
				this.OnPropertyValueChange(_.ZipCode,_ZipCode,value);
				this._ZipCode=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MergerName
		{
			get{ return _MergerName; }
			set
			{
				this.OnPropertyValueChange(_.MergerName,_MergerName,value);
				this._MergerName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lng
		{
			get{ return _lng; }
			set
			{
				this.OnPropertyValueChange(_.lng,_lng,value);
				this._lng=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Lat
		{
			get{ return _Lat; }
			set
			{
				this.OnPropertyValueChange(_.Lat,_Lat,value);
				this._Lat=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pinyin
		{
			get{ return _Pinyin; }
			set
			{
				this.OnPropertyValueChange(_.Pinyin,_Pinyin,value);
				this._Pinyin=value;
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
				_.ID};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.ID,
				_.Name,
				_.ParentId,
				_.ShortName,
				_.LevelType,
				_.CityCode,
				_.ZipCode,
				_.MergerName,
				_.lng,
				_.Lat,
				_.Pinyin};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._ID,
				this._Name,
				this._ParentId,
				this._ShortName,
				this._LevelType,
				this._CityCode,
				this._ZipCode,
				this._MergerName,
				this._lng,
				this._Lat,
				this._Pinyin};
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
			public readonly static Field All = new Field("*","T_region");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ID = new Field("ID","T_region","ID");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("Name","T_region","Name");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ParentId = new Field("ParentId","T_region","ParentId");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ShortName = new Field("ShortName","T_region","ShortName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field LevelType = new Field("LevelType","T_region","LevelType");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CityCode = new Field("CityCode","T_region","CityCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ZipCode = new Field("ZipCode","T_region","ZipCode");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MergerName = new Field("MergerName","T_region","MergerName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field lng = new Field("lng","T_region","lng");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Lat = new Field("Lat","T_region","Lat");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Pinyin = new Field("Pinyin","T_region","Pinyin");
		}
		#endregion


	}
}

