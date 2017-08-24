using DienThoaiShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460650_.Areas.Admin.Models.Bus
{
    public class QuanLyDonDatHang
    {
         public static IEnumerable<donhang> DanhSach()
        {
            var db = new DienThoaiShopConnectionDB();
            return db.Query<donhang>("select * from donhang");
        }
        public static donhang ChiTietDonDatHang(string id)
        {
            var db = new PetaPoco.Database("DienThoaiShopConnection");
            return db.SingleOrDefault<donhang>("Select * from donhang WHERE ID=@0", id);

        }
        public static void Them(donhang ddh)
        {
            var db = new DienThoaiShopConnectionDB();
            db.Insert(ddh);

        }
    }
}