using DienThoaiShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460650_.Areas.Admin.Models.Bus
{
    public class QuanLyNhaSanXuatBus
    {
        public static IEnumerable<nhasx> DanhSach()
        {
            var db = new DienThoaiShopConnectionDB();
            return db.Query<nhasx>("select * from nhasx");
        }
        public static nhasx ChiTietSanPham(string id)
        {
            var db = new PetaPoco.Database("DienThoaiShopConnection");
            return db.SingleOrDefault<nhasx>("Select * from nhasx WHERE ID=@0", id);

        }
        public static void Them(nhasx nsx)
        {
            var db = new DienThoaiShopConnectionDB();
            db.Insert(nsx);

        }
        public static void Xoa(string id, nhasx nsx)
        {

            var db = new PetaPoco.Database("DienThoaiShopConnection");
            db.Delete<nhasx>("where ID=@0", id);
        }
        public static void CapNhat(string id, nhasx nsx)
        {
            var db = new DienThoaiShopConnectionDB();
            db.Update<sanpham>("Set TenNSX=@0,HinhAnh=@1", nsx.TenNSX, nsx.HinhAnh, id);
        }

    }
}