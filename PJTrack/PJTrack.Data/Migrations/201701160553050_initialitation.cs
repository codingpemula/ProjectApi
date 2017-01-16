namespace PJTrack.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialitation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(nullable: false, maxLength: 100, unicode: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
