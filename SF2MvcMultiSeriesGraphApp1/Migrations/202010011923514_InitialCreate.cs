namespace SyncfusionMvcApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectData",
                c => new
                    {
                        ProjectDataId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ProjectDataId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProjectData");
        }
    }
}
