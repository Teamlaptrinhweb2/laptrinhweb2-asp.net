





















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `DienThoaiShopConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=DELL-PC\SQLEXPRESS;Initial Catalog=webbandienthoai;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `True`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace DienThoaiShopConnection
{

	public partial class DienThoaiShopConnectionDB : Database
	{
		public DienThoaiShopConnectionDB() 
			: base("DienThoaiShopConnection")
		{
			CommonConstruct();
		}

		public DienThoaiShopConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			DienThoaiShopConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static DienThoaiShopConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new DienThoaiShopConnectionDB();
        }

		[ThreadStatic] static DienThoaiShopConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static DienThoaiShopConnectionDB repo { get { return DienThoaiShopConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.__MigrationHistory")]



	[PrimaryKey("MigrationId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class __MigrationHistory : DienThoaiShopConnectionDB.Record<__MigrationHistory>  
    {



		[Column] public string MigrationId { get; set; }





		[Column] public string ContextKey { get; set; }





		[Column] public byte[] Model { get; set; }





		[Column] public string ProductVersion { get; set; }



	}

    

	[TableName("dbo.AspNetRoles")]



	[PrimaryKey("Id", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetRole : DienThoaiShopConnectionDB.Record<AspNetRole>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Name { get; set; }



	}

    

	[TableName("dbo.AspNetUserClaims")]



	[PrimaryKey("Id")]




	[ExplicitColumns]

    public partial class AspNetUserClaim : DienThoaiShopConnectionDB.Record<AspNetUserClaim>  
    {



		[Column] public int Id { get; set; }





		[Column] public string UserId { get; set; }





		[Column] public string ClaimType { get; set; }





		[Column] public string ClaimValue { get; set; }



	}

    

	[TableName("dbo.AspNetUserLogins")]



	[PrimaryKey("LoginProvider", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUserLogin : DienThoaiShopConnectionDB.Record<AspNetUserLogin>  
    {



		[Column] public string LoginProvider { get; set; }





		[Column] public string ProviderKey { get; set; }





		[Column] public string UserId { get; set; }



	}

    

	[TableName("dbo.AspNetUserRoles")]



	[PrimaryKey("UserId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUserRole : DienThoaiShopConnectionDB.Record<AspNetUserRole>  
    {



		[Column] public string UserId { get; set; }





		[Column] public string RoleId { get; set; }



	}

    

	[TableName("dbo.AspNetUsers")]



	[PrimaryKey("Id", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUser : DienThoaiShopConnectionDB.Record<AspNetUser>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Email { get; set; }





		[Column] public bool EmailConfirmed { get; set; }





		[Column] public string PasswordHash { get; set; }





		[Column] public string SecurityStamp { get; set; }





		[Column] public string PhoneNumber { get; set; }





		[Column] public bool PhoneNumberConfirmed { get; set; }





		[Column] public bool TwoFactorEnabled { get; set; }





		[Column] public DateTime? LockoutEndDateUtc { get; set; }





		[Column] public bool LockoutEnabled { get; set; }





		[Column] public int AccessFailedCount { get; set; }





		[Column] public string UserName { get; set; }





		[Column] public string HoTen { get; set; }





		[Column] public string DiaChi { get; set; }



	}

    

	[TableName("dbo.BinhLuan")]



	[PrimaryKey("MaBinhLuan")]




	[ExplicitColumns]

    public partial class BinhLuan : DienThoaiShopConnectionDB.Record<BinhLuan>  
    {



		[Column] public int MaBinhLuan { get; set; }





		[Column] public int MaSanPham { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public string TenTaiKhoan { get; set; }





		[Column] public string NoiDung { get; set; }





		[Column] public int TinhTrang { get; set; }





		[Column] public DateTime Ngay { get; set; }



	}

    

	[TableName("dbo.ctdonhang")]



	[PrimaryKey("MaDH", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class ctdonhang : DienThoaiShopConnectionDB.Record<ctdonhang>  
    {



		[Column] public int MaDH { get; set; }





		[Column] public int MaSP { get; set; }





		[Column] public int DonGia { get; set; }





		[Column] public int SoLuong { get; set; }



	}

    

	[TableName("dbo.donhang")]



	[PrimaryKey("ID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class donhang : DienThoaiShopConnectionDB.Record<donhang>  
    {



		[Column] public int ID { get; set; }





		[Column] public string MaKH { get; set; }





		[Column] public DateTime NgayDat { get; set; }





		[Column] public string TinhTrang { get; set; }





		[Column] public string GhiChu { get; set; }



	}

    

	[TableName("dbo.giohang")]



	[PrimaryKey("Username", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class giohang : DienThoaiShopConnectionDB.Record<giohang>  
    {



		[Column] public string Username { get; set; }





		[Column] public int? MaSP { get; set; }





		[Column] public int? DonGia { get; set; }





		[Column] public int? SoLuong { get; set; }



	}

    

	[TableName("dbo.GioHang2")]



	[PrimaryKey("id")]




	[ExplicitColumns]

    public partial class GioHang2 : DienThoaiShopConnectionDB.Record<GioHang2>  
    {



		[Column] public int id { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public int MaSanPham { get; set; }





		[Column] public string TenSanPham { get; set; }





		[Column] public int? SoLuong { get; set; }





		[Column] public int? Gia { get; set; }





		[Column] public int? TongTien { get; set; }



	}

    

	[TableName("dbo.hoadon")]



	[PrimaryKey("MaDH", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class hoadon : DienThoaiShopConnectionDB.Record<hoadon>  
    {



		[Column] public int MaDH { get; set; }





		[Column] public int TongTien { get; set; }





		[Column] public DateTime NgayGiao { get; set; }



	}

    

	[TableName("dbo.loaisp")]



	[PrimaryKey("ID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class loaisp : DienThoaiShopConnectionDB.Record<loaisp>  
    {



		[Column] public int ID { get; set; }





		[Column] public string TenLoai { get; set; }





		[Column] public string hinhanh { get; set; }



	}

    

	[TableName("dbo.nhasx")]



	[PrimaryKey("ID", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class nhasx : DienThoaiShopConnectionDB.Record<nhasx>  
    {



		[Column] public int ID { get; set; }





		[Column] public string TenNSX { get; set; }





		[Column] public string HinhAnh { get; set; }



	}

    

	[TableName("dbo.sanpham")]



	[PrimaryKey("MaSanPham")]




	[ExplicitColumns]

    public partial class sanpham : DienThoaiShopConnectionDB.Record<sanpham>  
    {



		[Column] public int MaSanPham { get; set; }





		[Column] public string TenSanPham { get; set; }





		[Column] public string hinhanh { get; set; }





		[Column] public int Gia { get; set; }





		[Column] public int MaLoai { get; set; }





		[Column] public int NhaSX { get; set; }





		[Column] public int SoLuongTon { get; set; }





		[Column] public string MoTa { get; set; }





		[Column] public int BiXoa { get; set; }



	}

    

	[TableName("dbo.sysdiagrams")]



	[PrimaryKey("diagram_id")]




	[ExplicitColumns]

    public partial class sysdiagram : DienThoaiShopConnectionDB.Record<sysdiagram>  
    {



		[Column] public string name { get; set; }





		[Column] public int principal_id { get; set; }





		[Column] public int diagram_id { get; set; }





		[Column] public int? version { get; set; }





		[Column] public byte[] definition { get; set; }



	}

    

	[TableName("dbo.taikhoan")]



	[PrimaryKey("Username", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class taikhoan : DienThoaiShopConnectionDB.Record<taikhoan>  
    {



		[Column] public string Username { get; set; }





		[Column] public string Pass { get; set; }





		[Column] public string HoTen { get; set; }





		[Column] public string DiaChi { get; set; }





		[Column] public string SDT { get; set; }





		[Column] public string Level { get; set; }



	}

    

	[TableName("dbo.v_GioHang")]




	[ExplicitColumns]

    public partial class v_GioHang : DienThoaiShopConnectionDB.Record<v_GioHang>  
    {



		[Column] public int id { get; set; }





		[Column] public string MaTaiKhoan { get; set; }





		[Column] public int MaSanPham { get; set; }





		[Column] public int SoLuong { get; set; }





		[Column] public int Gia { get; set; }





		[Column] public int TongTien { get; set; }





		[Column] public string TenSanPham { get; set; }



	}


}