﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TAIS_S2_Sistema_Matriculas.Context;
using TAIS_S2_Sistema_Matriculas.Models;

namespace TAIS_S2_Sistema_Matriculas.Controllers
{
    
    public class AlumnoController : Controller
    {
        private DataStore db = new DataStore();

        // GET: Alumnoes
        public ActionResult Index()
        {
            return View(db.Alumnos.ToList());
        }


        public ActionResult Reporte()
        {
            return View("Reporte",db.Alumnos.ToList());
        }

        // GET: Alumnoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        public ActionResult ReporteAlumno(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // GET: Alumnoes/Create
        public ActionResult Create()
        {
            ViewBag.IdDistrito = new SelectList(db.Distritoes, "IdDistrito", "Descripcion");
            return View();
        }

        // POST: Alumnoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,Dni,ApePaterno,ApeMaterno,PriNombre,OtroNombre,Sexo,FechaNacimiento,IdDistrito,Domicilio")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Alumnos.Add(alumno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdDistrito = new SelectList(db.Distritoes, "IdDistrito", "Descripcion", alumno.IdDistrito);
            return View(alumno);
        }

        // GET: Alumnoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdDistrito = new SelectList(db.Distritoes, "IdDistrito", "Descripcion", alumno.IdDistrito);
            return View(alumno);
        }

        // POST: Alumnoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,Dni,ApePaterno,ApeMaterno,PriNombre,OtroNombre,Sexo,FechaNacimiento,IdDistrito,Domicilio")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdDistrito = new SelectList(db.Distritoes, "IdDistrito", "Descripcion", alumno.IdDistrito);
            return View(alumno);
        }

        // GET: Alumnoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumnos.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Alumnoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alumno alumno = db.Alumnos.Find(id);
            db.Alumnos.Remove(alumno);
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
