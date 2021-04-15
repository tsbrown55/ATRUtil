using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SyncfusionMvcApplicationRichTextEditor3.Models
{
    public class IncidentReviewsContext : DbContext
    {
        public IncidentReviewsContext() : base(nameOrConnectionString: "name=IncidentReviewsContext")
        {
        }

        public DbSet<IncidentReview> IncidentReviews { get; set; }
    }
}