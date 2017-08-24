using _1460650_.Models.Bus;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460650_.Controllers
{
    [Authorize]
    public class GioHangController : Controller
    {
        // GET: GioHang
        public ActionResult Index()
        {

            ViewBag.TongTien = GioHangBus.TongTien(User.Identity.GetUserId());
            return View(GioHangBus.DanhSach(User.Identity.GetUserId()));
        }
        [HttpPost]
        public ActionResult ThemGioHang(int masanpham, string tensanpham, int? gia, int? soluong)
        {

            //GioHangBus.Them(maSanPham, User.Identity.GetUserId(), soluong);
            GioHangBus.ThemGioHang(masanpham, User.Identity.GetUserId(), gia, soluong, tensanpham);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult CapNhat(int masanpham, string tensanpham, int? gia, int? soluong)
        {

            //GioHangBus.CapNhat(maSanPham, User.Identity.GetUserId(), soluong);
            GioHangBus.CapNhat(masanpham, User.Identity.GetUserId(), gia, soluong, tensanpham);
            return RedirectToAction("Index");
        }

    }

}