using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SyncfusionMvcApplication1.Models
{
    [Table("ProjectData")]
    public class ProjectData
    {
        [Key] public int ProjectDataId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        public string StatusDisplayName { get; set; }
        public int Value;
        public int PercentComplete { get; set; }

        public ProjectData()
        {
            StatusDisplayName = "success";
        }
    }
}