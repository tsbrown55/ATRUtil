using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

using System.Web.Script.Serialization;
//using Label = Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label;


namespace SyncfusionMvcApplication1.Controllers
{
    public partial class DiagramController : Controller
    {
        // GET: /<controller>/
        public ActionResult HierarchicalFeatures()
        {
            ViewBag.Nodes = HierarchicalDetails.GetData();
            return View();
        }
        //public ActionResult TeamOrgchart()
        //{
        //    DiagramProperties model = new DiagramProperties();
        //    model.Width = "100%";
        //    model.Height = "600px";
        //    model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
        //    model.Layout.Type = LayoutTypes.OrganizationalChart;
        //    model.Layout.Margin.Top = 50;
        //    model.Layout.HorizontalSpacing = 30;
        //    model.Layout.VerticalSpacing = 30;
        //    model.DataSourceSettings.DataSource = GetTeamChartData();
        //    model.DataSourceSettings.Parent = "ReportingPerson";
        //    model.DataSourceSettings.Id = "Id";
        //    model.DefaultSettings.Node = new ImageNode() { Width = 140, Height = 50, BorderColor = "transparent", BorderWidth = 0 };
        //    Label label = new Label() { Name = "name1", Text = "", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, FontSize = 11, Bold = true, FontFamily = "Segoe UI", Margin = new LabelMargin(-17, -17, 0, 0) };
        //    Label label1 = new Label() { Name = "name2", Text = "", HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, FontSize = 10, FontFamily = "Segoe UI", Margin = new LabelMargin(-2, -17, 0, 0) };
        //    model.DefaultSettings.Node.Labels.Add(label);
        //    model.DefaultSettings.Node.Labels.Add(label1);
        //    model.DefaultSettings.Connector = new Connector()
        //    {
        //        Segments = new Collection() { new Segment(Segments.Orthogonal) },
        //        TargetDecorator = new Decorator() { Shape = DecoratorShapes.None }
        //    };
        //    model.SnapSettings.SnapConstraints = SnapConstraints.None;
        //    model.EnableContextMenu = false;
        //    model.NodeTemplate = "nodeTemplate";
        //    model.Tool = Tool.ZoomPan;
        //    ViewData["diagramModel"] = model;
        //    return View();
        //}

        public Array GetTeamChartData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/OrgChart.json"));
            ViewBag.Alltext = allText;
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            requestArgs = (Dictionary<string, object>)requestArgs["root"];
            return (Array)requestArgs.Values.ElementAt(0);
        }
        // GET: /<controller>/
        public ActionResult DiagramFeatures()
        {
		ViewBag.Nodes = OrganizationalDetails.GetData();
		return View();
        }
    }
    public class HierarchicalDetails
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string FillColor { get; set; }
        public HierarchicalDetails(string name, string category, string fillcolor)
        {
            this.Name = name;
            this.Category = category;
            this.FillColor = fillcolor;
        }
        public static List<HierarchicalDetails> GetData()
        {
            List<HierarchicalDetails> hierarchicaldetails = new List<HierarchicalDetails>();
            hierarchicaldetails.Add(new HierarchicalDetails("Diagram", "", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Layout", "Diagram", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Tree Layout", "Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Organizational Chart", "Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Hierarchical Tree", "Tree Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Radial Tree", "Tree Layout", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Mind Map", "Hierarchical Tree", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Family Tree", "Hierarchical Tree", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Management", "Organizational Chart", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Human Resources", "Management", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("University", "Management", "#916DAF"));
            hierarchicaldetails.Add(new HierarchicalDetails("Business", "Management", "#916DAF"));
            return hierarchicaldetails;
        }
    }
    
    public class OrganizationalDetails
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public string Color { get; set; }
        public string Manager { get; set; }
        public string ChartType { get; set; }
        public OrganizationalDetails(string id, string role, string color, string manager, string chartType)
        {
            this.Id = id;
            this.Role = role;
            this.Color = color;
            this.Manager = manager;
            this.ChartType = chartType;
        }
        public static List<OrganizationalDetails> GetData()
        {
            List<OrganizationalDetails> organizationaldetails = new List<OrganizationalDetails>();
            organizationaldetails.Add(new OrganizationalDetails("parent", "Board", "#71AF17", "", ""));
            organizationaldetails.Add(new OrganizationalDetails("1", "General Manager", "#71AF17", "parent", "right"));
            organizationaldetails.Add(new OrganizationalDetails("11", "Assistant General Manager", "#71AF17", "1", ""));
            organizationaldetails.Add(new OrganizationalDetails("2", "Human Resource Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("3", "Trainers", "#2E95D8", "2", ""));
            organizationaldetails.Add(new OrganizationalDetails("4", "Recruiting Team", "#2E95D8", "2", ""));
            organizationaldetails.Add(new OrganizationalDetails("5", "Finance Asst. Manager", "#2E95D8", "2", ""));
            organizationaldetails.Add(new OrganizationalDetails("6", "Design Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("7", "Design Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("8", "Development Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("9", "Drafting Supervisor", "#2E95D8", "6", ""));
            organizationaldetails.Add(new OrganizationalDetails("10", "Operations Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("11", "Statistics Department", "#2E95D8", "10", ""));
            organizationaldetails.Add(new OrganizationalDetails("12", "Logistics Department", "#2E95D8", "10", ""));
            organizationaldetails.Add(new OrganizationalDetails("16", "Marketing Manager", "#1859B7", "1", "right"));
            organizationaldetails.Add(new OrganizationalDetails("17", "Oversea sales Manager", "#2E95D8", "16", ""));
            organizationaldetails.Add(new OrganizationalDetails("18", "Petroleum Manager", "#2E95D8", "16", ""));
            organizationaldetails.Add(new OrganizationalDetails("20", "Service Dept. Manager", "#2E95D8", "16", ""));
            organizationaldetails.Add(new OrganizationalDetails("21", "Quality Department", "#2E95D8", "16", ""));
            return organizationaldetails;
        }
    }

}
