﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using SP = Microsoft.SharePoint.Client;

namespace SyncfusionMvcApplicationRichTextEditor3.Models
{
    public class KanbanDataModels
    {
        public string Id { get; set; }
        public int ListId{ get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Tags { get; set; }
        public Double Estimate { get; set; }
        public string Assignee { get; set; }
        public int RankId { get; set; }
        public string Color { get; set; }
        public string ClassName { get; set; }
        public string Value { get; set; }
        public string OrderID { get; set; }
        public string Size { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }


        public List<KanbanDataModels> GetSpKanbanDataObjects()
        {
            List<KanbanDataModels> kanbanItems = new List<KanbanDataModels>();
            System.Net.NetworkCredential creds = new System.Net.NetworkCredential("app4rent_sp16@geek-ish.com", "helloWorld55!");
            Microsoft.SharePoint.Client.ClientContext ctx = new Microsoft.SharePoint.Client.ClientContext("http://sp16.geek-ish.com/") { Credentials = creds };
            string listName = "ADA_Eligibility_Status4";//"ADA_Eligibility_Status"; //"TRAP Active Cases1"; //"DashboardSummaryCard";
            SP.ListItemCollection items = GetSpListItems(ctx, "http://sp16.geek-ish.com/", listName, string.Empty);
            if (items != null)
            {
                foreach (SP.ListItem li in items)
                {
                    KanbanDataModels kanbanItem = new KanbanDataModels();
                    {
                        double d;
                        int i;
                        try
                        {
                            //kanbanItem.Id = li["ID"] == null ? string.Empty : li["ID"].ToString().Trim(); //"Task 1",
                            kanbanItem.Title = li["Title"] == null ? string.Empty : li["Title"].ToString().Trim(); //"Task  - 29001",
                            kanbanItem.Status = li["Status"] == null ? string.Empty : ((SP.FieldLookupValue)li["Status"]).LookupValue;//li["Status"].ToString().Trim(); //"Open",
                            kanbanItem.Summary = li["Summary"] == null ? string.Empty : li["Summary"].ToString().Trim(); //"Analyze the new requirements gathered from the customer.",
                            //kanbanItem.Type = li["Type"] == null ? string.Empty : li["Type"].ToString().Trim(); //"Story",
                            kanbanItem.Priority = li["Priority"] == null ? string.Empty : li["Priority"].ToString().Trim(); //"Low",
                            //kanbanItem.Tags = li["Tags"] == null ? string.Empty : li["Tags"].ToString().Trim(); //"Analyze,Customer",
                            //kanbanItem.Estimate = double.TryParse(li["CompletionTime"] == null ? "0" : li["CompletionTime"].ToString().Trim(), out d) ? d : 0; //3.5,
                            kanbanItem.Assignee = li["Assignee"] == null ? string.Empty : ((SP.FieldLookupValue)li["Assignee"]).LookupValue;//li["Assignee"].ToString().Trim(); //"Cean Carter",
                            //kanbanItem.RankId = int.TryParse(li["RankId"] == null ? "0" : li["RankId"].ToString().Trim(), out i) ? i : 0; //1,
                            //kanbanItem.Color = li["Color"] == null ? string.Empty : li["Color"].ToString().Trim(); // "#008000",
                            //kanbanItem.ClassName = li["ClassName"] == null ? string.Empty : li["ClassName"].ToString().Trim(); // "e-story, e-low, e-nancy-davloio"
                        }
                        catch (Exception e)
                        {
                            Debug.Print(e.Message);
                        }

                        kanbanItems.Add(kanbanItem);
                    }
                }
            }

            return kanbanItems;
        }

        static Microsoft.SharePoint.Client.ListItemCollection GetSpListItems(Microsoft.SharePoint.Client.ClientContext ctx, string siteUrl, string listName, string camlXml)//string[] listFields)
        {
            Microsoft.SharePoint.Client.List list = ctx.Web.Lists.GetByTitle(listName);
            Microsoft.SharePoint.Client.CamlQuery camlQuery = new Microsoft.SharePoint.Client.CamlQuery() { ViewXml = camlXml };
            Microsoft.SharePoint.Client.ListItemCollection lic = list.GetItems(camlQuery);

            ctx.Load(lic);
            ctx.ExecuteQuery();
            return lic;
        }

        public List<KanbanDataModels> KanbanTasks()
        {
            List<KanbanDataModels> TaskDetais = new List<KanbanDataModels>();
            TaskDetais.Add(new KanbanDataModels { Id = "Task 1", Title = "Task  - 29001", Status = "Open", Summary = "Analyze the new requirements gathered from the customer.", Type = "Story", Priority = "Low", Tags = "Analyze,Customer", Estimate = 3.5, Assignee = "Cean Carter", RankId = 1, Color = "#008000", ClassName = "e-story, e-low, e-nancy-davloio" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 2", Title = "Task  - 29002", Status = "InProgress", Summary = "Improve application performance", Type = "Improvement", Priority = "Normal", Tags = "Improvement", Estimate = 6, Assignee = "Kimberly Rogers", RankId = 1, Color = "#5187c6", ClassName = "e-improvement, e-normal, e-andrew-fuller" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 3", Title = "Task  - 29003", Status = "Open", Summary = "Arrange a web meeting with the customer to get new requirements.", Type = "Others", Priority = "Critical", Tags = "Meeting", Estimate = 5.5, Assignee = "Kimberly Rogers", RankId = 2, Color = "#5187c6", ClassName = "e-others, e-critical, e-janet-leverling" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 4", Title = "Task  - 29004", Status = "InProgress", Summary = "Fix the issues reported in the IE browser.", Type = "Bug", Priority = "Release Breaker", Tags = "IE", Estimate = 2.5, Assignee = "Kimberly Rogers", RankId = 2, Color = "#ff0000", ClassName = "e-bug, e-release, e-janet-leverling" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 5", Title = "Task  - 29005", Status = "Review", Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Low", Tags = "Customer", Estimate = 3.5, Assignee = "Sharon McCalister", RankId = 1, Color = "#ff0000", ClassName = "e-bug, e-low, e-steven-walker" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 6", Title = "Task  - 29007", Status = "Validate", Summary = "Validate new requirements", Type = "Improvement", Priority = "Low", Tags = "Validation", Estimate = 1.5, Assignee = "Teresa Ridgeway", RankId = 1, Color = "#57b94c", ClassName = "e-improvement, e-low, e-robert-king" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 7", Title = "Task  - 29009", Status = "Review", Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker", Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Cean Carter", RankId = 2, Color = "#ff0000", ClassName = "e-bug, e-release, e-nancy-davloio" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 8", Title = "Task  - 29010", Status = "Close", Summary = "Test the application in the IE browser.", Type = "Story", Priority = "Low", Tags = "Review,IE", Estimate = 5.5, Assignee = "Aunjeria Weeks", RankId = 3, Color = "#008000", ClassName = "e-story, e-low, e-margaret-hamilt" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 9", Title = "Task  - 29011", Status = "Validate", Summary = "Validate the issues reported by the customer.", Type = "Story", Priority = "High", Tags = "Validation,Fix", Estimate = 1, Assignee = "Sharon McCalister", RankId = 1, Color = "#008000", ClassName = "e-story, e-high, e-steven-walker" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 10", Title = "Task  - 29015", Status = "Open", Summary = "Show the retrieved data from the server in grid control.", Type = "Story", Priority = "High", Tags = "Database,SQL", Estimate = 5.5, Assignee = "Aunjeria Weeks", RankId = 4, Color = "#008000", ClassName = "e-story, e-high, e-margaret-hamilt" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 11", Title = "Task  - 29016", Status = "InProgress", Summary = "Fix cannot open user’s default database SQL error.", Priority = "Critical", Type = "Bug", Tags = "Database,Sql2008", Estimate = 2.5, Assignee = "Kimberly Rogers", RankId = 4, Color = "#ff0000", ClassName = "e-bug, e-critical, e-janet-leverling" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 12", Title = "Task  - 29017", Status = "Review", Summary = "Fix the issues reported in data binding.", Type = "Story", Priority = "Normal", Tags = "Databinding", Estimate = 3.5, Assignee = "Kimberly Rogers", RankId = 4, Color = "#008000", ClassName = "e-story, e-normal, e-janet-leverling" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 13", Title = "Task  - 29018", Status = "Close", Summary = "Analyze SQL server 2008 connection.", Type = "Story", Priority = "Release Breaker", Tags = "Grid,Sql", Estimate = 2, Assignee = "Kimberly Rogers", RankId = 4, Color = "#008000", ClassName = "e-story, e-release, e-andrew-fuller" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 14", Title = "Task  - 29019", Status = "Validate", Summary = "Validate databinding issues.", Type = "Story", Priority = "Low", Tags = "Validation", Estimate = 1.5, Assignee = "Aunjeria Weeks", RankId = 1, Color = "#008000", ClassName = "e-story, e-low, e-margaret-hamilt" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 15", Title = "Task  - 29020", Status = "Close", Summary = "Analyze grid control.", Type = "Story", Priority = "High", Tags = "Analyze", Estimate = 2.5, Assignee = "Aunjeria Weeks", RankId = 5, Color = "#008000", ClassName = "e-story, e-high, e-margaret-hamilt" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 16", Title = "Task  - 29021", Status = "Close", Summary = "Stored procedure for initial data binding of the grid.", Type = "Others", Priority = "Release Breaker", Tags = "Databinding", Estimate = 1.5, Assignee = "Sharon McCalister", RankId = 6, Color = "#5187c6", ClassName = "e-others, e-release, e-steven-walker" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 17", Title = "Task  - 29022", Status = "Close", Summary = "Analyze stored procedures.", Type = "Story", Priority = "Release Breaker", Tags = "Procedures", Estimate = 5.5, Assignee = "Kimberly Rogers", RankId = 7, Color = "#008000", ClassName = "e-story, e-release, e-janet-leverling" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 18", Title = "Task  - 29023", Status = "Validate", Summary = "Validate editing issues.", Type = "Story", Priority = "Critical", Tags = "Editing", Estimate = 1, Assignee = "Cean Carter", RankId = 1, Color = "#008000", ClassName = "e-story, e-critical, e-nancy-davloio" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 19", Title = "Task  - 29024", Status = "Review", Summary = "Test editing functionality.", Type = "Story", Priority = "Normal", Tags = "Editing,Test", Estimate = 0.5, Assignee = "Cean Carter", RankId = 5, Color = "#008000", ClassName = "e-story, e-normal, e-nancy-davloio" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 20", Title = "Task  - 29025", Status = "Open", Summary = "Enhance editing functionality.", Type = "Improvement", Priority = "Low", Tags = "Editing", Estimate = 3.5, Assignee = "Kimberly Rogers", RankId = 5, Color = "#57b94c", ClassName = "e-improvement, e-low, e-andrew-fuller" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 21", Title = "Task  - 29026", Status = "InProgress", Summary = "Improve the performance of the editing functionality.", Type = "Epic", Priority = "High", Tags = "Performance", Estimate = 6, Assignee = "Cean Carter", RankId = 5, Color = "#edba3c", ClassName = "e-epic, e-high, e-nancy-davloio" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 22", Title = "Task  - 29027", Status = "Open", Summary = "Arrange web meeting with the customer to show editing demo.", Type = "Others", Priority = "High", Tags = "Meeting,Editing", Estimate = 5.5, Assignee = "Sharon McCalister", RankId = 6, Color = "#5187c6", ClassName = "e-others, e-high, e-steven-walker" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 23", Title = "Task  - 29029", Status = "Review", Summary = "Fix the editing issues reported by the customer.", Type = "Bug", Priority = "Low", Tags = "Editing,Fix", Estimate = 3.5, Assignee = "Kimberly Rogers", RankId = 6, Color = "#ff0000", ClassName = "e-bug, e-low, e-janet-leverling" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 24", Title = "Task  - 29030", Status = "Testing", Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Critical", Tags = "Customer", Estimate = 3.5, Assignee = "Sharon McCalister", RankId = 1, Color = "#ff0000", ClassName = "e-bug, e-critical, e-steven-walker" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 25", Title = "Task  - 29031", Status = "Testing", Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker", Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Cean Carter", RankId = 2, Color = "#ff0000", ClassName = "e-bug, e-release, e-nancy-davloio" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 26", Title = "Task  - 29032", Status = "Testing", Summary = "Check Login page validation.", Type = "Story", Priority = "Release Breaker", Tags = "Testing", Estimate = 0.5, Assignee = "Lori Yeager", RankId = 3, Color = "#008000", ClassName = "e-story, e-release, e-michael-suyama" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 27", Title = "Task  - 29033", Status = "Testing", Summary = "Fix the issues reported in data binding.", Type = "Story", Priority = "Normal", Tags = "Databinding", Estimate = 3.5, Assignee = "Kimberly Rogers", RankId = 4, Color = "#008000", ClassName = "e-story, e-normal, e-janet-leverling" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 28", Title = "Task  - 29034", Status = "Testing", Summary = "Test editing functionality.", Type = "Story", Priority = "Normal", Tags = "Editing,Test", Estimate = 0.5, Assignee = "Cean Carter", RankId = 5, Color = "#008000", ClassName = "e-story, e-normal, e-nancy-davloio" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 29", Title = "Task  - 29035", Status = "Testing", Summary = "Fix editing issues reported in Firefox.", Type = "Bug", Priority = "Critical", Tags = "Editing,Fix", Estimate = 1.5, Assignee = "Teresa Ridgeway", RankId = 7, Color = "#ff0000", ClassName = "e-bug, e-critical, e-robert-king" });
            TaskDetais.Add(new KanbanDataModels { Id = "Task 30", Title = "Task  - 29036", Status = "Testing", Summary = "Test editing feature in the IE browser.", Type = "Story", Priority = "Normal", Tags = "Testing", Estimate = 5.5, Assignee = "Kimberly Rogers", RankId = 10, Color = "#008000", ClassName = "e-story, e-normal, e-janet-leverling" });
            return TaskDetais;
        }

        public List<KanbanDataModels> KanbanCardTasks()
        {
            List<KanbanDataModels> CardData = new List<KanbanDataModels>();
            CardData.Add(new KanbanDataModels { Id = "Task 1", Title = "Task  - 29001", Status = "Open", Summary = "Analyze customer requirements.", Priority = "High", Tags = "Bug, Release Bug", RankId = 1, Assignee = "Cean Carter" });
            CardData.Add(new KanbanDataModels { Id = "Task 2", Title = "Task  - 29002", Status = "InProgress", Summary = "Add responsive support to application", Priority = "Low", Tags = "Story, Kanban", RankId= 1, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 3", Title = "Task  - 29003", Status = "Open", Summary = "Show the retrived data from the server in grid control.", Priority = "High", Tags = "Bug, Breaking Issue", RankId = 2, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 4", Title = "Task  - 29004", Status = "Open", Summary = "Fix the issues reported in the IE browser.", Priority = "High", Tags = "Bug, Customer", RankId = 3, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 5", Title = "Task  - 29005", Status = "Review", Summary = "Improve application performance.", Priority = "Normal", Tags = "Story, Kanban", RankId = 1, Assignee = "Sharon McCalister" });
            CardData.Add(new KanbanDataModels { Id = "Task 6", Title = "Task  - 29009", Status = "Review", Summary = "API Improvements.", Priority = "Critical", Tags = "Bug, Customer", RankId = 2, Assignee = "Cean Carter" });
            CardData.Add(new KanbanDataModels { Id = "Task 7", Title = "Task  - 29010", Status = "Close", Summary = "Fix cannot open user's default database sql error.", Priority = "High", Tags = "Bug, Internal", RankId = 8, Assignee = "Aunjeria Weeks" });
            CardData.Add(new KanbanDataModels { Id = "Task 8", Title = "Task  - 29015", Status = "Open", Summary = "Fix the filtering issues reported in safari.", Priority = "Critical", Tags = "Bug, Breaking Issue", RankId = 4, Assignee = "Aunjeria Weeks" });
            CardData.Add(new KanbanDataModels { Id = "Task 9", Title = "Task  - 29016", Status = "Review", Summary = "Fix the issues reported in IE browser.", Priority = "High", Tags = "Bug, Customer", RankId = 3, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 10", Title = "Task  - 29017", Status = "Review", Summary = "Enhance editing functionality.", Priority = "Normal", Tags = "Story, Kanban", RankId = 4, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 11", Title = "Task  - 29018", Status = "Close", Summary = "Arrange web meeting with customer to get login page requirement.", Priority = "High", Tags = "Feature", RankId = 1, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 12", Title = "Task  - 29020", Status = "Close", Summary = "Login page validation.", Priority = "Low", Tags = "Bug", RankId = 2, Assignee = "Aunjeria Weeks" });
            CardData.Add(new KanbanDataModels { Id = "Task 13", Title = "Task  - 29021", Status = "Close", Summary = "Test the application in IE browser.", Priority = "Normal", Tags = "Bug", RankId = 3, Assignee = "Sharon McCalister" });
            CardData.Add(new KanbanDataModels { Id = "Task 14", Title = "Task  - 29022", Status = "Close", Summary = "Analyze stored procedure.", Priority = "Critical", Tags = "CustomSample", RankId = 4, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 15", Title = "Task  - 29024", Status = "Review", Summary = "Check login page validation.", Priority = "Low", Tags = "Story", RankId = 5, Assignee = "Cean Carter" });
            CardData.Add(new KanbanDataModels { Id = "Task 16", Title = "Task  - 29025", Status = "Close", Summary = "Add input validation for editing.", Priority = "Critical", Tags = "Bug, Breaking Issue", RankId = 5, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 17", Title = "Task  - 29026", Status = "InProgress", Summary = "Improve performance of editing functionality.", Priority = "Critical", Tags = "Bug, Customer", RankId = 2, Assignee = "Cean Carter" });
            CardData.Add(new KanbanDataModels { Id = "Task 18", Title = "Task  - 29027", Status = "Open", Summary = "Arrange web meeting for cutomer requirement.", Priority = "High", Tags = "Story", RankId = 5, Assignee = "Sharon McCalister" });
            CardData.Add(new KanbanDataModels { Id = "Task 19", Title = "Task  - 29029", Status = "Review", Summary = "Fix the issues reported by the customer.", Priority = "High", Tags = "Bug", RankId = 6, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 20", Title = "Task  - 29030", Status = "InProgress", Summary = "Test editing functionality", Priority = "Low", Tags = "Story", RankId = 3, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 21", Title = "Task  - 29031", Status = "InProgress", Summary = "Check filtering validation", Priority = "Normal", Tags = "Feature, Release", RankId = 4, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 22", Title = "Task  - 29032", Status = "InProgress", Summary = "Arrange web meeting with customer to get login page requirement", Priority = "Critical", Tags = "Feature", RankId = 5, Assignee = "Aunjeria Weeks" });
            CardData.Add(new KanbanDataModels { Id = "Task 23", Title = "Task  - 29033", Status = "Open", Summary = "Arrange web meeting with customer to get editing requirements", Priority = "Critical", Tags = "Story, Improvement", RankId = 6, Assignee = "Kimberly Rogers" });
            CardData.Add(new KanbanDataModels { Id = "Task 24", Title = "Task  - 29034", Status = "InProgress", Summary = "Fix the issues reported by the customer.", Priority = "Critical", Tags = "Bug, Customer", RankId = 6, Assignee = "Sharon McCalister" });
            CardData.Add(new KanbanDataModels { Id = "Task 25", Title = "Task  - 29035", Status = "Close", Summary = "Fix the issues reported in Safari browser.", Priority = "High", Tags = "Bug", RankId = 6, Assignee = "Cean Carter" });
            CardData.Add(new KanbanDataModels { Id = "Task 26", Title = "Task  - 29036", Status = "Review", Summary = "Check Login page validation.", Priority = "Critical", Tags = "Bug, Customer", RankId = 7, Assignee = "Aunjeria Weeks" });
            CardData.Add(new KanbanDataModels { Id = "Task 27", Title = "Task  - 29037", Status = "Open", Summary = "Fix the issues reported in data binding.", Priority = "Normal", Tags = "Bug", Estimate = 3.5, RankId = 7, Assignee = "Sharon McCalister" });
            CardData.Add(new KanbanDataModels { Id = "Task 28", Title = "Task  - 29038", Status = "Close", Summary = "Test editing functionality.", Priority = "Normal", Tags = "Story", Estimate = 0.5, RankId = 7, Assignee = "Sharon McCalister" });
            return CardData;
        }

        public List<KanbanDataModels> KanbanPizzaData()
        {
            List<KanbanDataModels> PizzaData = new List<KanbanDataModels>();
            PizzaData.Add(new KanbanDataModels { Id = "1", OrderID = "Order ID - #16365", Title = "Mexican Green Wave", Type = "Vegetarian", Size = "Small", Category = "Order", Description = "Stromboli sandwich with chili sauce.", Tags = "Onions, Pepper, Cheese", ImageURL = "Mexican_Green_Wave.jpg", Price="$4.79" });
            PizzaData.Add(new KanbanDataModels { Id = "2", OrderID = "Order ID - #16366", Title = "Fresh Veggie", Type = "Vegetarian", Size = "Medium", Category = "Order", Description = "Veggie with Onions and Capsicum.", Tags = "Onions, Capsicum", ImageURL = "Fresh_Veggie.jpg", Price = "$11.99"});
            PizzaData.Add(new KanbanDataModels { Id = "3", OrderID = "Order ID - #16367", Title = "Peppy Paneer", Type = "Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "It's made using toppings of tomato, mozzarella cheese and fresh basil, which represent the red, white and green of the Italian flag.", Tags = "Onions, Pepper, Cheese", ImageURL = "Peppy_Paneer.jpg", Price= "$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "4", OrderID = "Order ID - #16368", Title = "Margherita", Type = "Vegetarian", Size = "Small", Category = "Menu", Description = "Lebanese Pizza topped with tomato sauce.", Tags = "Onions, Pepper, Cheese", ImageURL = "Margherit.jpg", Price = "$4.79" });
            PizzaData.Add(new KanbanDataModels { Id = "5", OrderID = "Order ID - #16369", Title = "Indian Tandoori Paneer", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Tandoori Paneer with capsicum, red paprika and mint.", Tags = "Paneer, Capsicum, Paprika, Mint", ImageURL = "IndianTandooriPaneer.jpg", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "6", OrderID = "Order ID - #16370", Title = "Pepper Barbecue Chicken", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Serve", Description = "Pepper Barbecue Chicken with cheese.", Tags = "Pepper, Chicken, Cheese", ImageURL = "Pepper_Barbeque.jpg", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "7", OrderID = "Order ID - #16371", Title = "Chicken Sausage", Type = "Non-Vegetarian", Size = "Large", Category = "Ready to Serve", Description = "Chicken Sausage with cheese.", Tags = "Cheese, Chicken", ImageURL = "Chicken_Sausage.jpg", Price= "$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "8", OrderID = "Order ID - #16372", Title = "Chicken Golden Delight", Type = "Non-Vegetarian", Size = "Large", Category = "Order", Description = "Barbeque chicken with a topping of golden corn loaded with extra cheese.", Tags = "Onions, BBQ, Pepper, Prawn", ImageURL = "Chicken_Golden_Delight.jpg", Price="$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "9", OrderID = "Order ID - #16373", Title = "Pepper Barbecue and Onion", Type = "Non-Vegetarian", Size = "Medium", Category = "Menu", Description = "Pepper Barbecue chicken with Onion.", Tags = "Onions, Pepper, Chicken", ImageURL = "Pepper_Barbeque_Onion.jpg", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "10", OrderID = "Order ID - #16374", Title = "Chicken Fiesta", Type = "Non-Vegetarian", Size = "Small", Category = "Delivered", Description = "Grilled Chicken Rashers with Peri-Peri chicken, Onion and Capsicum.", Tags = "Chicken, Onion, Capsicum", ImageURL = "chunky-chicken.png", Price= "$4.79" });
            PizzaData.Add(new KanbanDataModels { Id = "11", OrderID = "Order ID - #16375", Title = "Double Cheese Margherita", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Margherita with chili sauce and double Cheese.", Tags = "Onions, Pepper, Cheese", ImageURL = "Double_Cheese_Margherita.jpg", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "12", OrderID = "Order ID - #16376", Title = "Veggie Paradise", Type = "Vegetarian", Size = "Large", Category = "Menu", Description = "Veggie Delight with Goldern Corn, Black Olives, Capsicum and red Paprika.", Tags = "Goldern Corn, Capsicum, Pepper", ImageURL = "Veggie_Paradise.jpg", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "13", OrderID = "Order ID - #16377", Title = "Cheese and Corn", Type = "Vegetarian", Size = "Large", Category = "Order", Description = "Cheese with golden corn.", Tags = "Cheese, Corn", ImageURL = "Corn_Cheese.jpg", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "14", OrderID = "Order ID - #16378", Title = "Chicken Tikka", Type = "Non-Vegetarian", Size = "Medium", Category = "Ready to Serve", Description = "Tandoori masala with Chicken Tikka, Onion, red paprika and mint.", Tags = "Chicken, Tikka, Onion, Paprika, Mint", ImageURL = "IndianChickenTikka.jpg", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "15", OrderID = "Order ID - #16379", Title = "Chicken Dominator", Type = "Non-Vegetarian", Size = "Small", Category = "Menu", Description = "Double Pepper Barbecue Chicken with Peri-Peri Chicken, Chicken Tikka, Grilled and Rashers.", Tags = "Pepper, Chicken", ImageURL = "Dominator.jpg", Price = "$4.79" });
            PizzaData.Add(new KanbanDataModels { Id = "16", OrderID = "Order ID - #16380", Title = "Deluxe Veggie", Type = "Vegetarian", Size = "Medium", Category = "Delivered", Description = "Onions and Capsicum those delectable mushrooms with paneer and golden corn to top it all.", Tags = "Onions, Capsicum, Mushrooms, Paneer, Corn", ImageURL = "Deluxe_Veggie.jpg", Price = "$11.99" });
            PizzaData.Add(new KanbanDataModels { Id = "17", OrderID = "Order ID - #16381", Title = "Farm House", Type = "Vegetarian", Size = "Large", Category = "Menu", Description = "Crunchy, crisp capsicum, succulent mushrooms and fresh tomatoes.", Tags = "Capsicum, Mushrooms, Tomatoes", ImageURL = "Farmhouse.jpg", Price = "$14.99" });
            PizzaData.Add(new KanbanDataModels { Id = "18", OrderID = "Order ID - #16382", Title = "Veg Extravanganza", Type = "Vegetarian", Size = "Large", Category = "Served", Description = "Pizza with golden corn, exotic black olives, crunchy onions, crisp capsicum, succulent mushrooms, juicyfresh tomatoes and jalapeno with extra cheese to go all around.", Tags = "Corn, Olives, Onions, Capsicum, Mushrooms, Tomatoes, Cheese", ImageURL = "Veg_Extravaganz.jpg", Price = "$14.99" });
            return PizzaData;
        }
    
            public List<KanbanDataModels> SortDropDowns()
        {
            List<KanbanDataModels> SortDropDown = new List<KanbanDataModels>();
            SortDropDown.Add(new KanbanDataModels {  Value = "Ascending"});
            SortDropDown.Add(new KanbanDataModels {  Value = "Descending"});
            return SortDropDown;
        }

        public List<KanbanDataModels> ColumnDropDowns()
        {
            List<KanbanDataModels> ColumnDropDown = new List<KanbanDataModels>();
            ColumnDropDown.Add(new KanbanDataModels { Value = "Column"});
            ColumnDropDown.Add(new KanbanDataModels { Value = "Swimlane"});
            return ColumnDropDown;
        }

        public List<KanbanDataModels> StatusData()
        {
            List<KanbanDataModels> StatusDropDown = new List<KanbanDataModels>();
            StatusDropDown.Add(new KanbanDataModels {ListId = 0 , Value = "To Do"});
            StatusDropDown.Add(new KanbanDataModels {ListId = 1, Value = "In Progress"});
            StatusDropDown.Add(new KanbanDataModels { ListId = 2, Value = "Done"});
            return StatusDropDown;
        }
        public List<KanbanDataModels> ApiData()
        {
            List<KanbanDataModels> ApiDropdown = new List<KanbanDataModels>();
            ApiDropdown.Add(new KanbanDataModels { Value = "Testing" });
            ApiDropdown.Add(new KanbanDataModels { Value = "Review" });
            ApiDropdown.Add(new KanbanDataModels { Value = "Validate" });
            return ApiDropdown;
        }

        public List<KanbanDataModels> DialogStatus()
        {
            List<KanbanDataModels> DialogdropDownStatus = new List<KanbanDataModels>();
            DialogdropDownStatus.Add(new KanbanDataModels { Value = "Open" });
            DialogdropDownStatus.Add(new KanbanDataModels { Value = "InProgress" });
            DialogdropDownStatus.Add(new KanbanDataModels { Value = "Testing" });
            DialogdropDownStatus.Add(new KanbanDataModels { Value = "Close" });
            return DialogdropDownStatus;
        }
   
        public List<KanbanDataModels> AssigneeData()
        {
            List<KanbanDataModels> assigneeData = new List<KanbanDataModels>();
            assigneeData.Add(new KanbanDataModels { Value = "Cean Carter" });
            assigneeData.Add(new KanbanDataModels { Value = "Kimberly Rogers" });
            assigneeData.Add(new KanbanDataModels { Value = "Kimberly Rogers" });
            assigneeData.Add(new KanbanDataModels { Value = "Sharon McCalister" });
            assigneeData.Add(new KanbanDataModels { Value = "Teresa Ridgeway" });
            assigneeData.Add(new KanbanDataModels { Value = "Aunjeria Weeks" });
            assigneeData.Add(new KanbanDataModels { Value = "Lori Yeager" });
            return assigneeData;
        }

        public List<KanbanDataModels> PriorityData()
        {
            List<KanbanDataModels> priorityData = new List<KanbanDataModels>();
            priorityData.Add(new KanbanDataModels { Value = "Low"});
            priorityData.Add(new KanbanDataModels { Value = "Normal"});
            priorityData.Add(new KanbanDataModels { Value = "Critical"});
            priorityData.Add(new KanbanDataModels { Value = "High" });
            priorityData.Add(new KanbanDataModels { Value = "Release Breaker"});
            return priorityData;
        }
    }

    public class KanbanDialogModels
    {

        public string text { get; set; }
        public string key { get; set; }
        public string type { get; set; }

        public List<KanbanDialogModels> DialogField()
        {
            List<KanbanDialogModels> DialogFields = new List<KanbanDialogModels>();
            DialogFields.Add(new KanbanDialogModels { text = "ID" , key= "Id" , type ="TextBox"});
            DialogFields.Add(new KanbanDialogModels { key = "Category", type = "DropDown" });
            DialogFields.Add(new KanbanDialogModels { key = "Title", type = "TextBox" });
            DialogFields.Add(new KanbanDialogModels { key = "Size", type = "TextBox" });
            DialogFields.Add(new KanbanDialogModels { key = "Description", type = "TextArea" });
            return DialogFields;
        }

        public List<KanbanDialogModels> DialogCardField()
        {
            List<KanbanDialogModels> DialogCardFields = new List<KanbanDialogModels>();
            DialogCardFields.Add(new KanbanDialogModels { text = "ID", key = "Title", type = "TextBox" });
            DialogCardFields.Add(new KanbanDialogModels { key = "Status", type = "DropDown" });
            DialogCardFields.Add(new KanbanDialogModels { key = "Assignee", type = "DropDown" });
            DialogCardFields.Add(new KanbanDialogModels { key = "RankId", type = "TextBox" });
            DialogCardFields.Add(new KanbanDialogModels { key = "Summary", type = "TextArea" });
            return DialogCardFields;
        }
    }
}
