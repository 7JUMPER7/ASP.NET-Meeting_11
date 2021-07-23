using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NET_Meeting_11.Models;

namespace ASP.NET_Meeting_11.Controllers
{
    public class ManufacturersController : Controller
    {
        //private GoodsContext db = new GoodsContext();

        //// GET: Manufacturers
        //public ActionResult Index()
        //{
        //    return View(db.Manufacturers.ToList());
        //}

        //// GET: Manufacturers/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Category manufacturer = db.Manufacturers.Find(id);
        //    if (manufacturer == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(manufacturer);
        //}

        //// GET: Manufacturers/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Manufacturers/Create
        //// Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        //// сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Name")] Category manufacturer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Manufacturers.Add(manufacturer);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(manufacturer);
        //}

        //// GET: Manufacturers/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Category manufacturer = db.Manufacturers.Find(id);
        //    if (manufacturer == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(manufacturer);
        //}

        //// POST: Manufacturers/Edit/5
        //// Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        //// сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Name")] Category manufacturer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(manufacturer).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(manufacturer);
        //}

        //// GET: Manufacturers/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Category manufacturer = db.Manufacturers.Find(id);
        //    if (manufacturer == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(manufacturer);
        //}

        //// POST: Manufacturers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Category manufacturer = db.Manufacturers.Find(id);
        //    db.Manufacturers.Remove(manufacturer);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
