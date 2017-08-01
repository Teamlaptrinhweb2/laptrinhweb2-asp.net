using DienThoaiShopConnection;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460650_.Areas.Admin.Models
{
    public class QuanLyBus
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

    }
}