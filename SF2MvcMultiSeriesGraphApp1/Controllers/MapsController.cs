using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Syncfusion.EJ2.CircularGauge;
namespace SyncfusionMvcGraphsApplication1.Controllers
{
    public partial class MapsController : Controller
    {
        //
        // GET: /DaraMarker/
        public ActionResult MapsFeatures()
        {
	    ViewBag.ShapeData = this.getUSAMap();
            ViewBag.DataSource = this.getElectionData();
            List<MapsColorMapping> colorMapping = new List<MapsColorMapping>();            
            colorMapping.Add(new MapsColorMapping { Value = "Trump", Color = "#D84444", Label = null });
            colorMapping.Add(new MapsColorMapping { Value = "Clinton", Color = "#316DB5", Label = null });
            ViewBag.ColorMapping = colorMapping;
            string population = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Maps/MapData/markerlocation.json"));
            object datasrc = JsonConvert.DeserializeObject(population, typeof(object));
            MapsMarker marker = new MapsMarker();
            marker.Visible = false;
            ViewBag.markerDatasource = JsonConvert.DeserializeObject(population, typeof(object));
            marker.AnimationDuration = 0;
            marker.Shape = MarkerType.Balloon;
            marker.Fill = "darkgray";
            marker.Width = 15;
            marker.Height = 25;
            List<MapsMarker> markerSettings = new List<MapsMarker>();
            markerSettings.Add(marker);
            ViewBag.markerSettings = markerSettings;
            return View();
        }
        public object getUSAMap()
        {
            JObject usa = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Maps/MapData/USA.json")));
            return usa;
        }
        public object getElectionData()
        {
            JObject data = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Maps/MapData/ElectionData.json")));
            return data["ElectionData"];
        }      
    }
}
