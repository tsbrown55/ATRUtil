using Syncfusion.EJ2.Navigations;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Dapper;
//using System;
using System.Data.SqlClient;
using Syncfusion.EJ2.PivotView;
using SyncfusionMvcApplicationRichTextEditor3.Models;
//using System.Linq;

namespace SyncfusionMvcApplicationRichTextEditor3.Controllers
{
    public partial class TreeViewController : Controller
    {
        public readonly int _NumNodes = 14;

        public ActionResult FamilyTreeView1()
        {
            int n = _NumNodes + 1;
            TreeViewFieldsSettings[] templateFields = new TreeViewFieldsSettings[n];
            for (int i = 1; i < n; i++)
            {
                templateFields[i] = new TreeViewFieldsSettings();
                templateFields[i].DataSource = TreeViewTemplate.GetFamilyMembersTemplate(i);
                templateFields[i].Id = "id";
                templateFields[i].Text = "name";
                templateFields[i].ParentID = "pid";
                templateFields[i].HasChildren = "HasChild";
                templateFields[i].Expanded = "Expanded";
                templateFields[i].Selected = "Selected";
             //   templateFields[i].ImageUrl = "imageUrl";
            }

            ViewBag.TemplateFields = templateFields;

            return View();
        }

        public ActionResult TreeViewFeatures()
        {
            int n = _NumNodes + 1;
            TreeViewFieldsSettings[] templateFields = new TreeViewFieldsSettings[n];
            for (int i = 1; i < n; i++)
            {
                templateFields[i] = new TreeViewFieldsSettings();

                //TreeViewTemplate template = new TreeViewTemplate();
                templateFields[i].DataSource = TreeViewTemplate.GetTreeViewTemplate(i);
                templateFields[i].Id = "id";
                templateFields[i].Text = "name";
                templateFields[i].ParentID = "pid";
                templateFields[i].HasChildren = "HasChild";
                templateFields[i].Expanded = "Expanded";
                templateFields[i].Selected = "Selected";
            }

            ViewBag.TemplateFields = templateFields;

            return View();
        }
    }
    public class TreeViewTemplate
    {
        public string name { get; set; }
        public string Count { get; set; }
        public int id { get; set; }
        public int pid { get; set; }
        public bool HasChild { get; set; }
        public bool Expanded { get; set; }
        public bool Selected { get; set; }
        public string imageUrlPath { get; set; }

        public static List<TreeViewTemplate> GetFamilyMembersTemplate(int rootElderId)
        {
            List<TreeViewTemplate> familyMembersTemplate = new List<TreeViewTemplate>();

            string sql = string.Format("select * from FamilyTreeMembers1 where ItemId like '{0}%' order by ID ", rootElderId);
            string connectionString = @"Data Source=murach.db.4713700.hostedresource.com;Initial Catalog=murach;Persist Security Info=True;User ID=murach;Password=helloWorld55!";
            using (var conn = new SqlConnection(connectionString))
            {
                var familyMembers = conn.Query<FamilyMember>(sql).ToList();
                foreach (FamilyMember fm in familyMembers)
                {
                    familyMembersTemplate.Add(new TreeViewTemplate()
                    {
                        id = fm.Id,
                        name = fm.ItemName,
                        HasChild = fm.HasChildren,
                        pid = fm.ParentId,
                        imageUrlPath = fm.ImageUrl
                    });
                }
            }
            return familyMembersTemplate;
        }

        public static List<TreeViewTemplate> GetTreeViewTemplate(int rootParentId)
        {
            List<TreeViewTemplate> localData = new List<TreeViewTemplate>();
            //localData.Add(new TreeViewTemplate {id = 1, name = "Favorites", HasChild = true});
            //localData.Add(new TreeViewTemplate {id = 2, pid = 1, name = "Sales Reports", count = "4"});
            //localData.Add(new TreeViewTemplate {id = 3, pid = 1, name = "Sent Items"});
            //localData.Add(new TreeViewTemplate {id = 4, pid = 1, name = "Marketing Reports ", count = "6"});
            //localData.Add(new TreeViewTemplate {id = 5, name = "My Folder", HasChild = true, Expanded = true});
            //localData.Add(new TreeViewTemplate {id = 6, pid = 5, name = "Inbox", Selected = true, count = "20"});
            //localData.Add(new TreeViewTemplate {id = 7, pid = 5, name = "Drafts", count = "5"});
            //localData.Add(new TreeViewTemplate {id = 8, pid = 5, name = "Deleted Items"});
            //localData.Add(new TreeViewTemplate {id = 9, pid = 5, name = "Sent Items"});
            //localData.Add(new TreeViewTemplate {id = 10, pid = 5, name = "Sales Reports", count = "4"});
            //localData.Add(new TreeViewTemplate {id = 11, pid = 5, name = "Marketing Reports", count = "6"});
            //localData.Add(new TreeViewTemplate {id = 12, pid = 5, name = "Outbox"});

            //int appDomainId = 
            string sql = "SELECT *  FROM [DTC].[dbo].[TrapezeNavItems]";
            sql = "SELECT *  FROM TrapezeNavItems";
            sql = string.Format("select * from TrapezeNavItems where ItemId like '{0}%' order by ID ", rootParentId);
            string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=DTC;Integrated Security=True";
            connectionString = @"Data Source=murach.db.4713700.hostedresource.com;Initial Catalog=murach;Persist Security Info=True;User ID=murach;Password=helloWorld55!";
            connectionString = @"Data Source=sql7002.site4now.net;User ID=DB_A3E75F_gk55_admin;Password=helloWorld55!";
            using (var conn = new SqlConnection(connectionString))
            {
                var trapNavItems = conn.Query<TrapezeNavItem>(sql).ToList();
                foreach (TrapezeNavItem tni in trapNavItems)
                {
                    localData.Add(new TreeViewTemplate()
                    {
                        id = tni.Id,
                        name = tni.ItemName,
                        HasChild = tni.HasChildren,
                        pid = tni.ParentId
                    });
                }
            }
            return localData;
        }
    }
}
