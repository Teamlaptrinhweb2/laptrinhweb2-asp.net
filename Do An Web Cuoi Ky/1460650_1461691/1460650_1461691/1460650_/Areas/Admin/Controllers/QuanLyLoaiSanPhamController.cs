using _1460650_.Areas.Admin.Models.Bus;
using DienThoaiShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1460650_.Areas.Admin.Controllers
{
    public class QuanLyLoaiSanPhamController : Controller
    {
        // GET: Admin/QuanLyLoaiSanPham
        public ActionResult Index()
        {
            var dslsp = QuanLyLoaiSanPhamBus.DanhSach();
            return View(dslsp);
        }

        // GET: Admin/QuanLyLoaiSanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/QuanLyLoaiSanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/QuanLyLoaiSanPham/Create
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(loaisp lsp)
        {
            try
            {
                QuanLyLoaiSanPhamBus.Them(lsp);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/QuanLyLoaiSanPham/Edit/5
        public ActionResult Edit(string id)
        {
            var dataContext = new PetaPoco.Database("DienThoaiShopConnection");
            var employee = dataContext.SingleOrDefault<sanpham>("Select * from loaisp where ID=@0",
                                                             id);
            return View(employee);
        }

        // POST: Admin/QuanLyLoaiSanPham/Edit/5
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(loaisp lsp)
        {
            try
            {
                // TODO: Add update logic here
                var dataContext = new PetaPoco.Database("DienThoaiShopConnection");
                dataContext.Update("loaisp", "ID", lsp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/QuanLyLoaiSanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/QuanLyLoaiSanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, loaisp lsp)
        {
            try
            {
                // TODO: Add delete logic here
                QuanLyLoaiSanPhamBus.Xoa(id, lsp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
