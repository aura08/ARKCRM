namespace ARKCRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class apoFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Page",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PageName = c.String(),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PageId = c.Int(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Page", t => t.PageId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PageId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Authority = c.Int(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPage", "UserId", "dbo.User");
            DropForeignKey("dbo.UserPage", "PageId", "dbo.Page");
            DropIndex("dbo.UserPage", new[] { "PageId" });
            DropIndex("dbo.UserPage", new[] { "UserId" });
            DropTable("dbo.User");
            DropTable("dbo.UserPage");
            DropTable("dbo.Page");
        }
    }
}
