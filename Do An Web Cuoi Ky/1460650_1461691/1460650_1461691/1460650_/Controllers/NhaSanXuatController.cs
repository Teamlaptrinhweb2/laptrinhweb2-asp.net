using _1460650_.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460650_.Controllers
{
    public class NhaSanXuatController : Controller
    {
        // GET: NhaSanXuat
        public ActionResult Index(int id)
        {
            var ds = NhaSanXuatBus.ChiTiet(id);
            return View(ds);
        }

        // GET: NhaSanXuat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhaSanXuat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaSanXuat/Create
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

        // GET: NhaSanXuat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NhaSanXuat/Edit/5
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

        // GET: NhaSanXuat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhaSanXuat/Delete/5
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
