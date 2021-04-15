using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
namespace SyncfusionMvcGraphsApplication1
{
    public partial class TreeMapController : Controller
    {
        //
        // GET: /TreeMapFeatures/
        public ActionResult TreeMapFeatures()
        {
            ViewData["ProductName"] = "Maps";
            return View();
        }
        //ControllerAdd###  
    }
}
