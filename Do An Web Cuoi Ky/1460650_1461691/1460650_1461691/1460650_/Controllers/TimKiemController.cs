using _1460650_.Models.Bus;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460650_.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        public ActionResult Index(string searchString, int page = 1, int pageSize = 5)
        {
            var model = TimKiemBus.Search(searchString).ToPagedList(page, pageSize);
            return View(model);
        }

        // GET: TimKiem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimKiem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimKiem/Create
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

        // GET: TimKiem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimKiem/Edit/5
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

        // GET: TimKiem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimKiem/Delete/5
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
