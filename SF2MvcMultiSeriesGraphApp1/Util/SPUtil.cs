using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SP = Microsoft.SharePoint.Client;

namespace SyncFusionMvcControlsApplication1.Util
{
    public class SpUtil
    {

        public static Microsoft.SharePoint.Client.ListItemCollection GetSpListItems(
            Microsoft.SharePoint.Client.ClientContext ctx, string siteUrl, string listName,
            string camlXml)
        {
            Microsoft.SharePoint.Client.List list = ctx.Web.Lists.GetByTitle(listName);
            Microsoft.SharePoint.Client.CamlQuery camlQuery = new Microsoft.SharePoint.Client.CamlQuery()
                {ViewXml = camlXml};
            Microsoft.SharePoint.Client.ListItemCollection lic = list.GetItems(camlQuery);

            ctx.Load(lic);
            ctx.ExecuteQuery();
            return lic;
        }
    }
}