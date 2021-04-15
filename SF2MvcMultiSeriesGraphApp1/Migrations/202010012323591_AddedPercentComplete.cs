namespace SyncfusionMvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPercentComplete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectData", "PercentComplete", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectData", "PercentComplete");
        }
    }
}
