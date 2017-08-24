using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460650_.Models.Bus
{
    public class GioHangBus
    {
        public static IEnumerable<GioHang2> DanhSach(string mataikhoan)
        {
            using (var sql = new DienThoaiShopConnectionDB())
            {
                return sql.Query<GioHang2>("select * from GioHang2 where  MaTaiKhoan = '" + mataikhoan + "'");
            }
        }
        public static void ThemGioHang(int masanpham, string mataikhoan, int? gia, int? soluong, string tensanpham)
        {
            using (var sql = new DienThoaiShopConnectionDB())
            {
                var x = sql.Query<GioHang2>("select * from GioHang2 Where MaTaiKhoan = '" + mataikhoan + "'and MaSanPham ='" + masanpham + "'").ToList();
                if (x.Count() > 0)
                {
                    //update so luong
                    int a = (int)x.ElementAt(0).SoLuong + soluong;
                    CapNhat(masanpham, mataikhoan, gia, a, tensanpham);
                }
                else
                {

                    GioHang2 giohang = new GioHang2()
                    {
                        MaSanPham = masanpham,
                        MaTaiKhoan = mataikhoan,
                        Gia = gia,
                        SoLuong = soluong,
                        TenSanPham = tensanpham,
                        TongTien = gia * soluong
                    };
                    sql.Insert(giohang);
                }
            }
        }
        public static int TongTien(string mataikhoan)
        {
            using (var sql = new DienThoaiShopConnectionDB())
            {
                return sql.Query<int>("select sum(TongTien) from GioHang2 where MaTaiKhoan = '" + mataikhoan + "'").FirstOrDefault();
            }
        }
          public static void CapNhat(int masanpham, string mataikhoan, int? gia, int? soluong, string tensanpham)
        {
            using (var sql = new DienThoaiShopConnectionDB())
            {
                GioHang2 giohang = new GioHang2()
                {
                    MaSanPham = masanpham,
                    MaTaiKhoan = mataikhoan,
                    Gia = gia,
                    SoLuong = soluong,
                    TenSanPham = tensanpham,
                    TongTien = gia * soluong

                };
                var tamp = sql.Query<GioHang2>("select id from GioHang2 Where MaTaiKhoan = '" + mataikhoan + "'and MaSanPham ='" + masanpham + "'").FirstOrDefault();
                sql.Update(giohang, tamp.id);
            }

        }
        public static void Xoa(int masanpham, string mataikhoan)
        {
            using (var sql = new DienThoaiShopConnectionDB())
            {
                var a = sql.Query<GioHang2>("select * from GioHang2 Where MaTaiKhoan = '" + mataikhoan + "'and MaSanPham ='" + masanpham + "'").FirstOrDefault();
                sql.Delete(a);
            }
        }
    }
}