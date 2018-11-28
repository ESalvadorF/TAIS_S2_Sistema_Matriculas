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
    public class MatriculasController : Controller
    {
        private DataStore db = new DataStore();

        // GET: Matriculas
        public ActionResult Index()
        {
            var matriculas = db.Matriculas.Include(m => m.Alumno).Include(m => m.Seccion);
            return View(matriculas.ToList());
        }

        public ActionResult Reporte()
        {
            var matriculas = db.Matriculas.Include(m => m.Alumno).Include(m => m.Seccion);
            return View("Reporte",matriculas.ToList());
        }

        // GET: Matriculas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matricula matricula = db.Matriculas.Find(id);
            if (matricula == null)
            {
                return HttpNotFound();
            }
            return View(matricula);
        }

        // GET: Matriculas/Create
        public ActionResult Create()
        {
            ViewBag.Codigo = new SelectList(db.Alumnos, "Codigo", "Dni");
            ViewBag.IdSeccion = new SelectList(db.Seccions, "IdSeccion", "Descripcion");
            return View();
        }

        // POST: Matriculas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idMatricula,CodigoMatricula,FechaMatricula,MontoPago,IdSeccion,IdPeriodo,Codigo")] Matricula matricula)
        {
            if (ModelState.IsValid)
            {
                db.Matriculas.Add(matricula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Codigo = new SelectList(db.Alumnos, "Codigo", "Dni", matricula.Codigo);
            ViewBag.IdSeccion = new SelectList(db.Seccions, "IdSeccion", "Descripcion", matricula.IdSeccion);
            return View(matricula);
        }

        // GET: Matriculas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matricula matricula = db.Matriculas.Find(id);
            if (matricula == null)
            {
                return HttpNotFound();
            }
            ViewBag.Codigo = new SelectList(db.Alumnos, "Codigo", "Dni", matricula.Codigo);
            ViewBag.IdSeccion = new SelectList(db.Seccions, "IdSeccion", "Descripcion", matricula.IdSeccion);
            return View(matricula);
        }

        // POST: Matriculas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idMatricula,CodigoMatricula,FechaMatricula,MontoPago,IdSeccion,IdPeriodo,Codigo")] Matricula matricula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(matricula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Codigo = new SelectList(db.Alumnos, "Codigo", "Dni", matricula.Codigo);
            ViewBag.IdSeccion = new SelectList(db.Seccions, "IdSeccion", "Descripcion", matricula.IdSeccion);
            return View(matricula);
        }

        // GET: Matriculas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Matricula matricula = db.Matriculas.Find(id);
            if (matricula == null)
            {
                return HttpNotFound();
            }
            return View(matricula);
        }

        // POST: Matriculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Matricula matricula = db.Matriculas.Find(id);
            db.Matriculas.Remove(matricula);
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
