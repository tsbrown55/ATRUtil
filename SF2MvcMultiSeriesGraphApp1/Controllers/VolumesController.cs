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
    public class VolumesController : Controller
    {
        private VolumesContext db = new VolumesContext();

        public JsonResult GetLaneHourVolume(DateTime date, int stationId, int laneNumber, int hour)
        {
            Volume v = null;
            int[] lanes = Enumerable.Repeat(-1, 10).ToArray(); //Ref: C# Initialize Array - Dot Net Perls -https://www.dotnetperls.com/initialize-array 
            var volume = db.Volumes.FirstOrDefault(v2 => v2.ReportDate == date 
                                                        && v2.StationId == stationId &&
                                                        v2.ReportHour == hour);
            if (volume != null)
            {
                short v1 = new short[]
                {
                    volume.Lane1, volume.Lane2, volume.Lane3, volume.Lane4,
                    volume.Lane5, volume.Lane6, volume.Lane7,
                    volume.Lane8, volume.Lane9, volume.Lane10
                }[laneNumber - 1];
                lanes[laneNumber - 1] = v1;

                v = new Volume()
                {
                    ReportDate = date,
                    StationId = stationId,
                    ReportHour = (byte) hour,
                    Lane1 = (laneNumber - 1 == 0) ? v1 : (short)-1,
                    Lane2 = (laneNumber - 1 == 1) ? v1 : (short)-1,
                    Lane3 = (laneNumber - 1 == 2) ? v1 : (short)-1,
                    Lane4 = (laneNumber - 1 == 3) ? v1 : (short)-1,
                    Lane5 = (laneNumber - 1 == 4) ? v1 : (short)-1,
                    Lane6 = (laneNumber - 1 == 5) ? v1 : (short)-1,
                    Lane7 = (laneNumber - 1 == 6) ? v1 : (short)-1,
                    Lane8 = (laneNumber - 1 == 7) ? v1 : (short)-1,
                    Lane9 = (laneNumber - 1 == 8) ? v1 : (short)-1,
                    Lane10 = (laneNumber - 1 == 9) ? v1 : (short)-1,
                    Lanes = lanes
                };
            }

            return new JsonResult()
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = v
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
        public ActionResult Create([Bind(Include = "VolumeId,StationId,ReportDate,ReportHour,Lane1,Lane2,Lane3,Lane4,Lane5,Lane6,Lane7,Lane8,Lane9,Lane10")] Volume volume)
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
        public ActionResult Edit([Bind(Include = "VolumeId,StationId,ReportDate,ReportHour,Lane1,Lane2,Lane3,Lane4,Lane5,Lane6,Lane7,Lane8,Lane9,Lane10")] Volume volume)
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
