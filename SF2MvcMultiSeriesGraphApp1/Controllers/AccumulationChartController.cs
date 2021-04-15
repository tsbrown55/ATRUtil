using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Mvc;
using SyncFusionMvcControlsApplication1.Models;
using SyncFusionMvcControlsApplication1.Util;
using SP = Microsoft.SharePoint.Client;

namespace SyncFusionMvcControlsApplication1.Controllers
{
    public class AccumulationChartController : Controller
    {
        public ActionResult AccumulationChartFeatures()
        {
	    List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { xValue = "Chrome", yValue = 37 } , //, text = "37%"},
                new ChartData { xValue = "UC Browser", yValue = 17 } , //, text = "17%"},
                new ChartData { xValue = "iPhone", yValue = 19 } , //, text = "19%"},
                new ChartData { xValue = "Others", yValue = 4 } , // , text = "4%"},
                new ChartData { xValue = "Opera", yValue = 11 } , //, text = "11%"},
                new ChartData { xValue = "Android", yValue = 12 } , //, text = "12%"},
            };
            ViewBag.dataSource = chartData;
            return View();
        }

        public ActionResult Doughnut()
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { xValue = "Chrome", yValue = 87 } , //text = "37%"},
                new ChartData { xValue = "UC Browser", yValue = 17 } , //, text = "17%"},
                new ChartData { xValue = "iPhone", yValue = 19 } , //, text = "19%"},
                new ChartData { xValue = "Others", yValue = 4 } , // , text = "4%"},
                new ChartData { xValue = "Opera", yValue = 11 } , //, text = "11%"},
                new ChartData { xValue = "Android", yValue = 12 } , //, text = "12%"},
            };
            ViewBag.dataSource = GetSpDoughnutGraphDataObjects();//chartData;
            return View();
        }

        public List<ChartData> GetSpDoughnutGraphDataObjects()
        {
            List<ChartData> chartData = new List<ChartData>();
            System.Net.NetworkCredential creds = new System.Net.NetworkCredential("app4rent_sp16@geek-ish.com", "helloWorld55!");
            Microsoft.SharePoint.Client.ClientContext ctx = new Microsoft.SharePoint.Client.ClientContext("http://sp16.geek-ish.com/") { Credentials = creds };
            string listName = "DoughnutGraphData";//"ADA_Eligibility_Status4"; 
            SP.ListItemCollection items = SpUtil.GetSpListItems(ctx, "http://sp16.geek-ish.com/", listName, string.Empty);
            if (items != null)
            {
                foreach (SP.ListItem li in items)
                {
                    ChartData cd = new ChartData();
                    {
                        double i = 0;
                        try
                        {
                            if (li["Title"] != null)
                            {
                                cd.xValue = li["Title"].ToString();
                                cd.yValue = li["yValue"] == null ? 0 :
                                    double.TryParse(li["yValue"].ToString(), out i) ? (int)(i * 100) : 0;
                                chartData.Add(cd);
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.Print(e.Message);
                        }
                    }
                }
            }

            return chartData;
        }


        public class ChartData
        {
            public string xValue;
            public double yValue;

            public string text
            {
                get { return (yValue + "%"); }
            }
        }
    }
}
