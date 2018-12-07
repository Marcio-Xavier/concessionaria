using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Concessionaria.DAL;
using Concessionaria.Models;

namespace Concessionaria.Controllers
{
    public class SobreController : Controller
    {
        private ConcessionariaContext db = new ConcessionariaContext();

        // GET: Sobre
        public ActionResult Index()
        {
            return View(db.sobre.ToList());
        }
        public ActionResult Resumo()
        {
            return View(db.sobre.ToList());
        }

        // GET: Sobre/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sobre sobre = db.sobre.Find(id);
            if (sobre == null)
            {
                return HttpNotFound();
            }
            return View(sobre);
        }

        // GET: Sobre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sobre/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Conteudo")] Sobre sobre)
        {
            if (ModelState.IsValid)
            {
                db.sobre.Add(sobre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sobre);
        }

        // GET: Sobre/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sobre sobre = db.sobre.Find(id);
            if (sobre == null)
            {
                return HttpNotFound();
            }
            return View(sobre);
        }

        // POST: Sobre/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Conteudo")] Sobre sobre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sobre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sobre);
        }

        // GET: Sobre/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sobre sobre = db.sobre.Find(id);
            if (sobre == null)
            {
                return HttpNotFound();
            }
            return View(sobre);
        }

        // POST: Sobre/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sobre sobre = db.sobre.Find(id);
            db.sobre.Remove(sobre);
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
