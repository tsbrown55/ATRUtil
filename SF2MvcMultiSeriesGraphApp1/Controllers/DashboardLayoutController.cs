﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using SyncfusionMvcDashboardLayoutApplication1.Models;

namespace SyncfusionMvcDashboardLayoutApplication1.Controllers
{
    public partial class DashboardLayoutController : Controller
    {
        public ActionResult DashboardLayoutFeatures1()
        {
            return View();
        }

        public ActionResult DashboardLayoutFeatures()
        {
            return View();
        }

        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
        public ActionResult Demo()
        {
            List<expenseData> Data = new List<expenseData>
            {
                new expenseData {
                    UniqueId = "T100003",
                    dateTime = new DateTime(2017,3,1),
                    Category = "Food",
                    PaymentMode = "Cash",
                    TransactionType = "Expense",
                    Description = "Confederate cush",
                    Amount = "900",
                    MonthShort = "Mar",
                    MonthFull = "March, 2017",
                    FormattedDate = "03/01/2017 08:53 PM",
                    Device = "Tablet",
                },
                new expenseData {
                    UniqueId = "T100004",
                    dateTime = new DateTime(2017,4,1),
                    Category = "Transportation",
                    PaymentMode = "Credit Card",
                    TransactionType = "Expense",
                    Description = "Public and other transportation",
                    Amount = "1200",
                    MonthShort = "Apr",
                    MonthFull = "April, 2017",
                    FormattedDate = "04/01/2017 10:44 PM",
                    Device = "Desktop",
                },
                new expenseData {
                    UniqueId = "T100005",
                    dateTime = new DateTime(2017,5,1),
                    Category = "Transportation",
                    PaymentMode = "Cash",
                    TransactionType = "Expense",
                    Description = "Public and other transportation",
                    Amount = "600",
                    MonthShort = "May",
                    MonthFull = "May, 2017",
                    FormattedDate = "05/01/2017 08:53 PM",
                    Device = "Mobile",
                }
            };
            ViewBag.PieData1 = Data;
            List<lineData> LineDataSource = new List<lineData>
            {
               new lineData{ x =  new DateTime(2002, 1, 1), y =  2.2 }, new lineData{ x =  new DateTime(2003, 1, 1), y =  3.4 },
               new lineData{ x =  new DateTime(2004, 1, 1), y =  2.8 }, new lineData{ x =  new DateTime(2005, 1, 1), y =  1.6 },
               new lineData{ x =  new DateTime(2006, 1, 1), y =  2.3 }, new lineData{ x =  new DateTime(2007, 1, 1), y =  2.5 },
               new lineData{ x =  new DateTime(2008, 1, 1), y =  2.9 }, new lineData{ x =  new DateTime(2009, 1, 1), y =  3.8 },
               new lineData{ x =  new DateTime(2010, 1, 1), y =  1.4 }, new lineData{ x =  new DateTime(2011, 1, 1), y =  3.1 }
            };
            ViewBag.LineData = LineDataSource;
            List<lineData> LineDataSource1 = new List<lineData>
            {
               new lineData{ x =  new DateTime(2002, 1, 1), y =  2 }, new lineData{ x =  new DateTime(2003, 1, 1), y =  1.7 },
               new lineData{ x =  new DateTime(2004, 1, 1), y =  1.8 }, new lineData{ x =  new DateTime(2005, 1, 1), y =  2.1 },
               new lineData{ x =  new DateTime(2006, 1, 1), y =  2.3 }, new lineData{ x =  new DateTime(2007, 1, 1), y =  1.7 },
               new lineData{ x =  new DateTime(2008, 1, 1), y =  1.5 }, new lineData{ x =  new DateTime(2009, 1, 1), y =  2.8 },
               new lineData{ x =  new DateTime(2010, 1, 1), y =  1.5 }, new lineData{ x =  new DateTime(2011, 1, 1), y =  2.3 }
            };
            ViewBag.LineData1 = LineDataSource1;
            List<columnData> columDataSource = new List<columnData>
            {
                new columnData{ x =  "Jan", y =  46 }, new columnData{ x =  "Feb", y =  27 }, new columnData{ x =  "Mar", y =  26 }
            };
            ViewBag.columnData = columDataSource;
            List<columnData> columDataSource1 = new List<columnData>
            {
                new columnData{ x =  "Jan", y =  37 }, new columnData{ x =  "Feb", y =  23 }, new columnData{ x =  "Mar", y =  18 }
            };
            ViewBag.columnData1 = columDataSource1;
            List<columnData> columDataSource2 = new List<columnData>
            {
                new columnData{ x =  "Jan", y =  38 }, new columnData{ x =  "Feb", y =  17 }, new columnData{ x =  "Mar", y =  26 }
            };
            List<pieData> pieDataSource = new List<pieData>
            {
                 new pieData{ x = "Desktop", y = 37, text = "60%" }, new pieData{ x = "Mobile", y = 17, text = "10%" },
                 new pieData{ x = "Tablet", y = 19, text = "20%" }
            };
            ViewBag.pieData = pieDataSource;
            ViewBag.columnData2 = columDataSource2;
            List<DataSource> data = new List<DataSource>();
            data.Add(new DataSource("North America", "#71B081"));
            data.Add(new DataSource("South America", "#5A9A77"));
            data.Add(new DataSource("Africa", "#498770"));
            data.Add(new DataSource("Europe", "#39776C"));
            data.Add(new DataSource("Asia", "#266665"));
            data.Add(new DataSource("Australia", "#124F5E"));
            ViewBag.shapeData = this.GetWorldMap();
            ViewBag.dataSource = data;
            ViewBag.pallets = new string[] { "#357cd2", "#00bdae", "#e36593" };
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 5, 5 };
            return View(modelValue);
        }
    }

    public class expenseData
    {
        public string UniqueId;
        public DateTime dateTime;
        public string Category;
        public string PaymentMode;
        public string TransactionType;
        public string Description;
        public string Amount;
        public string MonthShort;
        public string MonthFull;
        public string FormattedDate;
        public string Device;
    }
    public class lineData
    {
        public DateTime x;
        public double y;
    }

    public class columnData
    {
        public string x;
        public double y;
    }

    public class pieData
    {
        public string x;
        public double y;
        public string text;
    }
    [Serializable]
    public class DataSource
    {
        public DataSource(string cont, string col)
        {
            this.continent = cont;
            this.color = col;
        }
        public string continent
        {
            get;
            set;
        }
        public string color
        {
            get;
            set;
        }

    }
}