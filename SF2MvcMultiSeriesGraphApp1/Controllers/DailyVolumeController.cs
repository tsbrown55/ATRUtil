using System;
using System.Web.Mvc;
using System.Collections.Generic;
using Microsoft.Ajax.Utilities;
//using SyncfusionMvcASplineGraphApplication1.Models;

namespace SyncfusionMvcASplineGraphApplication1.Controllers
{
    public partial class DailyVolumeController : Controller
    {
        //
        // GET: /Chart/

        public ActionResult Site085()
        {
            ViewBag.series1 = TestGetLane01DataPoints();
            ViewBag.series2 = TestGetLane02DataPoints();

            return View();
        }

        List<Point> TestGetLane01DataPoints()
        {
            int a = -1;
            return new List<Point>()
            {
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 23},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 35},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 56},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 15},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 30},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 64},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 155},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 214},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 159},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 165},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 150},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 155},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 185},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 177},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 199},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 254},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 294},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 315},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 171},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 135},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 74},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 45},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 52},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 38}
            };
        }

        List<Point> TestGetLane02DataPoints()
        {
            int a = -1;
            return new List<Point>()
            {
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 28},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 7},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 15},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 30},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 57},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 97},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 222},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 196},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 167},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 136},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 139},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 151},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 167},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 172},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 195},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 179},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 243},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 227},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 197},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 133},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 106},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 67},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 56},
                new Point() {x = new DateTime(2010, 1, 10, ++a, 0, 0), y = 30}
            };
        }
    }
}
