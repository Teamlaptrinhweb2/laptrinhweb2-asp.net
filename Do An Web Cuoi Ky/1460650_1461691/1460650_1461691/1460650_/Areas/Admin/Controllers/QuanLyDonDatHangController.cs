﻿using _1460650_.Areas.Admin.Models.Bus;
using DienThoaiShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460650_.Areas.Admin.Controllers
{
    public class QuanLyDonDatHangController : Controller
    {
        // GET: Admin/QuanLyDonDatHang
        public ActionResult Index()
        {
            var dsddh = QuanLyDonDatHang.DanhSach();
            return View(dsddh);
        }

        // GET: Admin/QuanLyDonDatHang/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/QuanLyDonDatHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/QuanLyDonDatHang/Create
        [HttpPost]
        public ActionResult Create(donhang ddh)
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

        // GET: Admin/QuanLyDonDatHang/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/QuanLyDonDatHang/Edit/5
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

        // GET: Admin/QuanLyDonDatHang/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/QuanLyDonDatHang/Delete/5
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
