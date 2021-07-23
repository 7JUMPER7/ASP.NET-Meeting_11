using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NET_Meeting_11.Models;

namespace ASP.NET_Meeting_11.Controllers
{
    public class CarsController : Controller
    {
        //private GoodsContext db = new GoodsContext();

        // GET: Cars
        //public ActionResult Index()
        //{
        //    var cars = db.Cars.Include(c => c.Manufacturer).Include(c => c.Photos);
        //    return View(cars.ToList());
        //}

        //// GET: Cars/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Car car = db.Cars.Include(t => t.Photos).FirstOrDefault(t => t.Id == id);
        //    if (car == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(car);
        //}

        //// GET: Cars/Create
        //public ActionResult Create()
        //{
        //    ViewBag.ManufacturerId = new SelectList(db.Manufacturers, "Id", "Name");
        //    return View();
        //}

        //// POST: Cars/Create
        //// Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        //// сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Model,Price,Year,ManufacturerId")] Car car, HttpPostedFileBase[] images)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (images != null)
        //        {
        //            foreach (var image in images)
        //            {
        //                Photo photo = new Photo { FileName = image.FileName, ContentType = image.ContentType, PhotoData = GetImageData(image) };
        //                car.Photos.Add(photo);
        //            }
        //        }
        //        db.Cars.Add(car);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.ManufacturerId = new SelectList(db.Manufacturers, "Id", "Name", car.ManufacturerId);
        //    return View(car);
        //}

        //// GET: Cars/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Car car = db.Cars.Find(id);
        //    if (car == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.ManufacturerId = new SelectList(db.Manufacturers, "Id", "Name", car.ManufacturerId);
        //    return View(car);
        //}

        //// POST: Cars/Edit/5
        //// Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        //// сведения см. в разделе https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Model,Price,Year,ManufacturerId")] Car car)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(car).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.ManufacturerId = new SelectList(db.Manufacturers, "Id", "Name", car.ManufacturerId);
        //    return View(car);
        //}

        //// GET: Cars/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Car car = db.Cars.Find(id);
        //    if (car == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(car);
        //}

        //// POST: Cars/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Car car = db.Cars.Find(id);
        //    db.Cars.Remove(car);
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



        //private byte[] GetImageData(HttpPostedFileBase image)
        //{
        //    byte[] buff = null;
        //    using (BinaryReader reader = new BinaryReader(image.InputStream))
        //    {
        //        buff = reader.ReadBytes(image.ContentLength);
        //    }
        //    return buff;
        //}
    }
}
