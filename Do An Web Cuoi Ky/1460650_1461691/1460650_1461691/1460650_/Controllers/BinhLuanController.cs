﻿using _1460650_.Models.Bus;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460650_.Controllers
{
    public class BinhLuanController : Controller
    {
        [Authorize]
        // GET: BinhLuan
        public ActionResult Index(int MaSanPham)
        {
            ViewBag.MaSanPham = MaSanPham;
            return View(BinhLuanBus.DanhSach(MaSanPham));
        }
        public ActionResult Create(int MaSanPham = 0, string NoiDung = "")
        {
            if (MaSanPham == 0)
            {
                return Redirect("/");
            }
            BinhLuanBus.Them(MaSanPham, User.Identity.GetUserId(), User.Identity.Name, NoiDung);

            //User.Identity.
            return RedirectToAction("Details", "SanPham", new { Id = MaSanPham });
        }
    }
}