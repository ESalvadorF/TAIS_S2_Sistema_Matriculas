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
    public class GradoesController : Controller
    {
        private DataStore db = new DataStore();

        // GET: Gradoes
        public ActionResult Index()
        {
            var gradoes = db.Gradoes.Include(g => g.Nivel);
            return View(gradoes.ToList());
        }

        // GET: Gradoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grado grado = db.Gradoes.Find(id);
            if (grado == null)
            {
                return HttpNotFound();
            }
            return View(grado);
        }

        // GET: Gradoes/Create
        public ActionResult Create()
        {
            ViewBag.IdNivel = new SelectList(db.Nivels, "IdNivel", "Descripcion");
            return View();
        }

        // POST: Gradoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdGrado,Descripcion,IdNivel")] Grado grado)
        {
            if (ModelState.IsValid)
            {
                db.Gradoes.Add(grado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdNivel = new SelectList(db.Nivels, "IdNivel", "Descripcion", grado.IdNivel);
            return View(grado);
        }

        // GET: Gradoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grado grado = db.Gradoes.Find(id);
            if (grado == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdNivel = new SelectList(db.Nivels, "IdNivel", "Descripcion", grado.IdNivel);
            return View(grado);
        }

        // POST: Gradoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdGrado,Descripcion,IdNivel")] Grado grado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdNivel = new SelectList(db.Nivels, "IdNivel", "Descripcion", grado.IdNivel);
            return View(grado);
        }

        // GET: Gradoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grado grado = db.Gradoes.Find(id);
            if (grado == null)
            {
                return HttpNotFound();
            }
            return View(grado);
        }

        // POST: Gradoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grado grado = db.Gradoes.Find(id);
            db.Gradoes.Remove(grado);
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
