using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SyncfusionMvcApplication1.Models;

namespace SyncfusionMvcApplication1.Models
{
    public class ProjectDatasContext : DbContext
    {
        public ProjectDatasContext()
            : base("name=ProjectDatasContext")
        {
        }
        public DbSet<ProjectData> ProjectDatas { get; set; }
    }
}



