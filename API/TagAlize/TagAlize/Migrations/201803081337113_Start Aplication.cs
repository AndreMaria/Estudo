namespace TagAlize.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartAplication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Labels",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(maxLength: 500),
                        IdSubjectMatter = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubjectMatters", t => t.IdSubjectMatter, cascadeDelete: true)
                .Index(t => t.IdSubjectMatter);
            
            CreateTable(
                "dbo.SubjectMatters",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Content = c.String(maxLength: 2500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SimpleText = c.String(maxLength: 500),
                        Normalized = c.String(maxLength: 500),
                        IdSubjectMatter = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubjectMatters", t => t.IdSubjectMatter, cascadeDelete: true)
                .Index(t => t.IdSubjectMatter);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Labels", "IdSubjectMatter", "dbo.SubjectMatters");
            DropForeignKey("dbo.Tags", "IdSubjectMatter", "dbo.SubjectMatters");
            DropIndex("dbo.Tags", new[] { "IdSubjectMatter" });
            DropIndex("dbo.Labels", new[] { "IdSubjectMatter" });
            DropTable("dbo.Tags");
            DropTable("dbo.SubjectMatters");
            DropTable("dbo.Labels");
        }
    }
}
