using DienThoaiShopConnection;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460650_.Areas.Admin.Models
{
    public class QuanLySanPhamBus
    {
        public static IEnumerable<sanpham> DanhSach()
        {
            var db = new DienThoaiShopConnectionDB();
            return db.Query<sanpham>("select * from sanpham");

        }
        public static sanpham ChiTietSanPham(string id)
        {
            var db = new PetaPoco.Database("DienThoaiShopConnection");
            return db.SingleOrDefault<sanpham>("Select * from sanpham WHERE MaSanPham=@0", id);

        }

        public static void Them(sanpham sp)
        {
            var db = new DienThoaiShopConnectionDB();
            db.Insert(sp);
        }

        public static void Xoa(string id, sanpham sp)
        {

            var db = new PetaPoco.Database("DienThoaiShopConnection");
            sp = ChiTietSanPham(id);
            sp.BiXoa = 1;
            db.Update("sanpham", "MaSanPham", sp);

        }
        public static void CapNhat(string id, sanpham sp)
        {
            var db = new DienThoaiShopConnectionDB();
            db.Update<sanpham>("Set MaSanPham= @0, TenSanPham=@1, hinhanh=@2, Gia=@3, MaLoai=@4, NhaSX=@5, SoLuongTon=@6, MoTa=@7, BiXoa=@7", sp.MaSanPham, sp.TenSanPham, sp.hinhanh, sp.Gia, sp.MaLoai, sp.NhaSX, sp.MoTa, sp.BiXoa, id);
            db.Update(id, sp);
        }
    }
}