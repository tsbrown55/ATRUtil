using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SyncfusionMvcApplication1.Models;

namespace SyncfusionMvcApplication1.Controllers
{
    public class ProjectTrackerController : Controller
    {
        private ProjectDatasContext db = new ProjectDatasContext();
        // GET: ProjectTracker
        public ActionResult Index()
        {
            return View(db.ProjectDatas.ToList());
        }

        public ActionResult ProjectTrackerFeatures()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

    }
}