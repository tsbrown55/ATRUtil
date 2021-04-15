using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SyncfusionMvcApplicationRichTextEditor3.Models
{
    public class IncidentReview
    {
        public int IncidentReviewId { get; set; }

        //razor - ASP.NET MVC: Html.EditorFor and multi-line text boxes - Stack Overflow: 
        //https://stackoverflow.com/questions/6552980/asp-net-mvc-html-editorfor-and-multi-line-text-boxes        
        [DataType(DataType.MultilineText)] public string ReviewNotes { get; set; }
        public string TicketNumber { get; set; }
        public string ShortDescription { get; set; }
        public string Category { get; set; }
        public int? Severity { get; set; }
        public string Status { get; set; }
        public string AssignmentGroup { get; set; }
        public DateTime Opened { get; set; }
        public DateTime? Closed { get; set; }
        public string AssignedTo { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string Caller { get; set; }

        public DateTime? ReviewDate { get; set; }
        public List<string> Reviewers { get; set; }

        public string FauxContact { get; set; }
        //public Case Case { get; set; }
        public string NavigationPath { get; set; }
    }
}