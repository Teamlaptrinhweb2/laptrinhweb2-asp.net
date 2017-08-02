using _1460650_.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460650_.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        // GET: LoaiSP
        public ActionResult Index()
        {
            var dslsp = LoaiSP.DanhSach();
            return View(dslsp);
        }

        // GET: LoaiSP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoaiSP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiSP/Create
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

        // GET: LoaiSP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoaiSP/Edit/5
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

        // GET: LoaiSP/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoaiSP/Delete/5
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
