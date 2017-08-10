using _1460650_.Areas.Admin.Models.Bus;
using DienThoaiShopConnection;
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
        [HttpPost, ValidateInput(false)]
        public ActionResult Create(nhasx nsx)
        {
            try
            {
                if (HttpContext.Request.Files.Count > 0)
                {
                    var hpf = HttpContext.Request.Files[0];
                    if (hpf.ContentLength > 0)
                    {
                        string filename = Guid.NewGuid().ToString();

                        string fullPathWithFileName = "/images/" + filename + ".jpg";
                        hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                        nsx.HinhAnh = fullPathWithFileName;
                    }
                }
                // TODO: Add insert logic here
                QuanLyNhaSanXuatBus.Them(nsx);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/QuanLyNhaSanXuat/Edit/5
        public ActionResult Edit(string id)
        {
            var dataContext = new PetaPoco.Database("DienThoaiShopConnection");
            var employee = dataContext.SingleOrDefault<sanpham>("Select * from nhasx where ID=@0",
                                                             id);
            return View(employee);
        }

        // POST: Admin/QuanLyNhaSanXuat/Edit/5
        [HttpPost, ValidateInput(false)]
        public ActionResult Edit(nhasx nsx)
        {
            try
            {
                    if (HttpContext.Request.Files.Count > 0)
                    {
                        var hpf = HttpContext.Request.Files[0];
                        if (hpf.ContentLength > 0)
                        {
                            string filename = Guid.NewGuid().ToString();

                            string fullPathWithFileName = "/images/" + filename + ".jpg";
                            hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                            nsx.HinhAnh = fullPathWithFileName;
                        }
                    }
                // TODO: Add update logic here
                var dataContext = new PetaPoco.Database("DienThoaiShopConnection");
                dataContext.Update("nhasx", "ID", nsx);
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
        public ActionResult Delete(string id, nhasx nsx)
        {
            try
            {
                // TODO: Add delete logic here
                QuanLyNhaSanXuatBus.Xoa(id, nsx);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
