using DienThoaiShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1460650_.Models.Bus
{
    public class LoaiSP
    {
        public static IEnumerable<loaisp> DanhSach()
        {
            var db = new DienThoaiShopConnectionDB();
            return db.Query<loaisp>("select * from loaisp");
        }
        public static loaisp ChiTietSanPham(string id)
        {
            var db = new PetaPoco.Database("DienThoaiShopConnection");
            return db.SingleOrDefault<loaisp>("Select * from loaisp WHERE ID=@0", id);

        }
    }
}