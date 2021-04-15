using System;
using System.Collections.Generic;
using SP = Microsoft.SharePoint.Client;
//using DelDOTLaneTraffic1.Util;

namespace DelDOTLaneTraffic1.Models
{
    public class SplineGraphData
    {
            public int MonthId { get; set; }
            public DateTime Date { get; set; }
            public double Value { get; set; }

        public List<SplineGraphData> GetSpSplineGraphDataObjects()
        {
            List<SplineGraphData> splineGraphObjs = new List<SplineGraphData>();
            System.Net.NetworkCredential creds = new System.Net.NetworkCredential("app4rent_sp16@geek-ish.com", "helloWorld55!");
            Microsoft.SharePoint.Client.ClientContext ctx = new Microsoft.SharePoint.Client.ClientContext("http://sp16.geek-ish.com/") { Credentials = creds };
            string listName = "GraphWidgetTestData";//"ADA_Eligibility_Status4"; 
            SP.ListItemCollection items = /*SpUtil.*/GetSpListItems(ctx, "http://sp16.geek-ish.com/", listName, string.Empty);
            if (items != null)
            {
                foreach (SP.ListItem li in items)
                {
                    SplineGraphData dataObj = new SplineGraphData();
                    {
                        int i = 0;
                        try
                        {
                            int monthId = 1;
                            monthId = li["Month"] == null ? 1 : ((SP.FieldLookupValue) (li["Month"])).LookupId;
                            dataObj.MonthId = monthId;
                            dataObj.Date = new DateTime(DateTime.Now.Year, monthId, 1);
                            dataObj.Value = li["Value"] == null ? 0 : int.TryParse(li["Value"].ToString(), out i) ? i : 0;
                        }
                        catch
                        {
                            // ignored
                        }
                        splineGraphObjs.Add(dataObj);
                    }
                }
            }

            return splineGraphObjs;
        }

        public static Microsoft.SharePoint.Client.ListItemCollection GetSpListItems(
            Microsoft.SharePoint.Client.ClientContext ctx, string siteUrl, string listName,
            string camlXml)
        {
            Microsoft.SharePoint.Client.List list = ctx.Web.Lists.GetByTitle(listName);
            Microsoft.SharePoint.Client.CamlQuery camlQuery = new Microsoft.SharePoint.Client.CamlQuery() { ViewXml = camlXml };
            Microsoft.SharePoint.Client.ListItemCollection lic = list.GetItems(camlQuery);

            ctx.Load(lic);
            ctx.ExecuteQuery();
            return lic;
        }
    }
}