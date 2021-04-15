using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DelDOTLaneTraffic1.Models
{
    /*
        
    */
    public class Location
    {
        public int LocationId { get; set; }
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Site
    {
        public int SiteId { get; set; }
        public string Title { get; set; }
    }

    public class County
    {
        public int CountyId { get; set; }
        public string Title { get; set; }
    }

    public class FunctClass
    {
        public int FunctClassId { get; set; }
        public string Title { get; set; }

    }
}
