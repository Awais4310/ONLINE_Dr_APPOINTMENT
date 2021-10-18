using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ONLINE_Dr_APPOINTMENT.Models;

namespace ONLINE_Dr_APPOINTMENT.Controllers
{
    public class Doctor_scheduleController : Controller
    {
        private Model1 db = new Model1();

        // GET: Doctor_schedule
        public ActionResult Index()
        {
            var doctor_schedule = db.Doctor_schedule.Include(d => d.Doctor);
            return View(doctor_schedule.ToList());
        }

        // GET: Doctor_schedule/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_schedule doctor_schedule = db.Doctor_schedule.Find(id);
            if (doctor_schedule == null)
            {
                return HttpNotFound();
            }
            return View(doctor_schedule);
        }

        // GET: Doctor_schedule/Create
        public ActionResult Create()
        {
            ViewBag.Doctor_fid = new SelectList(db.Doctors, "Doctor_id", "Doctor_Name");
            return View();
        }

        // POST: Doctor_schedule/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Dr_schedule_id,Doctor_fid,Dr_Schedule_Days,Start_Time,End_Time,Total_Appointments")] Doctor_schedule doctor_schedule)
        {
            if (ModelState.IsValid)
            {
                db.Doctor_schedule.Add(doctor_schedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Doctor_fid = new SelectList(db.Doctors, "Doctor_id", "Doctor_Name", doctor_schedule.Doctor_fid);
            return View(doctor_schedule);
        }

        // GET: Doctor_schedule/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_schedule doctor_schedule = db.Doctor_schedule.Find(id);
            if (doctor_schedule == null)
            {
                return HttpNotFound();
            }
            ViewBag.Doctor_fid = new SelectList(db.Doctors, "Doctor_id", "Doctor_Name", doctor_schedule.Doctor_fid);
            return View(doctor_schedule);
        }

        // POST: Doctor_schedule/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Dr_schedule_id,Doctor_fid,Dr_Schedule_Days,Start_Time,End_Time,Total_Appointments")] Doctor_schedule doctor_schedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor_schedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Doctor_fid = new SelectList(db.Doctors, "Doctor_id", "Doctor_Name", doctor_schedule.Doctor_fid);
            return View(doctor_schedule);
        }

        // GET: Doctor_schedule/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_schedule doctor_schedule = db.Doctor_schedule.Find(id);
            if (doctor_schedule == null)
            {
                return HttpNotFound();
            }
            return View(doctor_schedule);
        }

        // POST: Doctor_schedule/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor_schedule doctor_schedule = db.Doctor_schedule.Find(id);
            db.Doctor_schedule.Remove(doctor_schedule);
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
