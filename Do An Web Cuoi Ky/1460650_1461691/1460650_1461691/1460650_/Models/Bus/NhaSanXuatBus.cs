using DienThoaiShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460650_.Models.Bus
{
    public class NhaSanXuatBus
    {
        public static IEnumerable<nhasx> DanhSach()
        {
            var db = new DienThoaiShopConnectionDB();
            return db.Query<nhasx>("select * from nhasx");

        }
        public static IEnumerable<sanpham> ChiTiet(int id)
        {
            var db = new DienThoaiShopConnectionDB();
            return db.Query<sanpham>("select * from sanpham where NhaSX = '" + id + "'");

        }
    }
}