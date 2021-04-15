using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SyncFusionMvcControlsApplication1.Models;

namespace SyncFusionMvcControlsApplication1.Controllers
{
    class Point
    {
        public double y, bubbleSize;
        public DateTime x;
    }
    public partial class ChartController : Controller
    {
        //
        // GET: /Chart/
        List<Point> TestGetLane01DataPoints()
        {
            int a = -1;
            return new List<Point>() 
            {
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	23	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	35	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	56	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	15	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	30	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	64	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	155	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	214	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	159	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	165	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	150	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	155	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	185	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	177	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	199	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	254	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	294	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	315	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	171	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	135	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	74	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	45	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	52	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	38	 }
            };
        }

        List<Point> TestGetLane02DataPoints()
        {
            int a = -1;
            return new List<Point>()
            {
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	28	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	7	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	15	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	30	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	57	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	97	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	222	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	196	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	167	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	136	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	139	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	151	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	167	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	172	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	195	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	179	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	243	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	227	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	197	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	133	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	106	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	67	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	56	 },
                new Point(){x = new DateTime(2010, 1, 10, ++a, 0, 0), y =	30	 }
            };
        }

        public ActionResult MultipleSeries1()
        {
            ViewBag.series1 = TestGetLane01DataPoints();
            ViewBag.series2 = TestGetLane02DataPoints();

            return View();
        }


        public ActionResult MultipleSeries()
        {
            List<ColumnChartData1> chartData = new List<ColumnChartData1>
            {
                new ColumnChartData1 {hour = "4", inCount = 46, outCount = 37, total = 38, temperature = 12},
                new ColumnChartData1 {hour = "5", inCount = 27, outCount = 23, total = 17, temperature = 13},
                new ColumnChartData1 {hour = "6", inCount = 26, outCount = 18, total = 26, temperature = 26},
                new ColumnChartData1 {hour = "7", inCount = 46, outCount = 37, total = 38, temperature = 10},
                new ColumnChartData1 {hour = "8", inCount = 27, outCount = 23, total = 17, temperature = 18},
                new ColumnChartData1 {hour = "9", inCount = 26, outCount = 18, total = 26, temperature = 12},
                new ColumnChartData1 {hour = "10", inCount = 46, outCount = 37, total = 38, temperature = 16},
                new ColumnChartData1 {hour = "11", inCount = 27, outCount = 23, total = 17, temperature = 30},
                new ColumnChartData1 {hour = "12", inCount = 26, outCount = 18, total = 26, temperature = 20},
                new ColumnChartData1 {hour = "13", inCount = 46, outCount = 37, total = 38, temperature = 22},
                new ColumnChartData1 {hour = "14", inCount = 27, outCount = 23, total = 17, temperature = 15},
                new ColumnChartData1 {hour = "15", inCount = 26, outCount = 18, total = 26, temperature = 18},
                new ColumnChartData1 {hour = "16", inCount = 46, outCount = 37, total = 38, temperature = 23},
                new ColumnChartData1 {hour = "17", inCount = 27, outCount = 23, total = 17, temperature = 28},
                new ColumnChartData1 {hour = "18", inCount = 26, outCount = 18, total = 26, temperature = 27},
                new ColumnChartData1 {hour = "19", inCount = 46, outCount = 37, total = 38, temperature = 31},
                new ColumnChartData1 {hour = "20", inCount = 27, outCount = 23, total = 17, temperature = 32},
                new ColumnChartData1 {hour = "21", inCount = 26, outCount = 18, total = 26, temperature = 21},
                new ColumnChartData1 {hour = "22", inCount = 26, outCount = 18, total = 26, temperature = 26}
            };
            List<ColumnChartData2> data1 = new List<ColumnChartData2>();
            Random rnd = new Random();
            double d = 0.42e1;
            d = rnd.Next();
            double value = 80;

            for (int i = 1; i <= 10; i++)
            {
                if (d > 0.5)
                {
                    value += d; //Math.random();
                }
                else
                {
                    value -= d; //Math.random();
                }

                data1.Add(new ColumnChartData2()
                {
                    x = new DateTime(2010, 1, i),
                    y = value /*.Fixed(1)*/,
                    bubbleSize = d /*Math.random()*/
                });
                //series1.push(point1);
            }

            string s =
                "{&quot;type&quot;:&quot;line&quot;,&quot;data&quot;:" +
                "{&quot;labels&quot;:" +
                "[&quot;Jan&quot;,&quot;Feb&quot;,&quot;Mar&quot;,&quot;Apr&quot;,&quot;May&quot;,&quot;Jun&quot;,&quot;Jul&quot;,&quot;Aug&quot;]" +
                ",&quot;datasets&quot;:" +
                "[{&quot;label&quot;:&quot;Earnings&quot;,&quot;fill&quot;:true,&quot;data&quot;" +
                ":[&quot;0&quot;,&quot;10000&quot;,&quot;5000&quot;,&quot;15000&quot;,&quot;10000&quot;,&quot;20000&quot;,&quot;15000&quot;,&quot;25000&quot;],&quot;backgroundColor&quot;:&quot;rgba(78, 115, 223, 0.05)&quot;,&quot;borderColor&quot;:&quot;rgba(78, 115, 223, 1)&quot;}]},&quot;options&quot;:{&quot;maintainAspectRatio&quot;:false,&quot;legend&quot;:{&quot;display&quot;:false},&quot;title&quot;:{},&quot;scales&quot;:{&quot;xAxes&quot;:[{&quot;gridLines&quot;:{&quot;color&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;zeroLineColor&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;drawBorder&quot;:false,&quot;drawTicks&quot;:false,&quot;borderDash&quot;:[&quot;2&quot;],&quot;zeroLineBorderDash&quot;:[&quot;2&quot;],&quot;drawOnChartArea&quot;:false},&quot;ticks&quot;:{&quot;fontColor&quot;:&quot;#858796&quot;,&quot;padding&quot;:20}}],&quot;yAxes&quot;:[{&quot;gridLines&quot;:{&quot;color&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;zeroLineColor&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;drawBorder&quot;:false,&quot;drawTicks&quot;:false,&quot;borderDash&quot;:[&quot;2&quot;],&quot;zeroLineBorderDash&quot;:[&quot;2&quot;]},&quot;ticks&quot;:{&quot;fontColor&quot;:&quot;#858796&quot;,&quot;padding&quot;:20}}]}}}";


            List<ColumnChartData> data2 = new List<ColumnChartData>()
            {
                new ColumnChartData() {Date = new DateTime(2020, 1, 1), Value = 25000},
                new ColumnChartData() {Date = new DateTime(2020, 2, 1), Value = 15000},
                new ColumnChartData() {Date = new DateTime(2020, 3, 1), Value = 20000},
                new ColumnChartData() {Date = new DateTime(2020,4, 1), Value = 15000},
                new ColumnChartData() {Date = new DateTime(2020, 5, 1), Value = 10000},
                new ColumnChartData() {Date = new DateTime(2020, 6, 1), Value = 5000},
                new ColumnChartData() {Date = new DateTime(2020, 7, 1), Value = 10000},
                new ColumnChartData() {Date = new DateTime(2020, 8, 1), Value = 0}
            };
            ViewBag.series2 = GetDailyVolumes();// data2;
            List<SplineGraphData> data3 = new SplineGraphData().GetSpSplineGraphDataObjects();
            ViewBag.series3 = data3;
            return View();
        }
    
        public ActionResult ChartFeatures1()
        {
            return SplineGraphTest();
        }

        public ActionResult MultipleSources()
        {
            List<SplineChartData> chartData = new List<SplineChartData>
            {
                new SplineChartData { xValue = "Sun", yValue = 15, yValue1 = 10, yValue2 = 2 },
                new SplineChartData { xValue = "Mon", yValue = 22, yValue1 = 18, yValue2 = 12 },
                new SplineChartData { xValue = "Tue", yValue = 32, yValue1 = 28, yValue2 = 22 },
                new SplineChartData { xValue = "Wed", yValue = 31, yValue1 = 28, yValue2 = 23 },
                new SplineChartData { xValue = "Thu", yValue = 29, yValue1 = 26, yValue2 = 19 },
                new SplineChartData { xValue = "Fri", yValue = 24, yValue1 = 20, yValue2 = 13 },
                new SplineChartData { xValue = "Sat", yValue = 18, yValue1 = 15, yValue2 = 8 },
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public ActionResult SplineGraphTest()
        {
            List<ColumnChartData1> chartData = new List<ColumnChartData1>
            {
                new ColumnChartData1 {hour = "4", inCount = 46, outCount = 37, total = 38, temperature = 12},
                new ColumnChartData1 {hour = "5", inCount = 27, outCount = 23, total = 17, temperature = 13},
                new ColumnChartData1 {hour = "6", inCount = 26, outCount = 18, total = 26, temperature = 26},
                new ColumnChartData1 {hour = "7", inCount = 46, outCount = 37, total = 38, temperature = 10},
                new ColumnChartData1 {hour = "8", inCount = 27, outCount = 23, total = 17, temperature = 18},
                new ColumnChartData1 {hour = "9", inCount = 26, outCount = 18, total = 26, temperature = 12},
                new ColumnChartData1 {hour = "10", inCount = 46, outCount = 37, total = 38, temperature = 16},
                new ColumnChartData1 {hour = "11", inCount = 27, outCount = 23, total = 17, temperature = 30},
                new ColumnChartData1 {hour = "12", inCount = 26, outCount = 18, total = 26, temperature = 20},
                new ColumnChartData1 {hour = "13", inCount = 46, outCount = 37, total = 38, temperature = 22},
                new ColumnChartData1 {hour = "14", inCount = 27, outCount = 23, total = 17, temperature = 15},
                new ColumnChartData1 {hour = "15", inCount = 26, outCount = 18, total = 26, temperature = 18},
                new ColumnChartData1 {hour = "16", inCount = 46, outCount = 37, total = 38, temperature = 23},
                new ColumnChartData1 {hour = "17", inCount = 27, outCount = 23, total = 17, temperature = 28},
                new ColumnChartData1 {hour = "18", inCount = 26, outCount = 18, total = 26, temperature = 27},
                new ColumnChartData1 {hour = "19", inCount = 46, outCount = 37, total = 38, temperature = 31},
                new ColumnChartData1 {hour = "20", inCount = 27, outCount = 23, total = 17, temperature = 32},
                new ColumnChartData1 {hour = "21", inCount = 26, outCount = 18, total = 26, temperature = 21},
                new ColumnChartData1 {hour = "22", inCount = 26, outCount = 18, total = 26, temperature = 26}
            };
            List<ColumnChartData2> data1 = new List<ColumnChartData2>();
            Random rnd = new Random();
            double d = 0.42e1;
            d = rnd.Next();
            double value = 80;
            //int month  = rnd.Next(1, 13);  // creates a number between 1 and 12
            //int dice   = rnd.Next(1, 7);   // creates a number between 1 and 6
            //int card   = rnd.Next(52);     // creates a number between 0 and 51
            for (int i = 1; i <= 10; i++)
            {
                if (d > 0.5)
                {
                    value += d; //Math.random();
                }
                else
                {
                    value -= d; //Math.random();
                }

                data1.Add(new ColumnChartData2()
                    {
                        x = new DateTime(2010, 1, i), 
                        y = value /*.Fixed(1)*/, 
                        bubbleSize = d /*Math.random()*/
                    });
                //series1.push(point1);
            }

            string s =
                "{&quot;type&quot;:&quot;line&quot;,&quot;data&quot;:" +
                "{&quot;labels&quot;:" +
                "[&quot;Jan&quot;,&quot;Feb&quot;,&quot;Mar&quot;,&quot;Apr&quot;,&quot;May&quot;,&quot;Jun&quot;,&quot;Jul&quot;,&quot;Aug&quot;]" +
                ",&quot;datasets&quot;:" +
                "[{&quot;label&quot;:&quot;Earnings&quot;,&quot;fill&quot;:true,&quot;data&quot;" +
                ":[&quot;0&quot;,&quot;10000&quot;,&quot;5000&quot;,&quot;15000&quot;,&quot;10000&quot;,&quot;20000&quot;,&quot;15000&quot;,&quot;25000&quot;],&quot;backgroundColor&quot;:&quot;rgba(78, 115, 223, 0.05)&quot;,&quot;borderColor&quot;:&quot;rgba(78, 115, 223, 1)&quot;}]},&quot;options&quot;:{&quot;maintainAspectRatio&quot;:false,&quot;legend&quot;:{&quot;display&quot;:false},&quot;title&quot;:{},&quot;scales&quot;:{&quot;xAxes&quot;:[{&quot;gridLines&quot;:{&quot;color&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;zeroLineColor&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;drawBorder&quot;:false,&quot;drawTicks&quot;:false,&quot;borderDash&quot;:[&quot;2&quot;],&quot;zeroLineBorderDash&quot;:[&quot;2&quot;],&quot;drawOnChartArea&quot;:false},&quot;ticks&quot;:{&quot;fontColor&quot;:&quot;#858796&quot;,&quot;padding&quot;:20}}],&quot;yAxes&quot;:[{&quot;gridLines&quot;:{&quot;color&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;zeroLineColor&quot;:&quot;rgb(234, 236, 244)&quot;,&quot;drawBorder&quot;:false,&quot;drawTicks&quot;:false,&quot;borderDash&quot;:[&quot;2&quot;],&quot;zeroLineBorderDash&quot;:[&quot;2&quot;]},&quot;ticks&quot;:{&quot;fontColor&quot;:&quot;#858796&quot;,&quot;padding&quot;:20}}]}}}";


            /*
            new ColumnChartData {x = 4, y = 46, outCount = 37, total = 38, temperature = 12},
            new ColumnChartData {x = 5, y = 27, outCount = 23, total = 17, temperature = 13},
            new ColumnChartData {x = 6, y = 26, outCount = 18, total = 26, temperature = 26},
            new ColumnChartData {x = 7, y = 46, outCount = 37, total = 38, temperature = 10},
            new ColumnChartData {x = 8, y = 27, outCount = 23, total = 17, temperature = 18},
            new ColumnChartData {x = 9, y = 26, outCount = 18, total = 26, temperature = 12},
            new ColumnChartData {x = 10, y = 46, outCount = 37, total = 38, temperature = 16},
            new ColumnChartData {x = 11, y = 27, outCount = 23, total = 17, temperature = 30},
            new ColumnChartData {x = 12, y = 26, outCount = 18, total = 26, temperature = 20},
            new ColumnChartData {x = 13, y = 46, outCount = 37, total = 38, temperature = 22},
            new ColumnChartData {x = 14, y = 27, outCount = 23, total = 17, temperature = 15},
            new ColumnChartData {x = 15, y = 26, outCount = 18, total = 26, temperature = 18},
            new ColumnChartData {x = 16, y = 46, outCount = 37, total = 38, temperature = 23},
            new ColumnChartData {x = 17, y = 27, outCount = 23, total = 17, temperature = 28},
            new ColumnChartData {x = 18, y = 26, outCount = 18, total = 26, temperature = 27},
            new ColumnChartData {x = 19, y = 46, outCount = 37, total = 38, temperature = 31},
            new ColumnChartData {x = 20, y = 27, outCount = 23, total = 17, temperature = 32},
            new ColumnChartData {x = 21, y = 26, outCount = 18, total = 26, temperature = 21},
            new ColumnChartData {x = 22, y = 26, outCount = 18, total = 26, temperature = 26}
            */
            //};
                    /*
                     * jan, 0
                        feb, 10000
                        mar, 5000
                        apr, 15000
                        may, 10000
                        jun, 20000
                        jul, 15000
                        aug, 25000
                    */
            List<ColumnChartData> data2 = new List<ColumnChartData>()
            {
                new ColumnChartData() {Date = new DateTime(2020, 1, 1), Value = 25000},
                new ColumnChartData() {Date = new DateTime(2020, 2, 1), Value = 15000},
                new ColumnChartData() {Date = new DateTime(2020, 3, 1), Value = 20000},
                new ColumnChartData() {Date = new DateTime(2020,4, 1), Value = 15000},
                new ColumnChartData() {Date = new DateTime(2020, 5, 1), Value = 10000},
                new ColumnChartData() {Date = new DateTime(2020, 6, 1), Value = 5000},
                new ColumnChartData() {Date = new DateTime(2020, 7, 1), Value = 10000},
                new ColumnChartData() {Date = new DateTime(2020, 8, 1), Value = 0}
            };
            ViewBag.series2 = data2;
            List<SplineGraphData> data3 = new SplineGraphData().GetSpSplineGraphDataObjects();
            ViewBag.series3 = data3;
            return View();
        }

        List<DailyVolume> GetDailyVolumes()
        {
            List<DailyVolume> dailyVolumes = new List<DailyVolume>()
            {
                new DailyVolume(){ Hour = 	0	, Value =	23	},
                new DailyVolume(){ Hour = 	1	, Value =	35	},
                new DailyVolume(){ Hour = 	2	, Value =	56	},
                new DailyVolume(){ Hour = 	3	, Value =	15	},
                new DailyVolume(){ Hour = 	4	, Value =	30	},
                new DailyVolume(){ Hour = 	5	, Value =	64	},
                new DailyVolume(){ Hour = 	6	, Value =	155	},
                new DailyVolume(){ Hour = 	7	, Value =	214	},
                new DailyVolume(){ Hour = 	8	, Value =	159	},
                new DailyVolume(){ Hour = 	9	, Value =	165	},
                new DailyVolume(){ Hour = 	10	, Value =	150	},
                new DailyVolume(){ Hour = 	11	, Value =	155	},
                new DailyVolume(){ Hour = 	12	, Value =	185	},
                new DailyVolume(){ Hour = 	13	, Value =	177	},
                new DailyVolume(){ Hour = 	14	, Value =	199	},
                new DailyVolume(){ Hour = 	15	, Value =	254	},
                new DailyVolume(){ Hour = 	16	, Value =	294	},
                new DailyVolume(){ Hour = 	17	, Value =	315	},
                new DailyVolume(){ Hour = 	18	, Value =	171	},
                new DailyVolume(){ Hour = 	19	, Value =	135	},
                new DailyVolume(){ Hour = 	20	, Value =	74	},
                new DailyVolume(){ Hour = 	21	, Value =	45	},
                new DailyVolume(){ Hour = 	22	, Value =	52	},
                new DailyVolume(){ Hour = 	23	, Value =	38	},
            };
            return dailyVolumes;
        }
    }

    public class DailyVolume
    {
        public int Id, Hour, Value;
    }
    public class ColumnChartData
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }
    }
    public class ColumnChartData2
    {
        public string string1;
        public DateTime x;
        public double y;
        public int outCount;
        public double total;
        public double temperature;
        public double bubbleSize;
    }

    public class ColumnChartData1
    {
        public string hour;
        public double inCount;
        public double outCount;
        public double total;
        public double temperature;
    }

    public class SplineChartData
    {
        public string xValue;
        public double yValue;
        public double yValue1;
        public double yValue2;
    }
}