namespace SyncfusionMvcApplicationRichTextEditor3.Models
{
    public class TrapezeNavItem
    {
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string ParentItemId { get; set; }
        public int ParentId { get; set; }
        public bool HasChildren { get; set; }
        public int AppDomainId { get; set; }
    }
}