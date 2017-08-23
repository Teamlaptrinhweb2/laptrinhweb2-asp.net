using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460650_.Models.Bus
{
    public class TimKiemBus
    {
        public static IEnumerable<sanpham> Search(string searchString)
        {
            var db = new DienThoaiShopConnectionDB();
            return db.Query<sanpham>("Select * From sanpham Where TenSanPham like '%" + searchString + "%' or Gia like '%" + searchString + "%' or SoLuongTon like '%" + searchString + "%'");
        }
    }
}