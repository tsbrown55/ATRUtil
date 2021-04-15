using System;

namespace SyncfusionMvcApplicationRichTextEditor3.Models
{
    public class FamilyMember 
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string ParentItemId { get; set; }
        public int ParentId { get; set; }
        public bool HasChildren { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BirthDate { get; set; }
    }
}