using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DelDOTLaneTraffic1.Models;

namespace DelDOTLaneTraffic1.Controllers
{
    public class VolumesController_1 : Controller
    {
        private VolumesContext db = new VolumesContext();

        public JsonResult GetLaneHourVolume(DateTime date, int stationId, int laneNumber, int hour)
        {
            int v1 = -1;
            var volume = db.Volumes.FirstOrDefault(v => v.ReportDate == date && v.StationId == stationId);
            if (volume != null)
            {
                v1 = new int[]
                {
                    volume.Lane1, volume.Lane2, volume.Lane3, volume.Lane4, 
                    volume.Lane5, volume.Lane6, volume.Lane7,
                    volume.Lane8, volume.Lane9, volume.Lane10
                }[laneNumber - 1];
            }

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = v1
            };
        }

        // GET: Volumes
        public ActionResult Index()
        {
            return View(db.Volumes.ToList());
        }

        // GET: Volumes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volume volume = db.Volumes.Find(id);
            if (volume == null)
            {
                return HttpNotFound();
            }
            return View(volume);
        }

        // GET: Volumes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Volumes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VolumeId,StationId,ReportDate,ReportHour")] Volume volume)
        {
            if (ModelState.IsValid)
            {
                db.Volumes.Add(volume);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(volume);
        }

        // GET: Volumes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volume volume = db.Volumes.Find(id);
            if (volume == null)
            {
                return HttpNotFound();
            }
            return View(volume);
        }

        // POST: Volumes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VolumeId,StationId,ReportDate,ReportHour")] Volume volume)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volume).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(volume);
        }

        // GET: Volumes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volume volume = db.Volumes.Find(id);
            if (volume == null)
            {
                return HttpNotFound();
            }
            return View(volume);
        }

        // POST: Volumes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Volume volume = db.Volumes.Find(id);
            db.Volumes.Remove(volume);
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
