namespace SearchByTag.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start_Aplication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Text = c.String(maxLength: 500),
                        Category = c.String(maxLength: 100),
                        IdMain = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mains", t => t.IdMain, cascadeDelete: true)
                .Index(t => t.IdMain);
            
            CreateTable(
                "dbo.Mains",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Text = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Item = c.String(maxLength: 500),
                        Normalized = c.String(maxLength: 500),
                        IdMain = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mains", t => t.IdMain, cascadeDelete: true)
                .Index(t => t.IdMain);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Labels", "IdMain", "dbo.Mains");
            DropForeignKey("dbo.Tags", "IdMain", "dbo.Mains");
            DropIndex("dbo.Tags", new[] { "IdMain" });
            DropIndex("dbo.Labels", new[] { "IdMain" });
            DropTable("dbo.Tags");
            DropTable("dbo.Mains");
            DropTable("dbo.Labels");
        }
    }
}
