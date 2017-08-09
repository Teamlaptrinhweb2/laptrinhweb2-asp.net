using _1460650_.Areas.Admin.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460650_.Areas.Admin.Controllers
{
    public class QuanLyNhaSanXuatController : Controller
    {
        // GET: Admin/QuanLyNhaSanXuat
        public ActionResult Index()
        {

            var dsnsx = QuanLyNhaSanXuatBus.DanhSach();
            return View(dsnsx);
        }

        // GET: Admin/QuanLyNhaSanXuat/Details/5
        public ActionResult Details(string id)
        {
            return View(QuanLyNhaSanXuatBus.ChiTietSanPham(id));
        }

        // GET: Admin/QuanLyNhaSanXuat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/QuanLyNhaSanXuat/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/QuanLyNhaSanXuat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/QuanLyNhaSanXuat/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/QuanLyNhaSanXuat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/QuanLyNhaSanXuat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
