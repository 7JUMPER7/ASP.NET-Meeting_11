using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NET_Meeting_11.DAL;
using ASP.NET_Meeting_11.Models;
using ASP.NET_Meeting_11.ViewModel;
using PagedList;

namespace ASP.NET_Meeting_11.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IUnitOfWork repository;
        public GoodsController(IUnitOfWork unitOfWork)
        {
            this.repository = unitOfWork;
        }

        // GET: Goods
        public ActionResult Index(int? page, int? category)
        {
            int pageNumber = page.HasValue ? page.Value : 1;
            int pageSize = 3;

            var goods = repository.Goods.GetList();
            if (category.HasValue && category != 0)
            {
                goods = goods.Where(g => g.CategoryId == category);
            }

            GoodIndexViewModel viewModel = new GoodIndexViewModel { Goods = goods.ToList().ToPagedList(pageNumber, pageSize), Categories = repository.Goods.GetCategories("Id", "CategoryName", true) };
            return View(viewModel);
        }

        // GET: Goods/Details/5
        public ActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Good buf = repository.Goods.GetById(id.Value);
                if (buf != null)
                {
                    return View(buf);
                }
            }
            return HttpNotFound();
        }

        // GET: Goods/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = repository.Goods.GetCategories("Id", "CategoryName");
            return View();
        }

        // POST: Goods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Price,CategoryId")] Good good, HttpPostedFileBase[] images)
        {
            if (ModelState.IsValid)
            {
                if (images != null)
                {
                    foreach (var item in images)
                    {
                        if (item != null)
                        {
                            Photo buf = new Photo { FileName = item.FileName, ContentType = item.ContentType, PhotoData = GetImageBytes(item), Good = good };
                            good.Photos.Add(buf);
                        }
                    }
                }
                repository.Goods.Create(good);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = repository.Goods.GetCategories("Id", "CategoryName", good.CategoryId);
            return View(good);
        }

        // GET: Goods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                Good buf = repository.Goods.GetById(id.Value);
                ViewBag.CategoryId = repository.Goods.GetCategories("Id", "CategoryName", buf.CategoryId);
                return View(buf);
            }
            return HttpNotFound();
        }

        // POST: Goods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Price,CategoryId,Photos")] Good good, HttpPostedFileBase[] images)
        {
            if (ModelState.IsValid)
            {
                if (images != null)
                {
                    repository.Goods.RemoveImagesOfGood(good);
                    foreach (var item in images)
                    {
                        if (item != null)
                        {
                            Photo buf = new Photo { FileName = item.FileName, ContentType = item.ContentType, PhotoData = GetImageBytes(item), GoodId = good.Id };
                            repository.Goods.AddPhoto(buf);
                        }
                    }
                }
                repository.Goods.Update(good);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = repository.Goods.GetCategories("Id", "CategoryName", good.CategoryId);
            return View(good);
        }

        // GET: Goods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                Good buf = repository.Goods.GetById(id.Value);
                if (buf != null)
                {
                    return View(buf);
                }
            }
            return HttpNotFound();
        }

        // POST: Goods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repository.Goods.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repository.Dispose();
            }
            base.Dispose(disposing);
        }



        private byte[] GetImageBytes(HttpPostedFileBase image)
        {
            byte[] buf = null;
            using (BinaryReader reader = new BinaryReader(image.InputStream))
            {
                buf = reader.ReadBytes(image.ContentLength);
            }
            return buf;
        }
    }
}
