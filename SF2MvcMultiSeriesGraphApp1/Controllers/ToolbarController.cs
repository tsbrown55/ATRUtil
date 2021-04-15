using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;
namespace SyncfusionMvcGridNavToolbarApplication1.Controllers
{
    public class ToolBarController : Controller
    {
        public ActionResult ToolBarFeatures()
        {
	    List<ToolbarItem> items = new List<ToolbarItem>();
	    items.Add(new ToolbarItem { Template= "<button id='iconbtn'></button>", Align= ItemAlign.Left });
            items.Add(new ToolbarItem { Type = ItemType.Separator });
            items.Add(new ToolbarItem { PrefixIcon = "e-cut-icon tb-icons", TooltipText = "Cut", Overflow = OverflowOption.Show });
            items.Add(new ToolbarItem { PrefixIcon = "e-copy-icon tb-icons", TooltipText = "Copy", Overflow = OverflowOption.Show });
            items.Add(new ToolbarItem { PrefixIcon = "e-paste-icon tb-icons", TooltipText = "Paste", Overflow = OverflowOption.Show });
            items.Add(new ToolbarItem { Type = ItemType.Separator });
            items.Add(new ToolbarItem { PrefixIcon = "e-bold-icon tb-icons", TooltipText = "Bold", Overflow = OverflowOption.Show });
            items.Add(new ToolbarItem { PrefixIcon = "e-underline-icon tb-icons", TooltipText = "Underline", Overflow = OverflowOption.Show });
            items.Add(new ToolbarItem { PrefixIcon = "e-italic-icon tb-icons", TooltipText = "Italic", Overflow = OverflowOption.Show });
            items.Add(new ToolbarItem { Type = ItemType.Separator });
            items.Add(new ToolbarItem { PrefixIcon = "e-bullets-icon tb-icons", TooltipText = "Bullets", ShowTextOn = DisplayMode.Overflow });
            items.Add(new ToolbarItem { PrefixIcon = "e-numbering-icon tb-icons", TooltipText = "Numbering", ShowTextOn = DisplayMode.Overflow });
            items.Add(new ToolbarItem { Type = ItemType.Separator });
            items.Add(new ToolbarItem { Template = "<input type='text' name='firstname'>", Align = ItemAlign.Right });
            ViewBag.alignItems = items;

            DateTime dt = DateTime.Parse("12/8/1948");

            ViewBag.datasource = GetEmployees();

            return View();
        }

        private List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ EmployeeID = 1,              
                    FirstName = "Nancy", 
                    LastName = "Davolio", 
                    Title="Sales Representative",
                    BirthDate=DateTime.Parse("12/8/1948"),
                    HireDate=DateTime.Parse("5/1/1992") },

                new Employee(){ EmployeeID = 2,
                    FirstName = "Andrew",
                    LastName = "Fuller",
                    Title="Vice President, Sales",
                    BirthDate=DateTime.Parse("2/19/1952"),
                    HireDate=DateTime.Parse("8/14/1992")},

                new Employee(){ EmployeeID = 3,	
                    FirstName = "Janet",
                    LastName = "Leverling",
                    Title="Sales Representative",
                    BirthDate=DateTime.Parse("8/30/1963"),
                    HireDate=DateTime.Parse("4/1/1992")},

                new Employee(){ EmployeeID = 4,
                    FirstName = "Margaret",
                    LastName = "Peacock",
                    Title="Sales Representative",
                    BirthDate=DateTime.Parse("9/19/1937"),
                    HireDate=DateTime.Parse("5/3/1993")},

                new Employee(){ EmployeeID = 5,	
                    FirstName = "Steven",
                    LastName = "Buchanan",
                    Title="Sales Manager",
                    BirthDate=DateTime.Parse("3/4/1955"),
                    HireDate=DateTime.Parse("10/17/1993")},

                new Employee(){ EmployeeID = 6,	
                    FirstName = "Michael",
                    LastName = "Suyama",
                    Title="Sales Representative",
                    BirthDate=DateTime.Parse("7/2/1963"),
                    HireDate=DateTime.Parse("10/17/1993")},

                new Employee(){ EmployeeID = 7,	
                    FirstName = "Robert",
                    LastName = "King",
                    Title="Sales Representative",
                    BirthDate=DateTime.Parse("5/29/1960"),
                    HireDate=DateTime.Parse("1/2/1994")},

                new Employee(){ EmployeeID = 8,
                    FirstName = "Laura",
                    LastName = "Callahan",
                    Title="Inside Sales Coordinator",
                    BirthDate=DateTime.Parse("1/9/1958"),
                    HireDate=DateTime.Parse("3/5/1994")},

                new Employee(){ EmployeeID = 9,
                    FirstName = "Anne",
                    LastName = "Dodsworth",
                    Title="Sales Representative",
                    BirthDate=DateTime.Parse("1/27/1966"),
                    HireDate=DateTime.Parse("11/15/1994")}
            };

            return employees;
        }
    }

    public class Employee
    {
        public int EmployeeID;
        public string Title;
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;
        public DateTime HireDate;
    }
}
