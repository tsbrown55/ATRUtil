using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DelDOTLaneTraffic1.Models
{
    public class Station
    {
        public int StationId { get; set; }
        public string ReportName { get; set; }
        public string Site { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}