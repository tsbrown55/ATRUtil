using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DelDOTLaneTraffic1.Models
{
    public class Volume
    {
        public int VolumeId { get; set; }
        public int StationId { get; set; }
        public DateTime ReportDate { get; set; }

        public string ReportDisplayDate
        {
            get { return ReportDate.ToString("MM/dd/yyyy"); }
        }

        public byte ReportHour { get; set; }

        //public Int16 Lane1 { get { return Lanes[0]; } }
        //public Int16 Lane2 { get { return Lanes[1]; } }
        //public Int16 Lane3 { get { return Lanes[2]; } }
        //public Int16 Lane4 { get { return Lanes[3]; } }
        //public Int16 Lane5 { get { return Lanes[4]; } }
        //public Int16 Lane6 { get { return Lanes[5]; } }
        //public Int16 Lane7 { get { return Lanes[6]; } }
        //public Int16 Lane8 { get { return Lanes[7]; } }
        //public Int16 Lane9 { get { return Lanes[8]; } }
        //public Int16 Lane10 { get { return Lanes[9]; } }
        public Int16 Lane1 { get; set; }
        public Int16 Lane2 { get; set; }
        public Int16 Lane3 { get; set; }
        public Int16 Lane4 { get; set; }
        public Int16 Lane5 { get; set; }
        public Int16 Lane6 { get; set; }
        public Int16 Lane7 { get; set; }
        public Int16 Lane8 { get; set; }
        public Int16 Lane9 { get; set; }
        public Int16 Lane10 { get; set; }
        public int[] Lanes{ get; set; }
    
    //public int[] LaneIds { get; set; }

        public Volume()
        {
            Lane1 = -1;
            Lane2 = -1;
            Lane3 = -1;
            Lane4 = -1;
            Lane5 = -1;
            Lane6 = -1;
            Lane7 = -1;
            Lane8 = -1;
            Lane9 = -1;
            Lane10 = -1;

            Lanes = Enumerable.Repeat(-1, 10).ToArray();
        }
}

}