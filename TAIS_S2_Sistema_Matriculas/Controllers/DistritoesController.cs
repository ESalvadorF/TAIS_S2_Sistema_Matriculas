using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TAIS_S2_Sistema_Matriculas.Context;
using TAIS_S2_Sistema_Matriculas.Models;

namespace TAIS_S2_Sistema_Matriculas.Controllers
{
    public class DistritoesController : Controller
    {
        private DataStore db = new DataStore();

        // GET: Distritoes
        public ActionResult Index()
        {
            var distritoes = db.Distritoes.Include(d => d.Provincia);
            return View(distritoes.ToList());
        }

        // GET: Distritoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distritoes.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // GET: Distritoes/Create
        public ActionResult Create()
        {
            ViewBag.IdProvincia = new SelectList(db.Provincias, "IdProvincia", "Descripcion");
            return View();
        }

        // POST: Distritoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDistrito,Descripcion,IdProvincia")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                db.Distritoes.Add(distrito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdProvincia = new SelectList(db.Provincias, "IdProvincia", "Descripcion", distrito.IdProvincia);
            return View(distrito);
        }

        // GET: Distritoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distritoes.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdProvincia = new SelectList(db.Provincias, "IdProvincia", "Descripcion", distrito.IdProvincia);
            return View(distrito);
        }

        // POST: Distritoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDistrito,Descripcion,IdProvincia")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(distrito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdProvincia = new SelectList(db.Provincias, "IdProvincia", "Descripcion", distrito.IdProvincia);
            return View(distrito);
        }

        // GET: Distritoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = db.Distritoes.Find(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // POST: Distritoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Distrito distrito = db.Distritoes.Find(id);
            db.Distritoes.Remove(distrito);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
